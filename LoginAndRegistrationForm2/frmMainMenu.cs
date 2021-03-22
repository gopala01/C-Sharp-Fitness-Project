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
        DateTime now = DateTime.Now;
        DateTime today = DateTime.Today;
        string[] week = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        public frmMainMenu()
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
            this.Close();
            //this.Close();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            frmProgress p = new frmProgress();
            this.Hide();
            p.ShowDialog();
            p.Close();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            for (int day = 0; day < week.Length; day++)
            {
                if (today.DayOfWeek.ToString() == week[day])
                {
                    //buttonDotD.Text = ("Breakfast for today - " + UserDetails.breakfastOptions[day] + "\r\nLunch for today - " + UserDetails.lunchOptions[day] + "\r\nDinner for today - " + UserDetails.dinnerOptions[day]);
                }
            }

            buttonEotD.Text = ("Press ups = " + (Decimal.Multiply(UserDetails.change, 2)).ToString() + "\r\nSit ups = " + (Decimal.Multiply(UserDetails.change, 3)).ToString() + "\r\nMountain Climbers - " + (UserDetails.change).ToString() + "\r\nSquats - " + (Decimal.Multiply(UserDetails.change, 3).ToString()));
        }

        private void buttonDotD_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonDoD_Click(object sender, EventArgs e)
        {
            //buttonDotD.Text = ("Breakfast for today - " + UserDetails.breakfastOptions[day] + "\r\nLunch for today - " + UserDetails.lunchOptions[day] + "\r\nDinner for today - " + UserDetails.dinnerOptions[day]);
        }

        private void labelEotD_Click(object sender, EventArgs e)
        {

        }
    }
}
