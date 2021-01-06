using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginAndRegistrationForm2
{
    public partial class UserActivity : Form
    {

        string userName;
        bool userDetailsExists;
        SqlConnection Conn = new SqlConnection();

        //Assures each of these attributes can be used

        private SqlDataReader runSQLSelect(String cmdString)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dataReader;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = cmdString;
            cmd.Connection = Conn;

            dataReader = cmd.ExecuteReader();

            return dataReader;

        }


        private void runNonQuerySQL(String cmdString)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = cmdString;
            cmd.Connection = Conn;

            cmd.ExecuteNonQuery();

        }
        public UserActivity(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private bool checkUserDetails(string userName)
        {
            String sqlText = $"select count(*) from dbo.user_details ud where username = '{userName}'";
            SqlDataReader dataReader = runSQLSelect(sqlText);
            bool result = false;
            while (dataReader.Read())
            {
                int userCount = dataReader.GetInt32(0);
                result = (userCount == 1) ? true : false;

                //MessageBox.Show($"User count is {userCount} and result is {result}");
            }
            dataReader.Close();
            return result;
        }

        private void UserActivity_Load(object sender, EventArgs e)
        {
            //SqlConnection Conn = new SqlConnection();
            String ConnectinString = "Data Source=DESKTOP-4PD7ECD;Initial Catalog=NEAAppDb;Integrated Security=True;Connect Timeout=30";
            Conn.ConnectionString = ConnectinString;
            Conn.Open();
            // check if user details exists
            userDetailsExists = checkUserDetails(userName);
            // if not disable main Menu button.
            if (!userDetailsExists)
            {
                mainMenu.Enabled = false;
            }
        }

        private void UserActivity_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void Quiz_Click(object sender, EventArgs e)
        {
            Form qz = new frmQuiz(userName, userDetailsExists);
            //this.Hide();
            qz.ShowDialog();
            if (! mainMenu.Enabled)
            {
                bool userDetailsExists = checkUserDetails(userName);
                // if not disable main Menu button.
                if (userDetailsExists)
                {
                    mainMenu.Enabled = true;
                  
                }
           
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
