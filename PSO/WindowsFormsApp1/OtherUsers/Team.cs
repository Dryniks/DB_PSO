using PSO_DB;
using PSO_DB.OtherUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.OtherUsers
{
    public partial class Team : Form
    {
        private readonly OtherUsersMenu _otherUserMenu;

        private const string _emptyPosition = "Позиция свободна";

        public Team(OtherUsersMenu otherUsersMenu)
        {
            InitializeComponent();
            Show();

            _otherUserMenu = otherUsersMenu;

            InitFields();
        }

        private void InitFields()
        {
            var context = new PSOConnect();

            var users = from user in context.user
                        join profession in context.profession on user.idProfession equals profession.idProfession
                        where user.idTeam == Login.CurrentUser.idTeam
                        select new
                        {
                            Profession = profession.position,
                            FIO = user.family + " " + user.name + " " + user.middleName
                        };

            TeamNameResultText.Text = context.team.FirstOrDefault(teams => teams.idTeam == Login.CurrentUser.idTeam).teamName;
            SeniorLifeguardResultText.Text = _emptyPosition;
            DoctorResultText.Text = _emptyPosition;
            ParamedicResultText.Text = _emptyPosition;
            DriverResultText.Text = _emptyPosition;
            PyrotechnicResultText.Text = _emptyPosition;
            GasWelderResultText.Text = _emptyPosition;
            CraneOperatorResultText.Text = _emptyPosition;
            DiverResultText.Text = _emptyPosition;
            HydraulicResultText.Text = _emptyPosition;
            ScoutResultText.Text = _emptyPosition;
            ElectricianResultText.Text = _emptyPosition;
            RescuerResultText.Text = _emptyPosition;


            foreach (var user in users)
            {
                switch (user.Profession)
                {
                    case "Главный спасатель":
                        SeniorLifeguardResultText.Text = user.FIO;
                        break;
                    case "Доктор":
                        DoctorResultText.Text = user.FIO;
                        break;
                    case "Фельдшер":
                        ParamedicResultText.Text = user.FIO;
                        break;
                    case "Водитель":
                        DriverResultText.Text = user.FIO;
                        break;
                    case "Пиротехник":
                        PyrotechnicResultText.Text = user.FIO;
                        break;
                    case "Газовщик":
                        GasWelderResultText.Text = user.FIO;
                        break;
                    case "Оператор крана":
                        CraneOperatorResultText.Text = user.FIO;
                        break;
                    case "Дайвер":
                        DiverResultText.Text = user.FIO;
                        break;
                    case "Гидравлик":
                        HydraulicResultText.Text = user.FIO;
                        break;
                    case "Разведчик":
                        ScoutResultText.Text = user.FIO;
                        break;
                    case "Электрик":
                        ElectricianResultText.Text = user.FIO;
                        break;
                    case "Зам гл. спасателя":
                        RescuerResultText.Text = user.FIO;
                        break;
                }
            }
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            ResetField();
            Hide();
            _otherUserMenu.Show();
        }

        private void TeamMenuFormClosed(object sender, FormClosedEventArgs e)
        {
            ResetField();
            _otherUserMenu.Show();
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
        }
    }
}

