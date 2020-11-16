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

namespace WindowsFormsApp1.Coordinator.Task
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
                SelectDisasterField.Items.Add($"{ disaster.idDisaster}-СТРАНА: { disaster.country} ГОРОД: { disaster.city} ДАТА: { disaster.date.Value.ToLongDateString()}");

                if (team.idDisaster == null || team.idDisaster != disaster.idDisaster)
                    continue;

                SelectDisasterField.SelectedItem = SelectDisasterField.Items[SelectDisasterField.Items.Count - 1];

                _disaster = disaster;

                CountyResultText.Text = disaster.country.ToString();
                CityResultText.Text = disaster.city.ToString();
                DateResultText.Text = disaster.date.Value.ToShortDateString();
                ReasonText.Text = disaster.reason.Count > 1 ? "Причины" : "Причина";               

                foreach (var reason in disaster.reason)
                    ListInfo.Items.Add($"ТИП: {reason.typeReason} ПРИЧИНА: {reason.reason1}");

            }

            NoFoundDisasterText.Hide();

            if (team.idDisaster == null)
            {
                ListInfo.Hide();
                ReasonText.Hide();
                DateResultText.Hide();
                DateText.Hide();
                CountryText.Hide();
                CountyResultText.Hide();
                CityResultText.Hide();
                CityText.Hide();

                SelectDisasterField.Show();
                SelectDisasterText.Show();

                SelectedButton.Show();
                CompletedButton.Hide();

                if (SelectDisasterField.Items.Count > 0)
                    SelectDisasterField.SelectedIndex = 0;
                else
                {
                    SelectedButton.Hide();
                    NoFoundDisasterText.Show();
                    SelectDisasterField.Hide();
                }
            }
            else
            {
                ListInfo.Show();
                ReasonText.Show();
                DateResultText.Show();
                DateText.Show();
                CountryText.Show();
                CountyResultText.Show();
                CityResultText.Show();
                CityText.Show();

                SelectDisasterField.Hide();
                SelectDisasterText.Hide();

                SelectedButton.Hide();
                CompletedButton.Show();
            }

            if (SelectDisasterField.Items.Count == 0)
            {
                SelectDisasterField.Hide();
                NoFoundDisasterText.Show();
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
            var disaster = context.disaster.FirstOrDefault(disasters => disasters.idDisaster == _disaster.idDisaster);
            var reasons = context.reason.Where(reason => reason.idDisaster == disaster.idDisaster);

            foreach (var reason in reasons)
                context.reason.Remove(reason);

            disaster.team.Clear();
            disaster.reason.Clear();

            context.disaster.Remove(disaster);
            context.SaveChanges();

            MessageBox.Show("Поздравляем с выполненым заданием!");

            ResetField();
            InitFields();
        }

        private void SelectButtonClick(object sender, EventArgs e)
        {
            if (NoFoundDisasterText.Visible)
            {
                MessageBox.Show("Выбор невозможен, нет катастроф, с чем вас и поздравляем :)");
                return;
            }

            var context = new PSOConnect();
            var team = context.team.FirstOrDefault(teams => teams.idTeam == Login.CurrentUser.idTeam);
            var idDisaster = int.Parse(SelectDisasterField.SelectedItem.ToString().Split('-')[0]);
            team.idDisaster = idDisaster;

            context.SaveChanges();

            MessageBox.Show("Не подведите, катастрофа слишком серьёзна, сделайте всё, что в ваших силах!");

            ResetField();
            InitFields();
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
            SelectDisasterField.Items.Clear();
        }
    }
}
