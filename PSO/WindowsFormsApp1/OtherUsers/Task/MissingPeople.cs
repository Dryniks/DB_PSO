using PSO_DB;
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
                if (team.idPeople == null || team.idPeople != people.idPeople)
                    continue;

                FioResultText.Text = $"{people.family} {people.name} {people.middleName}";
                DateOfBirthResultText.Text = people.dateOfBirth.Value.ToShortDateString();
                SpecialSignResultText.Text = people.specialSign;
                LastLocationResultText.Text = people.lastLocation;
                DateOfLossResultText.Text = people.dateOfLoss.Value.ToShortDateString();
            }

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
        }
    }
}
