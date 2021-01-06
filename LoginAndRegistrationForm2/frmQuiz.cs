using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;

namespace LoginAndRegistrationForm2
{
    public partial class frmQuiz : Form
    {
        string userName;
        bool userExists;
        DateTime dob ;
        string gender = "";
        string diet = "";
        decimal currentWeight ;
        decimal targetWeight ;
        decimal change = 0;
        string exerciseType = "";
        string e1 = "Press Ups";
        string e2 = "Sit Ups";
        string e3 = "Mountain Climbers";
        string e4 = "Squats";
        
        SqlConnection Conn = new SqlConnection();
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

        public frmQuiz(string userName, bool userExists)
        {
            this.userName = userName;
            this.userExists = userExists;
            InitializeComponent();
        }

        private void labelUsernameL_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveDetails(string userName, DateTime dob, string gender, 
        decimal CurrentWeight, decimal TargetWeight, string dietType)
        {
            string cmdString = "";
            string sqlformatdate = dob.ToString("yyyy-MM-dd");
            //MessageBox.Show(dob.ToString());
            if (userExists)
            {
                //Amends data if user already exists
                cmdString = $"update Dbo.User_details set datecreated = GetDate()," +
                    $"DateOfBirth ='{sqlformatdate}', gender = '{gender}', " +
                    $"currentweight = {currentWeight}, targetWeight = {targetWeight}, " +
                    $"dietType = '{diet}'" +
                    $" where username =  '{userName}'";
                

            }
            else //adds user data if user doesn't exist
            {
                cmdString = $"INSERT INTO Dbo.User_details Values(GetDate(),'{userName}', '{dob}', '{gender}', " +
                    $"{currentWeight}, {targetWeight}, '{diet}')";

                
            }

            //Debug.WriteLine(cmdString);
            //MessageBox.Show(cmdString);
            
            runNonQuerySQL(cmdString);
            //


        }

        private void saveUserDetails_Click(object sender, EventArgs e)
        {
            targetWeight = numTargetWeight.Value;
            currentWeight = numCurrentWeight.Value;
            dob = dateTimePicker1.Value.Date;
            MessageBox.Show("check 1");
        
            if (radioMale.Checked)
            {
                gender = "M";
            }
            else if (radioFemale.Checked)
            {
                gender = "F";
            }
            else if(radioOther.Checked)
            {
                gender = "O";
            }

            if (radioVeg.Checked)
            {
                diet = "Vegiterian";
            }
            else if (radioNonVeg.Checked)
            {
                diet = "Non-Vegiterian";
            }
            else if (radioVegan.Checked)
            {
                diet = "Vegan";
            }
            //change = currentWeight - targetWeight;
            //if (change > 0)
            //{
            //    exerciseType = "Weight Loss";
            //}
            //else if (change < 0)
            //{
            //    exerciseType = "Weight Gain";
            //}
            if (targetWeight >= currentWeight)
            {
                MessageBox.Show("Target weight can not be less than current weight. Try again ");
            }
            else
            {
                saveDetails(userName, dob, gender, currentWeight, targetWeight, diet);
         
                MessageBox.Show($"User details for {userName} saved");
                this.Close();
            }

        }

        private void fetchUserDetails()
        {
            String sqlText = $"select dateofbirth, gender, CurrentWeight, TargetWeight, DietType " +
                             $"from user_details " +
                             $"where username = '{userName}' ";
            SqlDataReader dataReader = runSQLSelect(sqlText);
            
            while (dataReader.Read())
            {
                
                dateTimePicker1.Value = dataReader.GetDateTime(0);
                switch (dataReader.GetString(1))
                {
                    case "F":
                        radioFemale.Checked = true;
                        break;
                    case "M":
                        radioMale.Checked = true;
                        break;
                    default:
                        radioOther.Checked = true;
                        break;
                }
                numCurrentWeight.Value = dataReader.GetDecimal(2);
                numTargetWeight.Value = dataReader.GetDecimal(3);
                switch (dataReader.GetString(4))
                {
                    case "Vegiterian":
                        radioVeg.Checked = true;
                        break;
                    case "Non-Vegiterian":
                        radioNonVeg.Checked = true;
                        break;
                    default:
                        radioVegan.Checked = true;
                        break;
                }

                //MessageBox.Show($"User count is {userCount} and result is {result}");
            }
            dataReader.Close();
        }
        private void frmQuiz_Load(object sender, EventArgs e)
        {
            String ConnectinString = "Data Source=DESKTOP-4PD7ECD;Initial Catalog=NEAAppDb;Integrated Security=True;Connect Timeout=30";
            Conn.ConnectionString = ConnectinString;
            Conn.Open();
            if (userExists)
            {
                // query and set below values
                /*
                 *  DateTime dob = dateTimePicker1.Value.Date;
            string gender = "";
            string diet = "";
            decimal currentWeight = numCurrentWeight.Value;
            decimal targetWeight = numTargetWeight.Value;
                 * 
                 */
                fetchUserDetails();
            }
        }

        private void numCurrentWeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
