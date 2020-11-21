using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;

namespace WindowsFormsApp1.Admin.People
{
    public partial class People : Form
    {
        private readonly Action<string> _updatedListInfo;
        private readonly Action _addedListInfo;
        private readonly Action _deletedElementInListInfo;

        private readonly PeopleMenu _peopleMenu;

        private readonly int _idPeople;

        public People(PeopleMenu peopleMenu, Action addedListInfo = null, Action deletedElementInListInfo = null, Action<string> updatedListInfo = null, people people = null)
        {
            InitializeComponent();

            Show();

            _peopleMenu = peopleMenu;
            _idPeople = people != null ? people.idPeople : 0;
            _addedListInfo = addedListInfo;
            _updatedListInfo = updatedListInfo;
            _deletedElementInListInfo = deletedElementInListInfo;

            DateOfBirthField.MaxDate = DateTime.Now;
            DateOfBirthField.MinDate = DateTime.Now.AddYears(-130);

            DateOfLossField.MaxDate = DateTime.Now;
            DateOfLossField.MinDate = DateTime.Now.AddYears(-1);

            InitFields(people);
        }

        private void InitFields(people people)
        {
            if (people == null)
            {
                EditMissingPeopleButton.Hide();
                AddMissingPeopleButton.Show();
                DateOfBirthField.Value = DateTime.Now.AddSeconds(-1);
                DateOfLossField.Value = DateTime.Now.AddSeconds(-1);
            }
            else
            {
                EditMissingPeopleButton.Show();
                AddMissingPeopleButton.Hide();

                FamilyField.Text = people.family;
                NameField.Text = people.name;
                MiddleNameField.Text = people.middleName;
                DateOfBirthField.Value = people.dateOfBirth.Value;

                var context = new PSOConnect();
                var missingPeople = context.missingPeople.FirstOrDefault(missingPeoples => missingPeoples.idPeople == people.idPeople);

                SpecialSignField.Text = missingPeople.specialSign;
                LastLocationField.Text = missingPeople.lastLocation;
                DateOfLossField.Value = missingPeople.dateOfLoss.Value;
            }
        }

        private void LastLocaleAndSpecialSignKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ';' || e.KeyChar == ':' || e.KeyChar == ')' || e.KeyChar == '(' || e.KeyChar == '?' || e.KeyChar == '!' || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == ' ' || e.KeyChar == '-' || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (char.IsControl(e.KeyChar)) ? false : true;
        }

        private void RussianKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == '-' || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (char.IsControl(e.KeyChar)) ? false : true;
        }

        private void EnableHandledKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void EditMissingPeopleButtonClick(object sender, EventArgs e)
        {
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

            if (string.IsNullOrEmpty(LastLocationField.Text))
            {
                MessageBox.Show("Введите последнее место, где видели человека!");
                return;
            }

            if (string.IsNullOrEmpty(SpecialSignField.Text))
            {
                MessageBox.Show("Введите описание человека!");
                return;
            }

            EditMissingPeople();

            MessageBox.Show("Информация о пропавшем человеке успешно отредактирована!");

            Hide();
            ResetFields();
            _peopleMenu.Show();
        }

        private void EditMissingPeople()
        {
            var context = new PSOConnect();

            var checkExistPeople = context.people.FirstOrDefault(peoples => peoples.family.Equals(FamilyField.Text) && peoples.name.Equals(NameField.Text) && peoples.middleName.Equals(MiddleNameField.Text) && EntityFunctions.TruncateTime(peoples.dateOfBirth.Value) == EntityFunctions.TruncateTime(DateOfBirthField.Value));
            var checkExistMissingPeople = context.missingPeople.FirstOrDefault(missingPeoples => missingPeoples.specialSign.Equals(SpecialSignField.Text) && missingPeoples.lastLocation.Equals(LastLocationField.Text) && EntityFunctions.TruncateTime(missingPeoples.dateOfLoss.Value) == EntityFunctions.TruncateTime(DateOfLossField.Value));

            var people = context.people.FirstOrDefault(peoples => peoples.idPeople == _idPeople);
            var missingPeople = context.missingPeople.FirstOrDefault(missingPeoples => missingPeoples.idPeople == _idPeople);

            if (checkExistMissingPeople != null && checkExistPeople != null && checkExistMissingPeople.idPeople != _idPeople && checkExistPeople.idPeople != _idPeople)
            {
                _deletedElementInListInfo?.Invoke();
                context.people.Remove(people);
                context.missingPeople.Remove(missingPeople);
                context.SaveChanges();
                return;
            }

            people.family = FamilyField.Text;
            people.name = NameField.Text;
            people.middleName = MiddleNameField.Text;
            people.dateOfBirth = DateOfBirthField.Value;

            missingPeople.specialSign = SpecialSignField.Text;
            missingPeople.lastLocation = LastLocationField.Text;
            missingPeople.dateOfLoss = DateOfLossField.Value;

            _updatedListInfo?.Invoke($"{people.idPeople}-ФАМИЛИЯ: {FamilyField.Text} ИМЯ: {NameField.Text} ОТЧЕСТВО: {MiddleNameField.Text} ДАТА РОЖДЕНИЯ: {DateOfBirthField.Value.ToLongDateString()}\n ДАТА ПРОПАЖИ: {DateOfLossField.Value.ToLongDateString()} ПОСЛЕДНЕЕ МЕСТО: {LastLocationField.Text} ОПИСАНИЕ: {SpecialSignField.Text}");

            context.SaveChanges();
        }

        private void AddMissingPeopleButtonClick(object sender, EventArgs e)
        {
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

            if (string.IsNullOrEmpty(LastLocationField.Text))
            {
                MessageBox.Show("Введите последнее место, где видели человека!");
                return;
            }

            if (string.IsNullOrEmpty(SpecialSignField.Text))
            {
                MessageBox.Show("Введите описание человека!");
                return;
            }

            AddMissingPeople();

            _addedListInfo?.Invoke();
            MessageBox.Show("Информация о пропавшем человеке успешно добавлена!");

            Hide();
            ResetFields();
            _peopleMenu.Show();
        }

        private void AddMissingPeople()
        {
            var context = new PSOConnect();
            var people = context.people.FirstOrDefault(peoples => peoples.family.Equals(FamilyField.Text) && peoples.name.Equals(NameField.Text) && peoples.middleName.Equals(MiddleNameField.Text) && EntityFunctions.TruncateTime(peoples.dateOfBirth.Value) == EntityFunctions.TruncateTime(DateOfBirthField.Value));
            var missingPeople = context.missingPeople.FirstOrDefault(missingPeoples => missingPeoples.specialSign.Equals(SpecialSignField.Text) && missingPeoples.lastLocation.Equals(LastLocationField.Text) && EntityFunctions.TruncateTime(missingPeoples.dateOfLoss.Value) == EntityFunctions.TruncateTime(DateOfLossField.Value));

            if (people == null || missingPeople == null)
            {
                var newPeople = new people
                {
                    idPeople = context.people.Count() > 0 ? context.people.Max(idPeople => idPeople.idPeople) + 1 : 1,
                    family = FamilyField.Text,
                    name = NameField.Text,
                    middleName = MiddleNameField.Text,
                    dateOfBirth = DateOfBirthField.Value
                };

                var newMissingPeople = new missingPeople
                {
                    idPeople = context.missingPeople.Count() > 0 ? context.missingPeople.Max(idPeople => idPeople.idPeople) + 1 : 1,
                    specialSign = SpecialSignField.Text,
                    lastLocation = LastLocationField.Text,
                    dateOfLoss = DateOfLossField.Value
                };

                context.people.Add(newPeople);
                context.missingPeople.Add(newMissingPeople);
                context.SaveChanges();
            }
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Hide();
            ResetFields();
            _peopleMenu.Show();
        }

        private void PeopleFormClosed(object sender, FormClosedEventArgs e)
        {
            ResetFields();
            _peopleMenu.Show();
        }

        private void ResetFields()
        {
            FamilyField.Text = "";
            NameField.Text = "";
            MiddleNameField.Text = "";
            DateOfBirthField.Value = DateOfBirthField.MaxDate.AddSeconds(-1);
            SpecialSignField.Text = "";
            LastLocationField.Text = "";
            DateOfLossField.Value = DateOfLossField.MaxDate.AddSeconds(-1);
        }
    }
}
