using PSO_DB.Admin;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1.Admin.Departamet
{
    public partial class DepatmentMenu : Form
    {
        private AdminMenu _adminMenuForm;

        public DepatmentMenu(AdminMenu adminMenuForm)
        {
            InitializeComponent();

            Show();

            _adminMenuForm = adminMenuForm;

            InitListInfo();
        }

        private void InitListInfo()
        {
            var context = new PSOConnect();

            var department = from region in context.region
                             join departments in context.department on region.idDepartment equals departments.idDepartment
                             join mainDepartment in context.mainDepartment on departments.idMainDepartment equals mainDepartment.idMainDepartment
                             select new
                             {
                                 Id = region.idRegion,
                                 AddressRegion = region.address,
                                 AddressDepartment = departments.address,
                                 AddressMainDepartment = mainDepartment.address
                             };

            foreach (var dep in department)
                ListInfo.Items.Add($"{dep.Id}-АДРЕС РЕГИОНА: {dep.AddressRegion} АДРЕС ДЕПАРТАМЕНТА: {dep.AddressDepartment} АДРЕС ГЛАВНОГО ДЕПАРТАМЕНТА: {dep.AddressMainDepartment}");
        }

        private void AddDepartmentButtonClick(object sender, EventArgs e)
        {
            Hide();
            new Department(this, () =>
            {
                ListInfo.Clear();
                InitListInfo();
            });

        }

        private void EditDepartmentButtonClick(object sender, EventArgs e)
        {
            if (ListInfo.Items.Count == 0)
            {
                MessageBox.Show("Список департаментов пуст!");
                return;
            }

            if (ListInfo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного элемента! Пожалуйста, выберите департамент");
                return;
            }

            if (ListInfo.SelectedItems.Count > 1)
            {
                MessageBox.Show("Выбрано более 1 элемента, пожалуйста, оставьте только 1 элемент!");
                return;
            }

            var context = new PSOConnect();
            var idRegion = int.Parse(ListInfo.SelectedItems[0].ToString().Split('-')[0].Split('{')[1]);
            var region = context.region.FirstOrDefault(regions => regions.idRegion == idRegion);

            Hide();
            new Department(this, null, () => ListInfo.Items.Remove(ListInfo.SelectedItems[0]), EditListInfo, region);
        }

        private void EditListInfo(string listInfo)
        {
            for (var i = 0; i < ListInfo.Items.Count; i++)
            {
                if (ListInfo.Items[i].Equals(ListInfo.SelectedItems[0]))
                    ListInfo.Items[i].Text = listInfo;
            }
        }

        private void DeleteDepartmentButtonClick(object sender, EventArgs e)
        {
            if (ListInfo.Items.Count == 0)
            {
                MessageBox.Show("Список пропавших людей пуст!");
                return;
            }

            if (ListInfo.SelectedItems.Count == 0)
            {
                MessageBox.Show("Не выбрано ни одного элемента! Пожалуйста, выберите пропавшего человека");
                return;
            }

            var context = new PSOConnect();
            var count = ListInfo.SelectedItems.Count;

            for (var i = 0; i < count; i++)
            {
                var idRegion = int.Parse(ListInfo.SelectedItems[i].ToString().Split('-')[0].Split('{')[1]);
                var region = context.region.FirstOrDefault(regions => regions.idRegion == idRegion);
                var department = context.department.FirstOrDefault(departmanets => departmanets.idDepartment == region.idDepartment);
                var mainDepartment = context.mainDepartment.FirstOrDefault(mainDepartments => mainDepartments.idMainDepartment == department.idMainDepartment);

                foreach(var coordinator in context.coordinator)
                {
                    if (coordinator.idRegion == idRegion)
                        coordinator.idRegion = null;
                }

                ListInfo.Items.Remove(ListInfo.SelectedItems[i]);
                context.region.Remove(region);

                if (department.region.Count < 1)
                    context.department.Remove(department);

                if (mainDepartment.department.Count < 1)
                    context.mainDepartment.Remove(mainDepartment);
            }

            context.SaveChanges();

            var message = count > 1 ? "Департамены успешно удалены" : "Департамент успешно удалён";
            MessageBox.Show(message);
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Hide();
            _adminMenuForm.Show();
        }

        private void DepartmentMenuFormClosed(object sender, FormClosedEventArgs e)
        {
            _adminMenuForm.Show();
        }
    }
}
