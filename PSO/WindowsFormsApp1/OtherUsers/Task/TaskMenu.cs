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

namespace WindowsFormsApp1.OtherUsers.Task
{
    public partial class TaskMenu : Form
    {

        private readonly OtherUsersMenu _otherUsersMenu;

        public TaskMenu(OtherUsersMenu otherUsersMenu)
        {
            InitializeComponent();
            Show();

            _otherUsersMenu = otherUsersMenu;
        }

        private void MissingPeopleButtonClick(object sender, EventArgs e)
        {
            var context = new PSOConnect();
            var idMissingPeople = context.team.FirstOrDefault(team => team.idTeam == Login.CurrentUser.idTeam).idPeople;

            if (idMissingPeople == null)
            {
                MessageBox.Show("В данный момент нет актуального задания связанным с поиском человека");
                return;
            }

            Hide();
             new MissingPeople(this);
        }

        private void DisasterButtonClick(object sender, EventArgs e)
        {
            var context = new PSOConnect();
            var idDisaster = context.team.FirstOrDefault(team => team.idTeam == Login.CurrentUser.idTeam).idDisaster;

            if (idDisaster == null)
            {
                MessageBox.Show("В данный момент нет актуального задания связанным с катастрофой");
                return;
            }

            Hide();
            new Disaster(this);
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Hide();
            _otherUsersMenu.Show();
        }

        private void TaskMenuFormClosed(object sender, FormClosedEventArgs e)
        {
            _otherUsersMenu.Show();
        }
    }
}

