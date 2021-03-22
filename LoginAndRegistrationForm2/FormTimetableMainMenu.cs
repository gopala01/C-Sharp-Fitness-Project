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
    public partial class FormTimetableMainMenu : Form
    {
        public FormTimetableMainMenu()
        {
            InitializeComponent();
        }

        private void buttonSetTimetable_Click(object sender, EventArgs e)
        {
            frmSetTimetable st = new frmSetTimetable();
            this.Hide();
            st.ShowDialog();
            this.Close();
        }

        private void FormTimetableMainMenu_Load(object sender, EventArgs e)
        {
            //if (UserDetails.doneSetTimetable == true)
            //{
            //    buttonSetTimetable.Enabled = false;
            //    buttonDisplayTimetable.Enabled = true;
            //}
            //else
            //{
            //    buttonSetTimetable.Enabled = true;
            //    buttonDisplayTimetable.Enabled = false;
            //}
        }

        private void buttonDisplayTimetable_Click(object sender, EventArgs e)
        {
            FrmDisplayUpdateTimetable dt = new FrmDisplayUpdateTimetable();
            this.Hide();
            dt.ShowDialog();
            this.Close();
        }
    }
}
