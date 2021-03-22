using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginAndRegistrationForm2
{
    public partial class UserActivity : Form
    {

        //string userName;
        decimal currentWeight;
        decimal targetWeight;
        bool userDetailsExists;
        decimal change;
        string diet;
        string[] breakfastOptions;
        string[] lunchOptions;
        string[] dinnerOptions;
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
        public UserActivity()
        {
            //this.userName = userName;
            //this.currentWeight = currentWeight;
            //this.targetWeight = targetWeight;
            //this.change = change;
            //this.diet = diet;
            //this.breakfastOptions = breakfastOptions;
            //this.lunchOptions = lunchOptions;
            //this.dinnerOptions = dinnerOptions;
            InitializeComponent();
        }

        

        private bool checkUserDetails(string userNameCUD)
        {
            String sqlText = $"select count(*) from dbo.user_details ud where username = '{userNameCUD}'";
            SqlDataReader dataReader = runSQLSelect(sqlText);
            bool result = false;
            while (dataReader.Read())

            {
                int userCount = dataReader.GetInt32(0);
                //result = (userCount == 1) ? true : false;
                if (userCount == 1 || userCount > 1)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

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
            userDetailsExists = checkUserDetails(UserDetails.userName);
            // if not disable main Menu button.
            if (!userDetailsExists)
            {
                mainMenu.Enabled = false;
            }
            else if (userDetailsExists == true)
            {
                mainMenu.Enabled = true;
                Quiz.Enabled = false;
            }
        }

        private void UserActivity_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void Quiz_Click(object sender, EventArgs e)
        {
            
            
            
            Form qz = new frmQuiz();
            //this.Hide();
            qz.ShowDialog();
            if (! mainMenu.Enabled)
            {
                bool userDetailsExists = checkUserDetails(UserDetails.userName);
                // if not disable main Menu button.
                if (userDetailsExists)
                {
                    mainMenu.Enabled = true;
                    Quiz.Enabled = false;
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

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu mm = new frmMainMenu();
            this.Hide();
            mm.ShowDialog();
            this.Close();
        }
    }
}
