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
    public partial class Disaster : Form
    {
        private readonly TaskMenu _taskMenu;

        private disaster _disaster;

        public Disaster(TaskMenu taskMenu)
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

            foreach (var disaster in context.disaster)
            {
                if (team.idDisaster == null || team.idDisaster != disaster.idDisaster)
                    continue;

                CountyResultText.Text = disaster.country.ToString();
                CityResultText.Text = disaster.city.ToString();
                DateResultText.Text = disaster.date.Value.ToShortDateString();
                ReasonText.Text = disaster.reason.Count > 1 ? "Причины" : "Причина";

                foreach (var reason in disaster.reason)
                    ListInfo.Items.Add($"ТИП: {reason.typeReason} ПРИЧИНА: {reason.reason1}");
            }
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            ResetField();
            Hide();
            _taskMenu.Show();
        }

        private void DisasterFormClosed(object sender, FormClosedEventArgs e)
        {
            ResetField();
            _taskMenu.Show();
        }

        private void ResetField()
        {
            DateResultText.Text = "";
            CityResultText.Text = "";
            CountyResultText.Text = "";

            ListInfo.Items.Clear();
        }
    }
}
