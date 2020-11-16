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

namespace WindowsFormsApp1.Coordinator.Task
{
    public partial class TaskMenu : Form
    {
        private readonly CoordinatorMenu _coordinatorMenu;

        public TaskMenu(CoordinatorMenu coordinatorMenu)
        {
            InitializeComponent();
            Show();

            _coordinatorMenu = coordinatorMenu;
        }

        private void MissingPeopleButtonClick(object sender, EventArgs e)
        { 
            Hide();
            new MissingPeople(this);
        }

        private void DisasterButtonClick(object sender, EventArgs e)
        {

            Hide();
            new Disaster(this);
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            Hide();
            _coordinatorMenu.Show();
        }

        private void TaskMenuFormClosed(object sender, FormClosedEventArgs e)
        {
            _coordinatorMenu.Show();
        }
    }
}
