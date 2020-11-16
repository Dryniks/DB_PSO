using PSO_DB;
using PSO_DB.OtherUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.OtherUsers
{
    public partial class Equipment : Form
    {
        private OtherUsersMenu _otherUsersMenu;

        public Equipment(OtherUsersMenu otherUsersMenu)
        {
            InitializeComponent();

            Show();

            _otherUsersMenu = otherUsersMenu;

            InitListInfo();
        }

        private void InitListInfo()
        {
            var context = new PSOConnect();

            var equipments = from equipment in context.equipment
                             join profession in context.profession on equipment.idProfession equals profession.idProfession
                             where profession.idProfession == Login.CurrentUser.idProfession
                             select new
                             {
                                 Id = equipment.idEquipment,
                                 Type = equipment.type,
                                 EquipmentName = equipment.equipmentName,
                                 Description = equipment.description,
                                 Profession = profession.position
                             };

            foreach (var equipment in equipments)
                ListInfo.Items.Add($"ТИП: {equipment.Type} НАЗВАНИЕ: {equipment.EquipmentName} ОПИСАНИЕ: {equipment.Description}");
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Hide();
            _otherUsersMenu.Show();
        }

        private void EquipmentFormClosed(object sender, FormClosedEventArgs e)
        {
            _otherUsersMenu.Show();
        }
    }
}
