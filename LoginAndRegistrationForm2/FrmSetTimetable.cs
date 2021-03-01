using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndRegistrationForm2
{
    public partial class frmSetTimetable : Form
    {
        DateTime today = DateTime.Now;

        bool done;

        int n = 0;

        SqlConnection Conn = new SqlConnection();

        string DBConnectionString = "Data Source=DESKTOP-4PD7ECD;Initial Catalog=NEAAppDb;Integrated Security=True;Connect Timeout=30";

        int dayCount = 1;

        public frmSetTimetable()
        {
            InitializeComponent();
        }

        private void frmSetTimetable_Load(object sender, EventArgs e)
        {
            ComboBox[] dayTimetable = new ComboBox[] {comboBox630To730, comboBox730To830, comboBox830To930, comboBox930To1030, comboBox1030To1130, comboBox1130To1230,
                                         comboBox1230To1330, comboBox1330To1430, comboBox1430To1530, comboBox1530To1630, comboBox1630To1730, comboBox1730To1830,
                                          comboBox1830To1930, comboBox1930To2030  };


            for (int i = 0; i < dayTimetable.Length; i++)
            {
                dayTimetable[i].Items.Add("Breakfast");
                dayTimetable[i].Items.Add("Lunch");
                dayTimetable[i].Items.Add("Dinner");
                dayTimetable[i].Items.Add("School");
                dayTimetable[i].Items.Add("Work");
                dayTimetable[i].Items.Add("Exercise");
                dayTimetable[i].Items.Add("Free Time");
            }
            labelDays.Text = today.DayOfWeek.ToString();
            Conn.ConnectionString = DBConnectionString;
            Conn.Open();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

        }

        private void AccessUsername()
        {
            string[] times = new string[] {"6:30 - 7:30", "7:30 - 8:30", "8:30 - 9:30", "9:30 - 10:30", "10:30 - 11:30", "11:30 - 12:30", "12:30 - 13:30",
                                            "13:30 - 14:30", "14:30 - 15:30", "16:30 - 17:30", "17:30 - 18:30", "18:30 - 19:30", "19:30 - 20:30"};
            ComboBox[] dayTimetable = new ComboBox[] {comboBox630To730, comboBox730To830, comboBox830To930, comboBox930To1030, comboBox1030To1130, comboBox1130To1230,
                                         comboBox1230To1330, comboBox1330To1430, comboBox1430To1530, comboBox1530To1630, comboBox1630To1730, comboBox1730To1830,
                                          comboBox1830To1930, comboBox1930To2030  };

            TextBox[] timesOfDay = new TextBox[] {textBox630To730, textBox730To830, textBox830To930,textBox930To1030, textBox1030To1130, textBox1130To1230, textBox1230To1330,
                                                  textBox1330To1430, textBox1430To1530, textBox1530To1630, textBox1630To1730, textBox1730To1830, textBox1830To1930,
                                                  textBox1930To2030};
            string[] items = new string[] { "Breakfast", "Lunch", "Dinner", "School", "Work", "Exercise", "Free Time" };


            string sqlFormattedDate = today.Date.ToString("yyyy-MM-dd");

            DateTime currentDay = today.AddDays(n++);
            string sqlCurrentDay = currentDay.Date.ToString("yyyy-MM-dd");

            string unfilledTimes = "";
            for (int i = 0; i < dayTimetable.Length; i++)
            {

                if (dayTimetable[i].SelectedItem == null)
                {
                    unfilledTimes = unfilledTimes + " " + times[i];

                }
            }
            if (unfilledTimes != "")
            {
                MessageBox.Show("No items selected at " + unfilledTimes + " - Please ensure to click all the boxes and select an option");
                return;
            }


            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conn;
            for (int i = 0; i < dayTimetable.Length; i++)
            {
                cmd.CommandText = $"insert into timetable values('{UserDetails.userID}', '{labelDays.Text}' , '{timesOfDay[i].Text}','{dayTimetable[i].Text}')";
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            for (int i = 0; i < dayTimetable.Length - 1; i++)
            {
                if (dayTimetable[i].SelectedItem == null)
                {
                    MessageBox.Show("No item selected at " + times[i]);
                    return;
                }
            }
            MessageBox.Show("Success");

            labelDays.Text = today.AddDays(dayCount++).DayOfWeek.ToString();
            if (dayCount == 8)
            {
                Conn.Close();

                buttonNext.Enabled = false;

                done = true;

                FormTimetableMainMenu tm = new FormTimetableMainMenu();
                this.Hide();
                tm.ShowDialog();
                this.Show();
                this.Close();


                //(this.Owner as FormTimetableMainMenu).
            }


        }
    }
}
