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
            this.Show();
        }
    }
}
