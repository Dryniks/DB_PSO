using System;
using System.Linq;
using System.Windows.Forms;
using PSO_DB.Admin;
using PSO_DB.Coordinator;
using PSO_DB.OtherUsers;
using System.Drawing;
using WindowsFormsApp1;

namespace PSO_DB
{
    public partial class Registration : Form
    {
        public const char PasswordChar = '*';

        public const string Admin = "Админ";
        public const string Coordinator = "Координатор";

        private const string AdminPassword = "Dryna1895245";
        private const string CoordinatorPassword = "Dryna6938710";

        private Login _loginForm;

        public Registration(Login loginForm)
        {
            InitializeComponent();
            Show();

            _loginForm = loginForm;

            InitProfession();

            PasswordField.PasswordChar = PasswordChar;
            AdminPasswordField.PasswordChar = PasswordChar;
            CoordinatorPasswordField.PasswordChar = PasswordChar;
            ReturnPasswordField.PasswordChar = PasswordChar;
        }

        private void InitProfession()
        {
            var context = new PSOConnect();

            foreach (var profession in context.profession)
                ProfessionField.Items.Add(profession.position);

            if (ProfessionField.Items.Count > 0)
                ProfessionField.SelectedIndex = 0;
        }


        private void EnglishKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar >= '!' && e.KeyChar <= '}') || (char.IsControl(e.KeyChar)) ? false : true;
        }

        private void RussianKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == '-'|| (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (char.IsControl(e.KeyChar)) ? false : true;
        }

        private void EnableHandledKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void RegistationButtonClick(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(ReturnPasswordField.Text))
            {
                MessageBox.Show("Введите повторный пароль!");
                return;
            }

            if (!PasswordField.Text.Equals(ReturnPasswordField.Text))
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }

            if (string.IsNullOrEmpty(FamilyField.Text))
            {
                MessageBox.Show("Введите фамилию!");
                return;
            }

            if (string.IsNullOrEmpty(NameField.Text))
            {
                MessageBox.Show("Введите имя!");
                return;
            }

            if (string.IsNullOrEmpty(MiddleNameField.Text))
            {
                MessageBox.Show("Введите отчество!");
                return;
            }

            if (ProfessionField.SelectedItem.Equals(Admin) && string.IsNullOrEmpty(AdminPasswordField.Text))
            {
                MessageBox.Show("Введите пароль админа!");
                return;
            }

            if (ProfessionField.SelectedItem.Equals(Admin) && !AdminPasswordField.Text.Equals(AdminPassword))
            {
                MessageBox.Show("Неверный пароль админа!");
                return;
            }

            if (ProfessionField.SelectedItem.Equals(Coordinator) && string.IsNullOrEmpty(CoordinatorPasswordField.Text))
            {
                MessageBox.Show("Введите пароль координатора!");
                return;
            }

            if (ProfessionField.SelectedItem.Equals(Coordinator) && !CoordinatorPasswordField.Text.Equals(CoordinatorPassword))
            {
                MessageBox.Show("Неверный пароль координатора!");
                return;
            }

            RegistrationUser();
        }

        private void RegistrationUser()
        {
            var context = new PSOConnect();
            var user = context.user.FirstOrDefault(findUser => findUser.login.Equals(LoginField.Text));

            if (user != null)
            {
                MessageBox.Show("Пользователь с таким логином уже существует, измените логин!");
                return;
            }


            var lastIdUser = context.user.Count() > 0 ? context.user.Max(users=>users.idUser) : 0;
            var idProfession = context.profession.FirstOrDefault(profession => profession.position.Equals(ProfessionField.SelectedItem.ToString())).idProfession;
            var currentUser = new user
            {
                idUser = lastIdUser + 1,
                login = LoginField.Text,
                password = PasswordField.Text,
                family = FamilyField.Text,
                name = NameField.Text,
                middleName = MiddleNameField.Text,
                idProfession = idProfession
            };

            Login.CurrentUser = currentUser;
            context.user.Add(currentUser);
            context.SaveChanges();

            MessageBox.Show("Пользователь успешно добавлен!");

            if (ProfessionField.SelectedItem.Equals(Admin))
                new AdminMenu(_loginForm);
            else if (ProfessionField.SelectedItem.Equals(Coordinator))
                new CoordinatorMenu(_loginForm);
            else
                new OtherUsersMenu(_loginForm);

            ResetFields();
            Hide();
        }

        private void ProfessionFieldSelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProfessionField.SelectedItem.Equals(Admin))
            {
                AdminPasswordText.Show();
                AdminPasswordField.Show();
                CoordinatorPasswordField.Hide();
                CoordinatorPasswordText.Hide();
                CoordinatorPasswordField.Text = "";
            }
            else if (ProfessionField.SelectedItem.Equals(Coordinator))
            {
                AdminPasswordText.Hide();
                AdminPasswordField.Hide();
                CoordinatorPasswordField.Show();
                CoordinatorPasswordText.Show();
                AdminPasswordField.Text = "";
            }
            else
            {
                AdminPasswordText.Hide();
                AdminPasswordField.Hide();
                CoordinatorPasswordField.Hide();
                CoordinatorPasswordText.Hide();
                AdminPasswordField.Text = "";
                CoordinatorPasswordField.Text = "";
            }
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Hide();
            ResetFields();
            _loginForm.Show();
        }

        private void RegistrationFormClosed(object sender, FormClosedEventArgs e)
        {
            ResetFields();
            _loginForm.Show();
        }

        private void ResetFields()
        {
            LoginField.Text = "";
            PasswordField.Text = "";
            AdminPasswordField.Text = "";
            CoordinatorPasswordField.Text = "";
            ReturnPasswordField.Text = "";
            FamilyField.Text = "";
            NameField.Text = "";
            MiddleNameField.Text = "";
            ProfessionField.Items.Clear();
        }
    }
}
