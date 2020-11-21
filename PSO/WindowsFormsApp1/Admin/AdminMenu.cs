using System;
using System.Windows.Forms;
using WindowsFormsApp1.Admin.Departamet;
using WindowsFormsApp1.Admin.Disaster;
using WindowsFormsApp1.Admin.People;
using WindowsFormsApp1.Admin.Profession;

namespace PSO_DB.Admin
{
    public partial class AdminMenu : Form
    {
        private Login _loginForm;

        public AdminMenu(Login loginForm)
        {
            InitializeComponent();

            Show();

            _loginForm = loginForm;
        }

        private void DisasterButtonClick(object sender, EventArgs e)
        {
            Hide();
            new DisasterMenu(this);
        }

        private void MissingPeopleButtonClick(object sender, EventArgs e)
        {
            Hide();
            new PeopleMenu(this);
        }

        private void DepartmentButtonClick(object sender, EventArgs e)
        {
            Hide();
            new DepatmentMenu(this);
        }

        private void ProfessionButtonClick(object sender, EventArgs e)
        {
            Hide();
            new ProfessionMenu(this);
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Вы действительно хотите выйти из аккаунта?", "Выход", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Hide();
                _loginForm.Show();
            }
        }
        private void AdminMenuFormClosed(object sender, FormClosedEventArgs e)
        {
            _loginForm.Show();
        }
    }
}
