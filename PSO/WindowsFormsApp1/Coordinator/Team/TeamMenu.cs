using PSO_DB;
using PSO_DB.Admin;
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

namespace WindowsFormsApp1.Coordinator.Team
{

    public partial class TeamMenu : Form
    {
        private readonly CoordinatorMenu _coordinatorMenu;

        public TeamMenu(CoordinatorMenu coordinatorMenu)
        {
            InitializeComponent();
            Show();

            _coordinatorMenu = coordinatorMenu;

            InitFields();
        }

        private void InitFields()
        {
            var context = new PSOConnect();

            var users = from user in context.user
                        join profession in context.profession on user.idProfession equals profession.idProfession
                        where user.idTeam==null || user.idTeam == Login.CurrentUser.idTeam
                        select new
                        {
                            Profession = profession.position,
                            FIO = user.idUser+"-"+ user.family + " " + user.name + " " + user.middleName
                        };


            foreach (var user in users)
            {
                switch (user.Profession)
                {
                    case "Главный спасатель":
                        SeniorLifeguardField.Items.Add(user.FIO);
                        break;
                    case "Доктор":
                        DoctorField.Items.Add(user.FIO);
                        break;
                    case "Фельдешр":
                        ParamedicField.Items.Add(user.FIO);
                        break;
                    case "Водитель":
                        DriverField.Items.Add(user.FIO);
                        break;
                    case "Пиротехник":
                        PyrotechnicField.Items.Add(user.FIO);
                        break;
                    case "Газосварщик":
                        GasWelderField.Items.Add(user.FIO);
                        break;
                    case "Оператор крана":
                        CraneOperatorField.Items.Add(user.FIO);
                        break;
                    case "Драйвер":
                        DiverField.Items.Add(user.FIO);
                        break;
                    case "Гидравлик":
                        HydraulicField.Items.Add(user.FIO);
                        break;
                    case "Разведчик":
                        ScoutField.Items.Add(user.FIO);
                        break;
                    case "Электрик":
                        ElectricianField.Items.Add(user.FIO);
                        break;
                    case "Заместитель гл спасателя":
                        RescuerField.Items.Add(user.FIO);
                        break;
                }

            }

            SelectField(SeniorLifeguardField, SeniorLifeguardNoFoundText, SeniorLifeguardResultText);
            SelectField(DoctorField, DoctorNoFoundText, DoctorResultText);
            SelectField(ParamedicField, ParamedicNoFoundText, ParamedicResultText);
            SelectField(DriverField, DriverNoFoundText, DriverResultText);
            SelectField(PyrotechnicField, PyrotechnicNoFoundText, PyrotechnicResultText);
            SelectField(GasWelderField, GasWelderNoFoundText, GasWelderResultText);
            SelectField(CraneOperatorField, CraneOperatorNoFoundText, CraneOperatorResultText);
            SelectField(DiverField, DiverNoFoundText, DiverResultText);
            SelectField(HydraulicField, HydraulicNoFoundText, HydraulicResultText);
            SelectField(ScoutField, ScoutNoFoundText, ScoutResultText);
            SelectField(ElectricianField, ElectricianNoFoundText, ElectricianResultText);
            SelectField(RescuerField, RescuerNoFoundText, RescuerResultText);

            TeamNameField.Show();
            TeamNameResultText.Hide();

            if (Login.CurrentUser.idTeam != null)
            {
                TeamNameField.Hide();
                TeamNameResultText.Show();
                TeamNameResultText.Text = context.team.FirstOrDefault(team => team.idTeam == Login.CurrentUser.idTeam).teamName;

                var userTeam = from user in context.user
                               join profession in context.profession on user.idProfession equals profession.idProfession
                               where user.idTeam == Login.CurrentUser.idTeam
                               select new
                               {
                                   Profession = profession.position,
                                   FIO = user.idUser + "-" + user.family + " " + user.name + " " + user.middleName
                               };

                foreach (var user in userTeam)
                {
                    switch (user.Profession)
                    {
                        case "Главный спасатель":
                            InitResult(SeniorLifeguardField, SeniorLifeguardNoFoundText, SeniorLifeguardResultText, user.FIO);
                            break;
                        case "Доктор":
                            InitResult(DoctorField, DoctorNoFoundText, DoctorResultText, user.FIO);
                            break;
                        case "Фельдешр":
                            InitResult(ParamedicField, ParamedicNoFoundText, ParamedicResultText, user.FIO);
                            break;
                        case "Водитель":
                            InitResult(DriverField, DriverNoFoundText, DriverResultText, user.FIO);
                            break;
                        case "Пиротехник":
                            InitResult(PyrotechnicField, PyrotechnicNoFoundText, PyrotechnicResultText, user.FIO);
                            break;
                        case "Газосварщик":
                            InitResult(GasWelderField, GasWelderNoFoundText, GasWelderResultText, user.FIO);
                            break;
                        case "Оператор крана":
                            InitResult(CraneOperatorField, CraneOperatorNoFoundText, CraneOperatorResultText, user.FIO);
                            break;
                        case "Драйвер":
                            InitResult(DiverField, DiverNoFoundText, DiverResultText, user.FIO);
                            break;
                        case "Гидравлик":
                            InitResult(HydraulicField, HydraulicNoFoundText, HydraulicResultText, user.FIO);
                            break;
                        case "Разведчик":
                            InitResult(ScoutField, ScoutNoFoundText, ScoutResultText, user.FIO);
                            break;
                        case "Электрик":
                            InitResult(ElectricianField, ElectricianNoFoundText, ElectricianResultText, user.FIO);
                            break;
                        case "Заместитель гл спасателя":
                            InitResult(RescuerField, RescuerNoFoundText, RescuerResultText, user.FIO);
                            break;
                    }

                }
            }
        }

        private void InitResult(ComboBox combo, Label noFoundSpecialist, Label result, string fio)
        {
            noFoundSpecialist.Hide();
            combo.Hide();
            result.Show();
            result.Text = fio;
        }

        private void SelectField(ComboBox combo, Label noFoundSpecialist, Label result)
        {
            if (combo.Items.Count == 0)
            {
                combo.Hide();
                noFoundSpecialist.Show();
            }
            else
            {
                combo.Show();
                combo.SelectedIndex = 0;
                noFoundSpecialist.Hide();
            }

            result.Hide();
        }

        private void EnableHandledKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void RussianKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ' ' || e.KeyChar == '-' || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (char.IsControl(e.KeyChar)) ? false : true;
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TeamNameResultText.Text) && string.IsNullOrEmpty(TeamNameField.Text))
            {
                MessageBox.Show("Введите название команды!");
                return;
            }

            var context = new PSOConnect();
            var lol = DoctorField.SelectedItem.ToString().Split('-');
            var lol2 =int.Parse(string.IsNullOrEmpty(DoctorResultText.Text)? DoctorField.SelectedItem.ToString().Split('-')[0] : DoctorResultText.Text.Split('-')[0]);
            var searchTeam = context.teamPosition.FirstOrDefault(team => team.idTeam == Login.CurrentUser.idTeam);
            var idSeniorLifeguard = SeniorLifeguardField.Items.Count==0 && string.IsNullOrEmpty(SeniorLifeguardResultText.Text) ? null : (int?) int.Parse(string.IsNullOrEmpty(SeniorLifeguardResultText.Text) ? SeniorLifeguardField.SelectedItem.ToString().Split('-')[0] : SeniorLifeguardResultText.Text.Split('-')[0]);
            var idDoctor = DoctorField.Items.Count == 0 && string.IsNullOrEmpty(DoctorResultText.Text) ? null : (int?)int.Parse(string.IsNullOrEmpty(DoctorResultText.Text) ? DoctorField.SelectedItem.ToString().Split('-')[0] : DoctorResultText.Text.Split('-')[0]);
            var idParamedic = ParamedicField.Items.Count == 0 && string.IsNullOrEmpty(ParamedicResultText.Text) ? null : (int?)int.Parse(string.IsNullOrEmpty(ParamedicResultText.Text) ? ParamedicField.SelectedItem.ToString().Split('-')[0] : ParamedicResultText.Text.Split('-')[0]);
            var idDriver = DriverField.Items.Count == 0 && string.IsNullOrEmpty(DriverResultText.Text) ? null : (int?)int.Parse(string.IsNullOrEmpty(DriverResultText.Text) ? DriverField.SelectedItem.ToString().Split('-')[0] : DriverResultText.Text.Split('-')[0]);
            var idPyrotechnic = PyrotechnicField.Items.Count == 0 && string.IsNullOrEmpty(PyrotechnicResultText.Text) ? null : (int?)int.Parse(string.IsNullOrEmpty(PyrotechnicResultText.Text) ? PyrotechnicField.SelectedItem.ToString().Split('-')[0] : PyrotechnicResultText.Text.Split('-')[0]);
            var idGasWelder = GasWelderField.Items.Count == 0 && string.IsNullOrEmpty(GasWelderResultText.Text) ? null : (int?)int.Parse(string.IsNullOrEmpty(GasWelderResultText.Text) ? GasWelderField.SelectedItem.ToString().Split('-')[0] : GasWelderResultText.Text.Split('-')[0]);
            var idCraneOperator = CraneOperatorField.Items.Count == 0 && string.IsNullOrEmpty(CraneOperatorResultText.Text) ? null : (int?)int.Parse(string.IsNullOrEmpty(CraneOperatorResultText.Text) ? CraneOperatorField.SelectedItem.ToString().Split('-')[0] : CraneOperatorResultText.Text.Split('-')[0]);
            var idDiver = DiverField.Items.Count == 0 && string.IsNullOrEmpty(DiverResultText.Text) ? null : (int?)int.Parse(string.IsNullOrEmpty(DiverResultText.Text) ? DiverField.SelectedItem.ToString().Split('-')[0] : DiverResultText.Text.Split('-')[0]);
            var idHydraulic = HydraulicField.Items.Count == 0 && string.IsNullOrEmpty(HydraulicResultText.Text) ? null : (int?)int.Parse(string.IsNullOrEmpty(HydraulicResultText.Text) ? HydraulicField.SelectedItem.ToString().Split('-')[0] : SeniorLifeguardResultText.Text.Split('-')[0]);
            var idScout = ScoutField.Items.Count == 0 && string.IsNullOrEmpty(ScoutResultText.Text) ? null : (int?)int.Parse(string.IsNullOrEmpty(ScoutResultText.Text) ? ScoutField.SelectedItem.ToString().Split('-')[0] : ScoutResultText.Text.Split('-')[0]);
            var idElectrician = ElectricianField.Items.Count == 0 && string.IsNullOrEmpty(ElectricianResultText.Text) ? null : (int?)int.Parse(string.IsNullOrEmpty(ElectricianResultText.Text) ? ElectricianField.SelectedItem.ToString().Split('-')[0] : ElectricianResultText.Text.Split('-')[0]);
            var idRescuer = RescuerField.Items.Count == 0 && string.IsNullOrEmpty(RescuerResultText.Text) ? null : (int?)int.Parse(string.IsNullOrEmpty(RescuerResultText.Text) ? RescuerField.SelectedItem.ToString().Split('-')[0] : RescuerResultText.Text.Split('-')[0]);
            var teamName = string.IsNullOrEmpty( TeamNameResultText.Text) ? TeamNameField.Text : TeamNameResultText.Text;

            if (searchTeam == null)
            {
                var teamPosition = new teamPosition
                {
                    idTeam = context.teamPosition.Count() > 0 ? context.teamPosition.Max(team => team.idTeam) + 1 : 1,
                    seniorLifeguard = idSeniorLifeguard,
                    doctor = idDoctor,
                    paramedic = idParamedic,
                    driver = idDriver,
                    pyrotechnist = idPyrotechnic,
                    gasWelder = idGasWelder,
                    craneOperator = idCraneOperator,
                    scubaDriver = idDiver,
                    hydraulicEquipmentTechnician = idHydraulic,
                    scout = idScout,
                    electrician = idElectrician,
                    rescuer = idRescuer
                };

                var currentTeam = new team
                {
                    idTeam = context.team.Count() > 0 ? context.team.Max(team => team.idTeam) + 1 : 1,
                    teamName = teamName
                };

                var coordinator = new coordinator
                {
                    idTeam = context.coordinator.Count() > 0 ? context.coordinator.Max(team => team.idTeam) + 1 : 1,
                };

                var currentCoordinator = context.user.FirstOrDefault(user => user.login.Equals(Login.CurrentUser.login));
                currentCoordinator.idTeam = currentTeam.idTeam;
                Login.CurrentUser = currentCoordinator;
                context.coordinator.Add(coordinator);
                context.team.Add(currentTeam);
                context.teamPosition.Add(teamPosition);
            }
            else
            {
                searchTeam.seniorLifeguard = idSeniorLifeguard;
                searchTeam.doctor = idDoctor;
                searchTeam.paramedic = idParamedic;
                searchTeam.driver = idDriver;
                searchTeam.pyrotechnist = idPyrotechnic;
                searchTeam.gasWelder = idGasWelder;
                searchTeam.craneOperator = idCraneOperator;
                searchTeam.scubaDriver = idDiver;
                searchTeam.hydraulicEquipmentTechnician = idHydraulic;
                searchTeam.scout = idScout;
                searchTeam.electrician = idElectrician;
                searchTeam.rescuer = idRescuer;

                var currentTeam = context.team.FirstOrDefault(team => team.idTeam == Login.CurrentUser.idTeam);

                currentTeam.teamName = teamName;
            }

            context.SaveChanges();
            ResetField();
            InitFields();
            MessageBox.Show("Команда успешно зарегистрирована!");
        }

        private void EditButtonClick(object sender, EventArgs e)
        {
            EditField(SeniorLifeguardField, SeniorLifeguardNoFoundText, SeniorLifeguardResultText);
            EditField(DoctorField, DoctorNoFoundText, DoctorResultText);
            EditField(ParamedicField, ParamedicNoFoundText, ParamedicResultText);
            EditField(DriverField, DriverNoFoundText, DriverResultText);
            EditField(PyrotechnicField, PyrotechnicNoFoundText, PyrotechnicResultText);
            EditField(GasWelderField, GasWelderNoFoundText, GasWelderResultText);
            EditField(CraneOperatorField, CraneOperatorNoFoundText, CraneOperatorResultText);
            EditField(DiverField, DiverNoFoundText, DiverResultText);
            EditField(HydraulicField, HydraulicNoFoundText, HydraulicResultText);
            EditField(ScoutField, ScoutNoFoundText, ScoutResultText);
            EditField(ElectricianField, ElectricianNoFoundText, ElectricianResultText);
            EditField(RescuerField, RescuerNoFoundText, RescuerResultText);

            SeniorLifeguardResultText.Text = "";
            DoctorResultText.Text = "";
            ParamedicResultText.Text = "";
            DriverResultText.Text = "";
            PyrotechnicResultText.Text = "";
            GasWelderResultText.Text = "";
            CraneOperatorResultText.Text = "";
            DiverResultText.Text = "";
            HydraulicResultText.Text = "";
            ScoutResultText.Text = "";
            ElectricianResultText.Text = "";
            RescuerResultText.Text = "";
        }

        private void EditField(ComboBox combo, Label noFoundSpecialist, Label result)
        {
            if (combo.Items.Count == 0)
            {
                combo.Hide();
                noFoundSpecialist.Show();
            }
            else
            {
                combo.Show();
                combo.SelectedItem =string.IsNullOrEmpty(result.Text)? combo.Items[0] : result.Text;
                noFoundSpecialist.Hide();
            }

            result.Hide();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            ResetField();
            Hide();
            _coordinatorMenu.Show();
        }

        private void TeamMenuFormClosed(object sender, FormClosedEventArgs e)
        {
            ResetField();
            _coordinatorMenu.Show();
        }

        private void ResetField()
        {
            SeniorLifeguardResultText.Text = "";
            DoctorResultText.Text = "";
            ParamedicResultText.Text = "";
            DriverResultText.Text = "";
            PyrotechnicResultText.Text = "";
            GasWelderResultText.Text = "";
            CraneOperatorResultText.Text = "";
            DiverResultText.Text = "";
            HydraulicResultText.Text = "";
            ScoutResultText.Text = "";
            ElectricianResultText.Text = "";
            RescuerResultText.Text = "";

            SeniorLifeguardField.Items.Clear();
            DoctorField.Items.Clear();
            ParamedicField.Items.Clear();
            DriverField.Items.Clear();
            PyrotechnicField.Items.Clear();
            GasWelderField.Items.Clear();
            CraneOperatorField.Items.Clear();
            DiverField.Items.Clear();
            HydraulicField.Items.Clear();
            ScoutField.Items.Clear();
            ElectricianField.Items.Clear();
            RescuerField.Items.Clear();
        }
    }
}
