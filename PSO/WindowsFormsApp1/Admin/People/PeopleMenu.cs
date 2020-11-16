using System;
using System.Linq;
using System.Windows.Forms;

using PSO_DB.Admin;

namespace WindowsFormsApp1.Admin.People
{
    public partial class PeopleMenu : Form
    {
        private readonly AdminMenu _adminMenuForm;

        public PeopleMenu(AdminMenu adminMenuForm)
        {
            InitializeComponent();

            Show();

            _adminMenuForm = adminMenuForm;

            InitListInfo();
        }

        private void InitListInfo()
        {
            var context = new PSOConnect();

            var missingPeople = from people in context.people
                                join missingPeoples in context.missingPeople on people.idPeople equals missingPeoples.idPeople
                                select new
                                {
                                    Id = people.idPeople,
                                    Family = people.family,
                                    Name = people.name,
                                    MiddleName = people.middleName,
                                    DateOfBirth = people.dateOfBirth,
                                    DateOfLoss = missingPeoples.dateOfLoss,
                                    LastLocation = missingPeoples.lastLocation,
                                    SpecialSign = missingPeoples.specialSign,
                                };

            foreach (var people in missingPeople)
                ListInfo.Items.Add($"{people.Id}-ФАМИЛИЯ: {people.Family} ИМЯ: {people.Name} ОТЧЕСТВО: {people.MiddleName} ДАТА РОЖДЕНИЯ: {people.DateOfBirth.Value.ToLongDateString()}\n ДАТА ПРОПАЖИ: {people.DateOfLoss.Value.ToLongDateString()} ПОСЛЕДНЕЕ МЕСТО: {people.LastLocation} ОПИСАНИЕ: {people.SpecialSign}");
        }

        private void AddMissingPeopleButtonClick(object sender, EventArgs e)
        {
            Hide();
            new People(this, () =>
            {
                ListInfo.Clear();
                InitListInfo();
            });

        }

        private void EditMissingPeopleButtonClick(object sender, EventArgs e)
        {
            if (ListInfo.Items.Count == 0)
            {
                MessageBox.Show("Список пропавших людей пуст!");
                return;
            }

            if (ListInfo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного элемента! Пожалуйста, выберите пропавшего человека");
                return;
            }

            if (ListInfo.SelectedItems.Count > 1)
            {
                MessageBox.Show("Выбрано более 1 элемента, пожалуйста, оставьте только 1 элемент!");
                return;
            }

            var context = new PSOConnect();
            var idPeople = int.Parse(ListInfo.SelectedItems[0].ToString().Split('-')[0].Split('{')[1]);
            var people = context.people.FirstOrDefault(peoples => peoples.idPeople == idPeople);

            Hide();
            new People(this, null, () => ListInfo.Items.Remove(ListInfo.SelectedItems[0]), EditListInfo, people);
        }

        private void EditListInfo(string listInfo)
        {
            for (var i = 0; i < ListInfo.Items.Count; i++)
            {
                if (ListInfo.Items[i].Equals(ListInfo.SelectedItems[0]))
                    ListInfo.Items[i].Text = listInfo;
            }
        }

        private void DeleteMissingPeopleButtonClick(object sender, EventArgs e)
        {
            if (ListInfo.Items.Count == 0)
            {
                MessageBox.Show("Список пропавших людей пуст!");
                return;
            }

            if (ListInfo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного элемента! Пожалуйста, выберите пропавшего человека");
                return;
            }

            var context = new PSOConnect();
            var count = ListInfo.SelectedItems.Count;

            for (var i = 0; i < count; i++)
            {
                var idPeople = int.Parse(ListInfo.SelectedItems[i].ToString().Split('-')[0].Split('{')[1]);
                var people = context.people.FirstOrDefault(peoples => peoples.idPeople == idPeople);
                var missingPeople = context.missingPeople.FirstOrDefault(missingPeoples => missingPeoples.idPeople == idPeople);

                foreach (var team in context.team)
                {
                    if (team.idPeople == missingPeople.idPeople)
                        team.idPeople = null;
                }

                ListInfo.Items.Remove(ListInfo.SelectedItems[i]);
                context.people.Remove(people);
                context.missingPeople.Remove(missingPeople);
                context.SaveChanges();
            }

            var message = count > 1 ? "Пропавшие люди успешно удалены" : "Пропавший человек успешно удалён";
            MessageBox.Show(message);
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Hide();
            _adminMenuForm.Show();
        }

        private void PeopleMenuFormClosed(object sender, FormClosedEventArgs e)
        {
            _adminMenuForm.Show();
        }
    }
}
