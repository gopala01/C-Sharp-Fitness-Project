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
    public partial class FrmDisplayUpdateTimetable : Form
    {
        DateTime activityDate;
        DataTable dt = new DataTable();

        int nextDayCount = 0;

        SqlConnection Conn = new SqlConnection();
        string DBConnectionString = "Data Source=DESKTOP-4PD7ECD;Initial Catalog=NEAAppDb;Integrated Security=True;Connect Timeout=30";
        string selectStatement = $"SELECT ID, userID, setDate, DATENAME(weekday, setDate) as Day ,setTime as Times, activity FROM activity_timetable where userID = '{UserDetails.userID}'";
        
        private SqlDataReader runSQLSelect(String cmdString)//Recieves
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dataReader;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = cmdString;
            cmd.Connection = Conn;
            dataReader = cmd.ExecuteReader(); // executing the sql command on the database.
            return dataReader;
        }
        public FrmDisplayUpdateTimetable()
        {
            InitializeComponent();
        }

        private void FrmDisplayUpdateTimetable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEAAppDbDataSet.activity_timetable' table. You can move, or remove it, as needed.
            this.activity_timetableTableAdapter.Fill(this.nEAAppDbDataSet.activity_timetable);



            Conn.ConnectionString = DBConnectionString;
            Conn.Open();

            dt.Load(runSQLSelect(selectStatement));

            DateTime minDate = Convert.ToDateTime(dt.Compute("min(setDate)", ""));

            string expression = "setDate = '" + minDate.ToString("dd/MM/yyyy") + "'";


            DataTable dw = dt.Select(expression).CopyToDataTable();
            dataGridViewDisplayTimetable.DataSource = dw;
            //dataGridViewDisplayTimetable.Refresh();
            //
            //dataGridViewDisplayTimetable.DataSource = dt;
            


            buttonPrevious.Enabled = false;

            panelUpdateTimetable.Visible = false;

            ComboBox[] dayTimetable = new ComboBox[] { comboBox630To730, comboBox730To830,comboBox830To930, comboBox930To1030, comboBox1030To1130, comboBox1130To1230, comboBox1230To1330, comboBox1330To1430, comboBox1430To1530, comboBox1530To1630, comboBox1630To1730, comboBox1730To1830, comboBox1830To1930 };
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
            //labelDaysOfTheWeek.Text = today.DayOfWeek.ToString();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            DateTime dn = DateTime.Today;

            DateTime minDate = Convert.ToDateTime(dt.Compute("min(setDate)", ""));
            DateTime nextDay = minDate.AddDays(nextDayCount++);
            activityDate = nextDay;
            DateTime maxDate = Convert.ToDateTime(dt.Compute("max(setDate)", ""));
            string expression = "setDate = '" + activityDate.ToString("dd/MM/yyyy") + "'";
            //MessageBox.Show(expression);


            DataTable dw = dt.Select(expression).CopyToDataTable();
            dataGridViewDisplayTimetable.DataSource = dw;
            dataGridViewDisplayTimetable.Refresh();

            if (nextDayCount > 0)
            {
                buttonPrevious.Enabled = true;
            }
            if (nextDayCount == 7)
            {
                buttonNext.Enabled = false;
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            DateTime minDate = Convert.ToDateTime(dt.Compute("min(setDate)", ""));
            DateTime prevDay = minDate.AddDays(--nextDayCount);
            DateTime maxDate = Convert.ToDateTime(dt.Compute("max(setDate)", ""));
           // activityDate = prevDay;

            string expression = "setDate = '" + prevDay.ToString("dd/MM/yyyy") + "'";

            //MessageBox.Show(expression);


            dataGridViewDisplayTimetable.DataSource = getFilteredDatatable(expression);
            dataGridViewDisplayTimetable.Refresh();
            if (nextDayCount == 0)
            {
                buttonPrevious.Enabled = false;
            }
            if (nextDayCount < 8)
            {
                buttonNext.Enabled = true;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string expression = "setDate = '" + activityDate.ToString("dd/MM/yyyy") + "'";

            int comboBoxIndex = 0;
            //  string unfilledTimes = "";
            panelUpdateTimetable.Visible = true;
            string[] times = new string[] { "6:30 - 7:30", "7:30 - 8:30", "8:30 - 9:30", "9:30 - 10:30", "10:30 - 11:30", "11:30 - 12:30", "12:30 - 13:30",
                                            "13:30 - 14:30", "14:30 - 15:30", "15:30 - 16:30", "16:30 - 17:30", "17:30 - 18:30", "18:30 - 19:30", "19:30 - 20:30"};
            ComboBox[] dayTimetable = new ComboBox[] { comboBox630To730, comboBox730To830,  comboBox830To930, comboBox930To1030, comboBox1030To1130, comboBox1130To1230, comboBox1230To1330, comboBox1330To1430, comboBox1430To1530, comboBox1530To1630, comboBox1630To1730, comboBox1730To1830, comboBox1830To1930, comboBox1930To2030 };



            foreach (DataRow row in getFilteredDatatable(expression).Rows)
            {
                dayTimetable[comboBoxIndex].Text = row["activity"].ToString();
                comboBoxIndex++;
            }
        }

        private DataTable getFilteredDatatable(string expression)
        {


            //MessageBox.Show(expression);

            return dt.Select(expression).CopyToDataTable();
        }

        private void buttonSaveUpdate_Click(object sender, EventArgs e)
        {
            string[] times = new string[] { "6:30 - 7:30", "7:30 - 8:30", "8:30 - 9:30", "9:30 - 10:30", "10:30 - 11:30", "11:30 - 12:30", "12:30 - 13:30",
                                            "13:30 - 14:30", "14:30 - 15:30", "15:30 - 16:30", "16:30 - 17:30", "17:30 - 18:30", "18:30 - 19:30", "19:30 - 20:30"};

            string expression = "setDate = '" + activityDate.ToString("dd/MM/yyyy") + "'";

            string ID;

            string activity;
            int comboBoxIndex = 0;
            ComboBox[] dayTimetable = new ComboBox[] { comboBox630To730, comboBox730To830, comboBox830To930, comboBox930To1030, comboBox1030To1130, comboBox1130To1230, comboBox1230To1330, comboBox1330To1430, comboBox1430To1530, comboBox1530To1630, comboBox1630To1730, comboBox1730To1830, comboBox1830To1930, comboBox1930To2030 };
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conn;

            foreach (DataRow row in getFilteredDatatable(expression).Rows)
            {
                ID = row["ID"].ToString();
                activity = dayTimetable[comboBoxIndex].Text;
                //string sqlIDSelect = $"Select ID where Day = 'DATENAME(weekday, setDate)' and setTime = {times[i]}";

                cmd.CommandText = $"update activity_timetable set activity = '{activity}' where ID = {ID}";
                comboBoxIndex++;
                try
                {
                    cmd.ExecuteNonQuery();

                    panelUpdateTimetable.Visible = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            MessageBox.Show("Details updated");
        }

        private void buttonCancelUpdate_Click(object sender, EventArgs e)
        {
            panelUpdateTimetable.Visible = false;

        }

        private void buttonDisplayUpdateTimetableBack_Click(object sender, EventArgs e)
        {
            FormTimetableMainMenu tmm = new FormTimetableMainMenu();
            this.Hide();
            tmm.ShowDialog();
            this.Close();
        }

        private void dataGridViewDisplayTimetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
