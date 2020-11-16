using System;
using System.Linq;
using System.Windows.Forms;

using PSO_DB.Admin;

namespace WindowsFormsApp1.Admin.Disaster
{
    public partial class DisasterMenu : Form
    {
        private AdminMenu _adminMenuForm;

        public DisasterMenu(AdminMenu adminMenuForm)
        {
            InitializeComponent();

            Show();

            _adminMenuForm = adminMenuForm;

            InitListInfo();
        }

        private void InitListInfo()
        {
            var context = new PSOConnect();

            var disasters = context.GetDisasterData();

            foreach (var disaster in disasters)
                ListInfo.Items.Add($"{disaster.idReason}-ТИП: {disaster.typeReason} ПРИЧИНА: {disaster.reason} СТРАНА: {disaster.country} ГОРОД: {disaster.city} ДАТА: {disaster.date.Value.ToLongDateString()}");
        }

        private void AddDisasterButtonClick(object sender, EventArgs e)
        {
            Hide();
            new Disaster(this, () =>
            {
                ListInfo.Clear();
                InitListInfo();
            });
        }

        private void EditDisasterButtonClick(object sender, EventArgs e)
        {
            if (ListInfo.Items.Count == 0)
            {
                MessageBox.Show("Список катастроф пуст!");
                return;
            }

            if (ListInfo.SelectedItems.Count > 1)
            {
                MessageBox.Show("Выбрано более 1 катастрофы, пожалуйста, оставьте только 1 катастрофу");
                return;
            }

            if (ListInfo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного элемента! Пожалуйста, выберите катастрофу");
                return;
            }

            var context = new PSOConnect();
            var idReason = int.Parse(ListInfo.SelectedItems[0].ToString().Split('-')[0].Split('{')[1]);
            var reason = context.reason.FirstOrDefault(reasons => reasons.idReason == idReason);

            Hide();
            new Disaster(this, null, () => ListInfo.Items.Remove(ListInfo.SelectedItems[0]), EditListInfo, reason);
        }

        private void EditListInfo(string listInfo)
        {
            for (var i = 0; i < ListInfo.Items.Count; i++)
            {
                if (ListInfo.Items[i].Equals(ListInfo.SelectedItems[0]))
                    ListInfo.Items[i].Text = listInfo;
            }
        }

        private void DeleteDisasterButtonClick(object sender, EventArgs e)
        {
            if (ListInfo.Items.Count == 0)
            {
                MessageBox.Show("Список катастроф пуст!");
                return;
            }

            if (ListInfo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного элемента! Пожалуйста, выберите катастрофу");
                return;
            }

            var context = new PSOConnect();
            var count = ListInfo.SelectedItems.Count;

            for (var i = 0; i < count; i++)
            {
                var idReason = int.Parse(ListInfo.SelectedItems[0].ToString().Split('-')[0].Split('{')[1]);
                var reason = context.reason.FirstOrDefault(reasons => reasons.idReason == idReason);
                var disaster = context.disaster.FirstOrDefault(disasters => disasters.idDisaster == reason.idDisaster);

                foreach (var team in context.team)
                {
                    if (team.idDisaster == disaster.idDisaster && disaster.reason.Count < 1)
                        team.idDisaster = null;
                }

                context.reason.Remove(reason);

                if (disaster.reason.Count < 1)
                    context.disaster.Remove(disaster);

                ListInfo.Items.Remove(ListInfo.SelectedItems[0]);

                context.SaveChanges();
            }

            var message = count > 1 ? "Катастрофы успешно удалены" : "Катастрофа успешно удалёна";
            MessageBox.Show(message);
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Hide();
            _adminMenuForm.Show();
        }

        private void DisasterMenuFormClosed(object sender, FormClosedEventArgs e)
        {
            _adminMenuForm.Show();
        }
    }
}
