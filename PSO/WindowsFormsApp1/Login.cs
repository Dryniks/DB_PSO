using System;
using System.Linq;
using System.Windows.Forms;

using PSO_DB.Admin;
using PSO_DB.Coordinator;
using PSO_DB.OtherUsers;
using WindowsFormsApp1;

namespace PSO_DB
{
    public partial class Login : Form
    {
        public static user CurrentUser;

        public Login()
        {
            InitializeComponent();

            PasswordField.PasswordChar = Registration.PasswordChar;
        }

        private void EnglishKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar >= '!' && e.KeyChar <= '}') || (char.IsControl(e.KeyChar)) ? false : true;
        }

        private void AuthorizationButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LoginField.Text))
            {
                MessageBox.Show("Введите логин!");
                return;
            }

            if (string.IsNullOrEmpty(PasswordField.Text))
            {
                MessageBox.Show("Введите пароль!");
                return;
            }

            var context = new PSOConnect();
            var getUser = context.user.FirstOrDefault(user => user.login.Equals(LoginField.Text) && user.password.Equals(PasswordField.Text));

            if (getUser == null)
            {
                var getLogin = context.user.FirstOrDefault(user => user.login.Equals(LoginField.Text));
                var message = getLogin != null ? "Неверный пароль" : "Такого логина не существует";
                MessageBox.Show(message);
            }
            else
            {
                var currentProfession = context.profession.FirstOrDefault(profession => profession.idProfession == getUser.idProfession).position;
                ResetFields();
                CurrentUser = getUser;

                MessageBox.Show($"Добро пожаловать, {CurrentUser.family} {CurrentUser.name} {CurrentUser.middleName}");

                if (currentProfession.Equals(Registration.Admin))
                    new AdminMenu(this);
                else if (currentProfession.Equals(Registration.Coordinator))
                    new CoordinatorMenu(this);
                else
                    new OtherUsersMenu(this);

                Hide();
            }
        }

        private void RegistrationButtonClick(object sender, EventArgs e)
        {
            ResetFields();
            Hide();
            new Registration(this);
        }

        private void LoginFormClosed(object sender, FormClosedEventArgs e)
        {
            ResetFields();
            MessageBox.Show("Спасибо за то, что пользовались данной бд");
            Environment.Exit(1);
        }

        private void ResetFields()
        {
            LoginField.Text = "";
            PasswordField.Text = "";
        }
    }
}
