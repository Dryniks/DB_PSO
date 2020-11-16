using System;
using System.Linq;
using System.Windows.Forms;

using PSO_DB.Admin;

namespace WindowsFormsApp1.Admin.Profession
{
    public partial class ProfessionMenu : Form
    {
        private readonly AdminMenu _adminMenuForm;

        public ProfessionMenu(AdminMenu adminMenuForm)
        {
            InitializeComponent();

            Show();

            _adminMenuForm = adminMenuForm;

            InitListInfo();
        }

        private void InitListInfo()
        {
            var context = new PSOConnect();

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
                ListInfo.Items.Add($"{equipment.Id}-ТИП: {equipment.Type} НАЗВАНИЕ: {equipment.EquipmentName} ОПИСАНИЕ: {equipment.Description} ПРОФЕССИИ: {equipment.Profession}");
        }

        private void AddEquipmentButtonClick(object sender, EventArgs e)
        {
            Hide();
            new Profession(this, () =>
            {
                ListInfo.Clear();
                InitListInfo();
            });
        }

        private void EditEquipmentButtonClick(object sender, EventArgs e)
        {
            if (ListInfo.Items.Count == 0)
            {
                MessageBox.Show("Список оборудования пуст!");
                return;
            }

            if (ListInfo.SelectedItems.Count > 1)
            {
                MessageBox.Show("Выбрано более 1 оборудование, пожалуйста, оставьте только 1 оборудование");
                return;
            }

            if (ListInfo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного элемента! Пожалуйста, выберите оборудование");
                return;
            }

            var context = new PSOConnect();
            var idEquipment = int.Parse(ListInfo.SelectedItems[0].ToString().Split('-')[0].Split('{')[1]);
            var equpment = context.equipment.FirstOrDefault(equpments => equpments.idEquipment == idEquipment);

            Hide();
            new EditProfession(this, EditListInfo, () => ListInfo.Items.Remove(ListInfo.SelectedItems[0]), equpment);
        }

        private void EditListInfo(string listInfo)
        {
            for (var i = 0; i < ListInfo.Items.Count; i++)
            {
                if (ListInfo.Items[i].Equals(ListInfo.SelectedItems[0]))
                    ListInfo.Items[i].Text = listInfo;
            }
        }

        private void DeleteEquipmentButtonClick(object sender, EventArgs e)
        {
            if (ListInfo.Items.Count == 0)
            {
                MessageBox.Show("Список оборудования пуст!");
                return;
            }

            if (ListInfo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного элемента! Пожалуйста, выберите оборудование");
                return;
            }

            var context = new PSOConnect();
            var count = ListInfo.SelectedItems.Count;

            for (var i = 0; i < count; i++)
            {
                var idEquipment = int.Parse(ListInfo.SelectedItems[0].ToString().Split('-')[0].Split('{')[1]);
                var equipment = context.equipment.FirstOrDefault(equipments => equipments.idEquipment == idEquipment);
                var profession = context.profession.FirstOrDefault(professions => professions.idProfession == equipment.idProfession);

                context.equipment.Remove(equipment);

                if (profession.equipment.Count < 1)
                    context.profession.Remove(profession);

                ListInfo.Items.Remove(ListInfo.SelectedItems[0]);

                context.SaveChanges();
            }

            var message = count > 1 ? "Оборудования успешно удалены" : "Оборудование успешно удалёно";
            MessageBox.Show(message);
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Hide();
            _adminMenuForm.Show();
        }

        private void ProfessionMenuFormClosed(object sender, FormClosedEventArgs e)
        {
            _adminMenuForm.Show();
        }
    }
}
