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

namespace WindowsFormsApp1.Coordinator.Department
{
    public partial class Department : Form
    {
        private readonly CoordinatorMenu _coordinatorMenu;

        public Department(CoordinatorMenu coordinatorMenu)
        {
            InitializeComponent();
            Show();

            _coordinatorMenu = coordinatorMenu;

            InitFields();
        }

        private void InitFields()
        {
            var context = new PSOConnect();
            var coordinator = context.coordinator.FirstOrDefault(coord => coord.idTeam == Login.CurrentUser.idTeam);

            var departments = from region in context.region
                              join department in context.department on region.idDepartment equals department.idDepartment
                              join mainDepartment in context.mainDepartment on department.idMainDepartment equals mainDepartment.idMainDepartment
                              select new
                              {
                                  Id = region.idRegion,
                                  AddressRegion = region.address,
                                  AddressDepartment = department.address,
                                  AddressMainDepartment = mainDepartment.address
                              };

            foreach (var dep in departments)
            {
                SelectRegionField.Items.Add($"{dep.Id}-АДРЕС РЕГИОНА: {dep.AddressRegion} АДРЕС ДЕПАРТАМЕНТА: {dep.AddressDepartment} АДРЕС ГЛАВНОГО ДЕПАРТАМЕНТА: {dep.AddressMainDepartment}");

                if (coordinator.idRegion == null || coordinator.idRegion != dep.Id)
                    continue;

                SelectRegionField.SelectedItem = SelectRegionField.Items[SelectRegionField.Items.Count - 1];

                RegionResultText.Text = dep.AddressRegion;
                DepartmentResultText.Text = dep.AddressDepartment;
                MainDepartmentResultText.Text = dep.AddressMainDepartment;
            }

            NoFoundRegionText.Hide();

            if (coordinator.idRegion == null)
            {
                RegionResultText.Hide();
                RegionText.Hide();
                DepartmentResultText.Hide();
                DepartmentText.Hide();
                MainDepartmentResultText.Hide();
                MainDepartmentText.Hide();
                SelectRegionField.Show();
                SelectRegionText.Show();

                if (SelectRegionField.Items.Count > 0)
                    SelectRegionField.SelectedIndex = 0;
                else
                {
                    SelectRegionField.Hide();
                    NoFoundRegionText.Show();
                }
            }
            else
            {
                RegionResultText.Show();
                RegionText.Show();
                DepartmentResultText.Show();
                DepartmentText.Show();
                MainDepartmentResultText.Show();
                MainDepartmentText.Show();
                SelectRegionField.Hide();
                SelectRegionText.Hide();
            }

            if (SelectRegionField.Items.Count == 0)
            {
                SelectRegionField.Hide();
                NoFoundRegionText.Show();
            }
        }

        private void EnableHandledKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void SaveDepartmentButtonClick(object sender, EventArgs e)
        {
            if (NoFoundRegionText.Visible)
            {
                MessageBox.Show("Сохранение невозможно, нет региона");
                return;
            }

            if (!SelectRegionField.Visible)
            {
                MessageBox.Show("Невозможно сохранить, перед сохранением нажмите на редактирование!");
                return;
            }

            var context = new PSOConnect();
            var coordinator = context.coordinator.FirstOrDefault(coord => coord.idTeam == Login.CurrentUser.idTeam);
            var idRegion = int.Parse(SelectRegionField.SelectedItem.ToString().Split('-')[0]);
            var region = context.region.FirstOrDefault(regions => regions.idRegion == idRegion);
            region.coordinator.Add(coordinator);
            context.SaveChanges();
            ResetField();
            InitFields();
        }

        private void EditDepartmentButtonClick(object sender, EventArgs e)
        {
            if (NoFoundRegionText.Visible)
            {
                MessageBox.Show("Редактирование невозможно, нет региона");
                return;
            }

            RegionResultText.Hide();
            RegionText.Hide();
            DepartmentResultText.Hide();
            DepartmentText.Hide();
            MainDepartmentResultText.Hide();
            MainDepartmentText.Hide();
            SelectRegionField.Show();
            SelectRegionText.Show();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            ResetField();
            Hide();
            _coordinatorMenu.Show();
        }

        private void DepartmentFormClosed(object sender, FormClosedEventArgs e)
        {
            ResetField();
            _coordinatorMenu.Show();
        }

        private void ResetField()
        {
            RegionResultText.Text = "";
            DepartmentResultText.Text = "";
            MainDepartmentResultText.Text = "";

            SelectRegionField.Items.Clear();
        }
    }
}
