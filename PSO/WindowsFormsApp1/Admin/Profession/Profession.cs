using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApp1.Admin.Profession
{
    public partial class Profession : Form
    {
        private readonly Action _addedListInfo;

        private readonly ProfessionMenu _professionMenu;

        private readonly string[] _typeEqipment = new string[] { "Дыхательные аппараты и системы", "Гидравлическое оборудование", "Силовые стойки", "Пневмодомкраты, течеуплотнители и ёмкости", "Осветительное оборудование", "Компрессоры, дымососы и генераторы", "Мотопомпы и насосы", "Пневмооборудование быстрого развертывания", "Ручной механизированный инстумент", "Защитная одежда и обувь", "Приборы", "Автомобили", "Оборудование для эвакуации" };

        private readonly List<equipment> _equipment = new List<equipment>();

        public Profession(ProfessionMenu professionMenu, Action addedListInfo = null)
        {
            InitializeComponent();

            Show();

            _professionMenu = professionMenu;
            _addedListInfo = addedListInfo;

            InitFields();
        }

        private void InitFields()
        {
            foreach (var type in _typeEqipment)
                TypeEqupmentField.Items.Add(type);

            TypeEqupmentField.SelectedIndex = 0;
        }

        private void DescriptionKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ';' || e.KeyChar == ':' || e.KeyChar == ')' || e.KeyChar == '(' || e.KeyChar == '?' || e.KeyChar == '!' || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == ' ' || e.KeyChar == '-' || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (char.IsControl(e.KeyChar)) ? false : true;
        }

        private void RussianKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ' ' || e.KeyChar == '-' || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (char.IsControl(e.KeyChar)) ? false : true;
        }

        private void EnableHandledKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AddProfessionButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProfessionField.Text))
            {
                MessageBox.Show("Введите профессию!");
                return;
            }

            if (ListInfo.Items.Count < 1)
            {
                MessageBox.Show("Добавьте оборудование!");
                return;
            }

            AddProfession();

            _addedListInfo?.Invoke();
            MessageBox.Show("Информация об оборудовании для профессии успешно добавлена!");

            Hide();
            ResetFields();
            _professionMenu.Show();
        }

        private void AddEquipmentButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameEquipmentField.Text))
            {
                MessageBox.Show("Введите название оборудования!");
                return;
            }

            if (string.IsNullOrEmpty(DescriptionEqupmentField.Text))
            {
                MessageBox.Show("Введите описание оборудования!");
                return;
            }

            var context = new PSOConnect();
            var equipment = new equipment
            {
                idEquipment = context.equipment.Count() > 0 ? context.equipment.Max(equipments => equipments.idEquipment) + 1 + _equipment.Count : 1 + _equipment.Count,
                type = TypeEqupmentField.SelectedItem.ToString(),
                equipmentName = NameEquipmentField.Text,
                description = DescriptionEqupmentField.Text
            };

            foreach (var equipmentList in _equipment)
            {
                if (equipment.type.Equals(equipmentList.type) && equipment.equipmentName.Equals(equipmentList.equipmentName) && equipment.description.Equals(equipmentList.description))
                {
                    ResetEquipmentField();
                    return;
                }
            }

            _equipment.Add(equipment);
            ListInfo.Items.Add($"{equipment.idEquipment}-НАЗВАНИЕ: {equipment.equipmentName} ТИП: {equipment.type} ОПИСАНИЕ: {equipment.description}");
            ResetEquipmentField();
        }

        private void AddProfession()
        {
            var context = new PSOConnect();
            var profession = context.profession.FirstOrDefault(professions => professions.position.Equals(ProfessionField.Text));

            if (profession == null)
            {
                var currentProfession = new profession
                {
                    idProfession = context.profession.Count() > 0 ? context.profession.Max(professions => professions.idProfession) + 1 : 1,
                    position = ProfessionField.Text
                };

                foreach (var equipment in _equipment)
                {
                    currentProfession.equipment.Add(equipment);
                    context.equipment.Add(equipment);
                }

                context.profession.Add(currentProfession);
            }
            else
            {
                foreach (var equipment in _equipment)
                {
                    if (profession.equipment.Contains(equipment))
                        continue;

                    profession.equipment.Add(equipment);

                }
            }

            context.SaveChanges();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Hide();
            ResetFields();
            _professionMenu.Show();
        }

        private void ProfessionFormClosed(object sender, FormClosedEventArgs e)
        {
            ResetFields();
            _professionMenu.Show();
        }

        private void ResetEquipmentField()
        {
            TypeEqupmentField.SelectedIndex = 0;
            NameEquipmentField.Text = "";
            DescriptionEqupmentField.Text = "";
        }

        private void ResetFields()
        {
            ProfessionField.Text = "";
            ResetEquipmentField();
            ListInfo.Items.Clear();
            _equipment.Clear();
        }
    }
}
