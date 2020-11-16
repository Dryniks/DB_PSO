using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1.Admin.Profession
{
    public partial class EditProfession : Form
    {
        private readonly Action<string> _updatedListInfo;
        private readonly Action _deletedListInfo;

        private readonly ProfessionMenu _professionMenu;
        private readonly int _idEquipment;

        private readonly string[] _typeEqipment = new string[] { "Дыхательные аппараты и системы", "Гидравлическое оборудование", "Силовые стойки", "Пневмодомкраты, течеуплотнители и ёмкости", "Осветительное оборудование", "Компрессоры, дымососы и генераторы", "Мотопомпы и насосы", "Пневмооборудование быстрого развертывания", "Ручной механизированный инстумент", "Защитная одежда и обувь", "Приборы", "Автомобили", "Оборудование для эвакуации" };

        public EditProfession(ProfessionMenu professionMenu, Action<string> updatedListInfo, Action deletedListInfo, equipment equipment)
        {
            InitializeComponent();

            Show();

            _professionMenu = professionMenu;
            _updatedListInfo = updatedListInfo;
            _idEquipment = equipment.idEquipment;
            _deletedListInfo = deletedListInfo;

            InitFields(equipment);
        }

        private void InitFields(equipment equipment)
        {
            var context = new PSOConnect();
            DescriptionEqupmentField.Text = equipment.description;
            NameEquipmentField.Text = equipment.equipmentName;

            foreach (var type in _typeEqipment)
            {
                TypeEqupmentField.Items.Add(type);

                if (type.Equals(equipment.type))
                    TypeEqupmentField.SelectedItem = type;
            }

            ProfessionField.Text = context.profession.FirstOrDefault(profession => profession.idProfession == equipment.idProfession).position;
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

        private void EditProfessionButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProfessionField.Text))
            {
                MessageBox.Show("Введите профессию!");
                return;
            }

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

            EditProfesson();

            MessageBox.Show("Информация об оборудовании для профессии успешно обновлена!");

            Hide();
            ResetFields();
            _professionMenu.Show();
        }

        private void EditProfesson()
        {
            if (CheckExist())
                return;

            var context = new PSOConnect();
            var equipment = context.equipment.FirstOrDefault(equipments => equipments.idEquipment == _idEquipment);

            equipment.equipmentName = NameEquipmentField.Text;
            equipment.type = TypeEqupmentField.SelectedItem.ToString();
            equipment.description = DescriptionEqupmentField.Text;

            var profession = context.profession.FirstOrDefault(professions => professions.idProfession == equipment.idProfession);

            var checkExistProfession = context.profession.FirstOrDefault(professions => professions.position.Equals(ProfessionField.Text));
            profession currentProfession = null;

            if (profession.equipment.Count == 1)
            {
                currentProfession = profession;
                profession.position = ProfessionField.Text;
            }
            else if (checkExistProfession != null)
            {
                currentProfession = checkExistProfession;
                checkExistProfession.equipment.Add(equipment);
            }
            else
            {
                currentProfession = new profession
                {
                    idProfession = context.profession.Count() > 0 ? context.profession.Max(idProfession => idProfession.idProfession) + 1 : 1,
                    position = ProfessionField.Text
                };

                currentProfession.equipment.Add(equipment);
                context.profession.Add(currentProfession);
            }

            _updatedListInfo?.Invoke($"{equipment.idEquipment}-ТИП: {TypeEqupmentField.SelectedItem} НАЗВАНИЕ: {NameEquipmentField.Text} ОПИСАНИЕ: {DescriptionEqupmentField.Text} ПРОФЕССИИ: {ProfessionField.Text}");

            context.SaveChanges();
        }

        private bool CheckExist()
        {
            var context = new PSOConnect();
            var checkExist = false;
            var equipments = from equipment in context.equipment
                             join profession in context.profession on equipment.idProfession equals profession.idProfession
                             select new
                             {
                                 Id = equipment.idEquipment,
                                 Type = equipment.type,
                                 EquipmentName = equipment.equipmentName,
                                 Description = equipment.description,
                                 Profession = profession.position
                             };

            foreach (var equipment in equipments)
            {
                if (equipment.Type.Equals(TypeEqupmentField.SelectedItem.ToString()) && equipment.EquipmentName.Equals(NameEquipmentField.Text) && equipment.Description.Equals(DescriptionEqupmentField.Text) && equipment.Profession.Equals(ProfessionField.Text))
                {
                    checkExist = true;
                    break;
                }
            }

            if (checkExist)
            {
                var equipment = context.equipment.FirstOrDefault(equip => equip.idEquipment == _idEquipment);
                var profession = context.profession.FirstOrDefault(professions => professions.idProfession == equipment.idProfession);

                context.equipment.Remove(equipment);

                if (profession.equipment.Count < 1)
                    context.profession.Remove(profession);

                context.SaveChanges();
                _deletedListInfo?.Invoke();
                return true;
            }

            return false;
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Hide();
            ResetFields();
            _professionMenu.Show();
        }

        private void EditProfessionFormClosed(object sender, FormClosedEventArgs e)
        {
            ResetFields();
            _professionMenu.Show();
        }

        private void ResetFields()
        {
            ProfessionField.Text = "";
            TypeEqupmentField.SelectedIndex = 0;
            NameEquipmentField.Text = "";
            DescriptionEqupmentField.Text = "";
        }
    }
}
