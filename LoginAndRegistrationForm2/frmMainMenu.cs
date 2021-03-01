using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndRegistrationForm2
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu(string userName, decimal currentWeight, decimal targetWeight)
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void buttonTimetable_Click(object sender, EventArgs e)
        {
            FormTimetableMainMenu tm = new FormTimetableMainMenu();
            this.Hide();
            tm.ShowDialog();
            this.Show();
            //this.Close();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
