using PSO_DB;
using PSO_DB.Coordinator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Coordinator.Task
{
    public partial class MissingPeople : Form
    {
        private readonly TaskMenu _taskMenu;

        public MissingPeople(TaskMenu taskMenu)
        {
            InitializeComponent();
            Show();

            _taskMenu = taskMenu;

            InitFields();
        }

        private void InitFields()
        {
            var context = new PSOConnect();
            var team = context.team.FirstOrDefault(teams => teams.idTeam == Login.CurrentUser.idTeam);

            var missingPeople = context.GetPeopleData();

            foreach (var people in missingPeople)
            {
                SelectMissingPeopleField.Items.Add($"{people.idPeople}-ФАМИЛИЯ: {people.family} ИМЯ: {people.name} ОТЧЕСТВО: {people.middleName} ДАТА РОЖДЕНИЯ: {people.dateOfBirth.Value.ToLongDateString()}\n ДАТА ПРОПАЖИ: {people.dateOfLoss.Value.ToLongDateString()} ПОСЛЕДНЕЕ МЕСТО: {people.lastLocation} ОПИСАНИЕ: {people.specialSign}");

                if (team.idPeople == null || team.idPeople != people.idPeople)
                    continue;

                SelectMissingPeopleField.SelectedItem = SelectMissingPeopleField.Items[SelectMissingPeopleField.Items.Count - 1];

                IdPeopleText.Text = people.idPeople.ToString();
                FioResultText.Text = $"{people.family} {people.name} {people.middleName}";
                DateOfBirthResultText.Text = people.dateOfBirth.Value.ToShortDateString();
                SpecialSignResultText.Text = people.specialSign;
                LastLocationResultText.Text = people.lastLocation;
                DateOfLossResultText.Text = people.dateOfLoss.Value.ToShortDateString();
            }

            IdPeopleText.Hide();
            NoFoundMissingPeopleText.Hide();

            if (team.idPeople == null)
            {
                FioResultText.Hide();
                DateOfBirthResultText.Hide();
                SpecialSignResultText.Hide();
                LastLocationResultText.Hide();
                DateOfLossResultText.Hide();
                FIOText.Hide();
                DateOfBirthText.Hide();
                SpecialSignText.Hide();
                LastLocationText.Hide();
                DateOfLossText.Hide();
                SelectMissingPeopleField.Show();
                SelectMissingPeopleText.Show();
                SelectedButton.Show();
                CompletedButton.Hide();

                if (SelectMissingPeopleField.Items.Count > 0)
                    SelectMissingPeopleField.SelectedIndex = 0;
                else
                {
                    SelectedButton.Hide();
                    NoFoundMissingPeopleText.Show();
                    SelectMissingPeopleField.Hide();
                }
            }
            else
            {
                FioResultText.Show();
                DateOfBirthResultText.Show();
                SpecialSignResultText.Show();
                LastLocationResultText.Show();
                DateOfLossResultText.Show();
                FIOText.Show();
                DateOfBirthText.Show();
                SpecialSignText.Show();
                LastLocationText.Show();
                DateOfLossText.Show();
                SelectMissingPeopleField.Hide();
                SelectMissingPeopleText.Hide();
                SelectedButton.Hide();
                CompletedButton.Show();
            }

            if (SelectMissingPeopleField.Items.Count == 0)
            {
                SelectMissingPeopleField.Hide();
                NoFoundMissingPeopleText.Show();
                CompletedButton.Hide();
            }
        }

        private void EnableHandledKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CompletedButtonClick(object sender, EventArgs e)
        {
            var context = new PSOConnect();
            var idPeople = int.Parse(IdPeopleText.Text);
            var missingPeople = context.missingPeople.FirstOrDefault(missinpPeoples => missinpPeoples.idPeople == idPeople);
            var people = context.people.FirstOrDefault(peoples => peoples.idPeople == idPeople);

            missingPeople.team.Clear();

            context.missingPeople.Remove(missingPeople);
            context.people.Remove(people);
            context.SaveChanges();

            MessageBox.Show("Поздравляем с выполненым заданием!");

            ResetField();
            InitFields();
        }

        private void SelectButtonClick(object sender, EventArgs e)
        {
            if (NoFoundMissingPeopleText.Visible)
            {
                MessageBox.Show("Выбор невозможен, нет пропавших людей, с чем вас и поздравляем :)");
                return;
            }

            var context = new PSOConnect();
            var team = context.team.FirstOrDefault(teams => teams.idTeam == Login.CurrentUser.idTeam);
            var idPeople = int.Parse(SelectMissingPeopleField.SelectedItem.ToString().Split('-')[0]);
            team.idPeople = idPeople;

            context.SaveChanges();

            MessageBox.Show("Не подведите, родственники хотят, чтобы вы его нашли!");

            ResetField();
            InitFields();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            ResetField();
            Hide();
            _taskMenu.Show();
        }

        private void PeopleFormClosed(object sender, FormClosedEventArgs e)
        {
            ResetField();
            _taskMenu.Show();
        }

        private void ResetField()
        {
            FioResultText.Text = "";
            DateOfBirthResultText.Text = "";
            SpecialSignResultText.Text = "";
            DateOfLossResultText.Text = "";
            LastLocationResultText.Text = "";

            SelectMissingPeopleField.Items.Clear();
        }
    }
}
