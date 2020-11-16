using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Admin.Departamet
{
    public partial class Department : Form
    {
        private Action<string> _updatedListInfo;
        private Action _addedListInfo;
        private Action _deletedElementInListInfo;

        private DepatmentMenu _departmentMenu;

        private int _idRegion;

        public Department(DepatmentMenu departmentMenu, Action addedListInfo = null, Action deletedElementInListInfo = null, Action<string> updatedListInfo = null, region region = null)
        {
            InitializeComponent();

            Show();

            _departmentMenu = departmentMenu;
            _idRegion = region != null ? region.idRegion : 0;
            _addedListInfo = addedListInfo;
            _updatedListInfo = updatedListInfo;
            _deletedElementInListInfo = deletedElementInListInfo;

            InitFields(region);
        }

        private void InitFields(region region)
        {
            if (region == null)
            {
                AddDepartmentButton.Show();
                EditButton.Hide();
                return;
            }

            AddDepartmentButton.Hide();
            EditButton.Show();

            var context = new PSOConnect();
            var department = context.department.FirstOrDefault(departments => departments.idDepartment == region.idDepartment);
            var mainDepartment = context.mainDepartment.FirstOrDefault(mainDepartments => mainDepartments.idMainDepartment == department.idMainDepartment);

            RegionField.Text = region.address;
            DepartmentField.Text = department.address;
            MainDepartmentField.Text = mainDepartment.address;
        }

        private void RussianKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ',' || e.KeyChar == ' ' || e.KeyChar == '-' || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= '0' && e.KeyChar <= '9') || (char.IsControl(e.KeyChar)) ? false : true;
        }

        private void EditDepartmentButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RegionField.Text))
            {
                MessageBox.Show("Введите регион!");
                return;
            }

            if (string.IsNullOrEmpty(DepartmentField.Text))
            {
                MessageBox.Show("Введите департамент!");
                return;
            }

            if (string.IsNullOrEmpty(MainDepartmentField.Text))
            {
                MessageBox.Show("Введите главный департамент!");
                return;
            }

            EditDepartement();

            MessageBox.Show("Информация о департаменте успешно отредактирована!");

            Hide();
            ResetFields();
            _departmentMenu.Show();
        }

        private void EditDepartement()
        {
            if (CheckExist())
                return;

            var context = new PSOConnect();
            var region = context.region.FirstOrDefault(regions => regions.idRegion == _idRegion);
            region.address = RegionField.Text;

            var department = context.department.FirstOrDefault(departments => departments.idDepartment == region.idDepartment);

            var checkExistDepartment = context.department.FirstOrDefault(departments => departments.address.Equals(DepartmentField.Text));
            department currentDepartment = null;

            if (department.region.Count == 1)
            {
                currentDepartment = department;
                department.address = DepartmentField.Text;
            }
            else if (checkExistDepartment != null)
            {
                currentDepartment = checkExistDepartment;
                checkExistDepartment.region.Add(region);
            }
            else
            {
                currentDepartment = new department
                {
                    idDepartment = context.department.Count() > 0 ? context.department.Max(departments => departments.idDepartment) + 1 : 1,
                    address = DepartmentField.Text
                };

                currentDepartment.region.Add(region);
                context.department.Add(currentDepartment);
            }


            var mainDepartment = context.mainDepartment.FirstOrDefault(mainDepartments => mainDepartments.idMainDepartment == department.idMainDepartment);

            var checkExistMainDepartment = context.mainDepartment.FirstOrDefault(mainDepartments => mainDepartments.address.Equals(MainDepartmentField.Text));
            mainDepartment currentMainDepartment = null;

            if (mainDepartment.department.Count == 1)
            {
                currentMainDepartment = mainDepartment;
                mainDepartment.address = MainDepartmentField.Text;
            }
            else if (checkExistMainDepartment != null)
            {
                currentMainDepartment = checkExistMainDepartment;
                checkExistMainDepartment.department.Add(currentDepartment);
            }
            else
            {
                currentMainDepartment = new mainDepartment
                {
                    idMainDepartment = context.mainDepartment.Count() > 0 ? context.mainDepartment.Max(mainDepartments => mainDepartments.idMainDepartment) + 1 : 1,
                    address = MainDepartmentField.Text
                };

                currentMainDepartment.department.Add(currentDepartment);
                context.mainDepartment.Add(currentMainDepartment);
            }

            _updatedListInfo?.Invoke($"{region.idRegion}-АДРЕС РЕГИОНА: {region.address} АДРЕС ДЕПАРТАМЕНТА: {currentDepartment.address} АДРЕС ГЛАВНОГО ДЕПАРТАМЕНТА: {currentMainDepartment.address}");
            context.SaveChanges();
        }

        private bool CheckExist()
        {
            var context = new PSOConnect();
            var checkExist = false;
            var department = from region in context.region
                             join departments in context.department on region.idDepartment equals departments.idDepartment
                             join mainDepartment in context.mainDepartment on departments.idMainDepartment equals mainDepartment.idMainDepartment
                             select new
                             {
                                 AddressRegion = region.address,
                                 AddressDepartment = departments.address,
                                 AddressMainDepartment = mainDepartment.address
                             };

            foreach(var depart in department)
            {
                if (depart.AddressRegion.Equals(RegionField.Text) && depart.AddressDepartment.Equals(DepartmentField.Text) && depart.AddressMainDepartment.Equals(MainDepartmentField.Text))
                {
                    checkExist = true;
                    break;
                }
            }

            if (checkExist)
            {
                var region = context.region.FirstOrDefault(regions => regions.idRegion == _idRegion);
                var dep = context.department.FirstOrDefault(departments => departments.idDepartment == region.idDepartment);
                var mainDepartment = context.mainDepartment.FirstOrDefault(mainDepartments => mainDepartments.idMainDepartment == dep.idMainDepartment);
                context.region.Remove(region);
                
                if(dep.region.Count<1)
                context.department.Remove(dep);

                if(mainDepartment.department.Count<1)
                context.mainDepartment.Remove(mainDepartment);

                context.SaveChanges();
                _deletedElementInListInfo?.Invoke();
                return true;
            }

            return false;
        }

        private void AddDepartmentButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RegionField.Text))
            {
                MessageBox.Show("Введите регион!");
                return;
            }

            if (string.IsNullOrEmpty(DepartmentField.Text))
            {
                MessageBox.Show("Введите департамент!");
                return;
            }

            if (string.IsNullOrEmpty(MainDepartmentField.Text))
            {
                MessageBox.Show("Введите главный департамент!");
                return;
            }

            AddDepartment();

            _addedListInfo?.Invoke();
            MessageBox.Show("Информация о департаменте успешно добавлена!");

            Hide();
            ResetFields();
            _departmentMenu.Show();
        }

        private void AddDepartment()
        {
            var context = new PSOConnect();
            var mainDepartment = context.mainDepartment.FirstOrDefault(mainDepartments => mainDepartments.address.Equals(MainDepartmentField.Text));
            mainDepartment currentMainDepartment = null;

            if (mainDepartment == null)
            {
                currentMainDepartment = new mainDepartment
                {
                    idMainDepartment = context.mainDepartment.Count() > 0 ? context.mainDepartment.Max(mainDepartments => mainDepartments.idMainDepartment) + 1 : 1,
                    address = MainDepartmentField.Text
                };

                context.mainDepartment.Add(currentMainDepartment);
            }

            var idMainDepartment = mainDepartment == null ? currentMainDepartment.idMainDepartment : mainDepartment.idMainDepartment;
            var department = context.department.FirstOrDefault(departments => departments.address.Equals(DepartmentField.Text) && departments.idMainDepartment == idMainDepartment);
            department currentDepartment = null;

            if (department == null)
            {
                currentDepartment = new department
                {
                    idDepartment = context.department.Count() > 0 ? context.department.Max(departments => departments.idDepartment) + 1 : 1,
                    address = DepartmentField.Text,
                };

                context.department.Add(currentDepartment);
                var mainDep = mainDepartment == null ? currentMainDepartment : mainDepartment;
                mainDep.department.Add(currentDepartment);
            }

            var idDepartment = department == null ? currentDepartment.idDepartment : department.idDepartment;
            var region = context.region.FirstOrDefault(regions => regions.address.Equals(RegionField.Text) && regions.idDepartment == idDepartment);
            region currentRegion = null;

            if(region == null)
            {
                currentRegion = new region
                {
                    idRegion = context.region.Count() > 0 ? context.region.Max(regions => regions.idRegion) + 1 : 1,
                    address = RegionField.Text
                };

                context.region.Add(currentRegion);
                var depart = department == null ? currentDepartment : department;
                depart.region.Add(currentRegion);
            }

            context.SaveChanges();
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Hide();
            ResetFields();
            _departmentMenu.Show();
        }

        private void DepartmentFormClosed(object sender, FormClosedEventArgs e)
        {
            ResetFields();
            _departmentMenu.Show();
        }

        private void ResetFields()
        {
            RegionField.Text = "";
            DepartmentField.Text = "";
            MainDepartmentField.Text = "";
        }
    }
}
