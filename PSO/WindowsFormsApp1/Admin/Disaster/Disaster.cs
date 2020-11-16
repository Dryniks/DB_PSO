using System;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1.Admin.Disaster
{
    public partial class Disaster : Form
    {
        private readonly Action<string> _updatedListInfo;
        private readonly Action _addedListInfo;
        private readonly Action _deletedListInfo;

        private readonly DisasterMenu _disasterMenu;

        private readonly string[] _typeDisasters = new string[] { "Извержение вулкана", "Землятрясение", "Цунами", "Наводнение", "Лимнологическая катастрофа", "Ураган", "Тайфун", "Смерч", "Буран", "Терракт", "Война", "Транспортная катастрофа", "Промышленная катастрофа" };

        private readonly int _idReason;

        public Disaster(DisasterMenu disasterMenu, Action addedListInfo = null, Action deletedListInfo = null, Action<string> updatedListInfo = null, reason reason = null)
        {
            InitializeComponent();

            Show();

            _disasterMenu = disasterMenu;
            _idReason = reason != null ? reason.idReason : 0;
            _addedListInfo = addedListInfo;
            _updatedListInfo = updatedListInfo;
            _deletedListInfo = deletedListInfo;

            InitFields(reason);
        }

        private void InitFields(reason reason)
        {
            foreach (var type in _typeDisasters)
                TypeField.Items.Add(type);

            DateField.MaxDate = DateTime.Now;
            DateField.MinDate = DateTime.Now.AddDays(-14);

            if (reason == null)
            {
                EditDisasterButton.Hide();
                AddDisasterButton.Show();
                TypeField.SelectedIndex = 0;
                DateField.Value = DateTime.Now.AddSeconds(-1);
            }
            else
            {
                EditDisasterButton.Show();
                AddDisasterButton.Hide();

                foreach (var item in TypeField.Items)
                {
                    if (item.Equals(reason.typeReason))
                        TypeField.SelectedItem = item;
                }

                ReasonField.Text = reason.reason1;

                var context = new PSOConnect();
                var disaster = context.disaster.FirstOrDefault(disasters => disasters.idDisaster == reason.idDisaster);

                CountryField.Text = disaster.country;
                CityField.Text = disaster.city;
                DateField.Value = disaster.date.Value;
            }
        }

        private void ReasonKeyPress(object sender, KeyPressEventArgs e)
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

        private void EditDisasterButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ReasonField.Text))
            {
                MessageBox.Show("Введите причину!");
                return;
            }

            if (string.IsNullOrEmpty(CountryField.Text))
            {
                MessageBox.Show("Введите страну!");
                return;
            }

            if (string.IsNullOrEmpty(CityField.Text))
            {
                MessageBox.Show("Введите город!");
                return;
            }

            EditDisaster();

            MessageBox.Show("Информация о катастрофе успешно отредактирована!");

            Hide();
            ResetFields();
            _disasterMenu.Show();
        }

        private void EditDisaster()
        {
            if (CheckExist())
                return;

            var context = new PSOConnect();
            var reason = context.reason.FirstOrDefault(reasons => reasons.idReason == _idReason);
            var disaster = context.disaster.FirstOrDefault(disasters => disasters.idDisaster == reason.idDisaster);
            var checkExistDisaster = context.disaster.FirstOrDefault(disasters => disasters.country.Equals(CountryField.Text) && disasters.city.Equals(CityField.Text) && EntityFunctions.TruncateTime(disasters.date.Value) == EntityFunctions.TruncateTime(DateField.Value));
            disaster currentDisaster;

            reason.reason1 = ReasonField.Text;
            reason.typeReason = TypeField.SelectedItem.ToString();

            if (disaster.reason.Count == 1)
            {
                currentDisaster = disaster;
                currentDisaster.country = CountryField.Text;
                currentDisaster.city = CityField.Text;
                currentDisaster.date = DateField.Value;
            }
            else if (checkExistDisaster != null)
            {
                currentDisaster = checkExistDisaster;
                checkExistDisaster.reason.Add(reason);
            }
            else
            {
                currentDisaster = new disaster
                {
                    idDisaster = context.disaster.Count() > 0 ? context.disaster.Max(idDisaster => idDisaster.idDisaster) + 1 : 1,
                    country = CountryField.Text,
                    city = CityField.Text,
                    date = DateField.Value
                };

                currentDisaster.reason.Add(reason);
                context.disaster.Add(currentDisaster);
            }

            _updatedListInfo?.Invoke($"{reason.idReason}-ТИП: {TypeField.SelectedItem} ПРИЧИНА: {ReasonField.Text} СТРАНА: {CountryField.Text} ГОРОД: {CityField.Text} ДАТА: {DateField.Value.ToLongDateString()}");
            context.SaveChanges();
        }

        private bool CheckExist()
        {
            var context = new PSOConnect();
            var checkExist = false;
            var disasters = from reason in context.reason
                            join disaster in context.disaster on reason.idDisaster equals disaster.idDisaster
                            select new
                            {
                                Id = reason.idReason,
                                Type = reason.typeReason,
                                Reason = reason.reason1,
                                County = disaster.country,
                                City = disaster.city,
                                Date = disaster.date,
                            };

            foreach (var disaster in disasters)
            {
                if (disaster.Type.Equals(TypeField.SelectedItem.ToString()) && disaster.Reason.Equals(ReasonField.Text) && disaster.County.Equals(CountryField.Text) && disaster.City.Equals(CityField.Text) && EntityFunctions.TruncateTime(disaster.Date.Value) == EntityFunctions.TruncateTime(DateField.Value))
                {
                    checkExist = true;
                    break;
                }
            }

            if (checkExist)
            {
                var reason = context.reason.FirstOrDefault(reasons => reasons.idReason == _idReason);
                var disaster = context.disaster.FirstOrDefault(dis => dis.idDisaster == reason.idDisaster);

                context.reason.Remove(reason);

                if (disaster.reason.Count < 1)
                    context.disaster.Remove(disaster);

                context.SaveChanges();
                _deletedListInfo?.Invoke();
                return true;
            }

            return false;
        }

        private void AddDisasterButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ReasonField.Text))
            {
                MessageBox.Show("Введите причину!");
                return;
            }

            if (string.IsNullOrEmpty(CountryField.Text))
            {
                MessageBox.Show("Введите страну!");
                return;
            }

            if (string.IsNullOrEmpty(CityField.Text))
            {
                MessageBox.Show("Введите город!");
                return;
            }

            AddDisaster();

            _addedListInfo?.Invoke();
            MessageBox.Show("Информация о катастрофе успешно добавлена!");

            Hide();
            ResetFields();
            _disasterMenu.Show();
        }

        private void AddDisaster()
        {
            var context = new PSOConnect();

            var disaster = context.disaster.FirstOrDefault(disasters => disasters.country.Equals(CountryField.Text) && disasters.city.Equals(CityField.Text) && EntityFunctions.TruncateTime(disasters.date.Value) == EntityFunctions.TruncateTime(DateField.Value));
            disaster currentDisaster = null;

            if (disaster == null)
            {
                currentDisaster = new disaster
                {
                    idDisaster = context.disaster.Count() > 0 ? context.disaster.Max(disasters => disasters.idDisaster) + 1 : 1,
                    country = CountryField.Text,
                    city = CityField.Text,
                    date = DateField.Value
                };

                context.disaster.Add(currentDisaster);
            }
            else
                currentDisaster = disaster;

            var reason = context.reason.FirstOrDefault(reasons => reasons.typeReason.Equals(TypeField.SelectedItem.ToString()) && reasons.reason1.Equals(ReasonField.Text) && reasons.idDisaster == currentDisaster.idDisaster);
            reason currentReason = null;

            if (reason == null)
            {
                currentReason = new reason
                {
                    idReason = context.reason.Count() > 0 ? context.reason.Max(reasons => reasons.idReason) + 1 : 1,
                    typeReason = TypeField.Text,
                    reason1 = ReasonField.Text,
                };

                currentDisaster.reason.Add(currentReason);
                context.reason.Add(currentReason);
            }

            context.SaveChanges();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Hide();
            ResetFields();
            _disasterMenu.Show();
        }

        private void DisasterFormClosed(object sender, FormClosedEventArgs e)
        {
            ResetFields();
            _disasterMenu.Show();
        }

        private void ResetFields()
        {
            TypeField.SelectedIndex = 0;
            ReasonField.Text = "";
            CountryField.Text = "";
            CityField.Text = "";
            DateField.Value = DateField.MaxDate.AddSeconds(-1);
        }
    }
}
