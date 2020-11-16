using System;
using System.Windows.Forms;
using WindowsFormsApp1.Coordinator.Department;
using WindowsFormsApp1.Coordinator.Task;
using WindowsFormsApp1.Coordinator.Team;

namespace PSO_DB.Coordinator
{
    public partial class CoordinatorMenu : Form
    {
        private Login _loginForm;

        public CoordinatorMenu(Login loginForm)
        {
            InitializeComponent();

            Show();

            _loginForm = loginForm;
        }

        private void TaskButtonClick(object sender, EventArgs e)
        {
            if (Login.CurrentUser.idTeam == null)
            {
                MessageBox.Show("У вас нету команды, невозможно выбрать задания!");
                return;
            }

            Hide();
            new TaskMenu(this);
        }

        private void TeamDepartmentButtonClick(object sender, EventArgs e)
        {
            if (Login.CurrentUser.idTeam == null)
            {
                MessageBox.Show("У вас нету команды, невозможно выбрать департамент!");
                return;
            }

            Hide();
            new Department(this);
        }

        private void MyTeamButtonClick(object sender, EventArgs e)
        {
            Hide();
            new TeamMenu(this);
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

        private void CoordinatorMenuFormClosed(object sender, FormClosedEventArgs e)
        {
            _loginForm.Show();
        }
    }
}
