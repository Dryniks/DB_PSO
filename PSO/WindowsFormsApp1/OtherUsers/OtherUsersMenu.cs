using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp1.OtherUsers;
using WindowsFormsApp1.OtherUsers.Task;

namespace PSO_DB.OtherUsers
{
    public partial class OtherUsersMenu : Form
    {
        private Login _loginForm;

        public OtherUsersMenu(Login loginForm)
        {
            InitializeComponent();

            Show();

            _loginForm = loginForm;
        }

        private void TeamButtonClick(object sender, EventArgs e)
        {
            if (Login.CurrentUser.idTeam == null)
            {
                MessageBox.Show("У вас нет команды, ожидайте, пока координатор добавит вас");
                return;
            }

            Hide();
            new Team(this);
        }

        private void TaskButtonClick(object sender, EventArgs e)
        {
            if (Login.CurrentUser.idTeam == null)
            {
                MessageBox.Show("У вас нет команды, ожидайте, пока координатор добавит вас");
                return;
            }

            Hide();
            new TaskMenu(this);
        }

        private void MyUniformButtonClick(object sender, EventArgs e)
        {
            var context = new PSOConnect();

            var equpment = context.equipment.FirstOrDefault(equipments => equipments.idProfession == Login.CurrentUser.idProfession);

            if (equpment == null)
            {
                MessageBox.Show("У вас нету оборудования, обратитесь к администратору, для заполнения");
                return;
            }

            Hide();
            new Equipment(this);
        }

        private void OtherUsersMenuFormClosed(object sender, FormClosedEventArgs e)
        {
            _loginForm.Show();
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
           var dialog =  MessageBox.Show( "Вы действительно хотите выйти из аккаунта?", "Выход", MessageBoxButtons.YesNo);

            if(dialog == DialogResult.Yes)
            {
                Hide();
                _loginForm.Show();
            }
        }
    }
}
