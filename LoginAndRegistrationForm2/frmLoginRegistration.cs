using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace LoginAndRegistrationForm2
{
    public partial class frmLogin : Form
    {
        string firstName;
        string lastName;
        public string userName;
        string password;
        string confirmPassword;
        SqlConnection Conn = new SqlConnection(); //


        //Assures each of these attributes can be used

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

        private void runNonQuerySQL(String cmdString)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = cmdString;
            cmd.Connection = Conn;
            cmd.ExecuteNonQuery();

        }

        public frmLogin()
        {
            InitializeComponent();
        }



        private void goToRegister_Click(object sender, EventArgs e)
        {
            panelRegister.BringToFront();
        }

        

        private void goToLogin_Click(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
        }

        private bool validateName(string name)
        {

            //return (!Regex.IsMatch(name, @"^[a-zA-Z]+$")) ? false : true;
            return Regex.IsMatch(name, @"^[a-zA-Z]+$") ;


        }

        private bool validateUserName(string name)
        {

            return Regex.IsMatch(name, @"^[a-zA-Z0-9]+$") ;

        }

        private bool checkUserExists(string userName)
        {
            //String sqlText = $"select count(*) from dbo.users where username = '{userName}'"; //Select count wil give the number of rows in user table with the given username. This will be sent to the database from the application
            String sqlText = $"select ID from dbo.users where username = '{UserDetails.userName}'"; //Select count wil give the number of rows in user table with the given username. This will be sent to the database from the application
            SqlDataReader dataReader = runSQLSelect(sqlText); // runSQLSelect method gives the results of the given query Datareader holds the number of rows returned when searching for the usernmae to indicate whether the use
            //02/03/2021 - Last change


            bool result = false;
            while (dataReader.Read()) //Iterates on the result set
            {
               // int userCount = dataReader.GetInt32(0);
                int userID = dataReader.GetInt32(0);
                //result = (userCount == 0) ? false : true;
                result = true;

                UserDetails.userID = userID;
                //MessageBox.Show($"User count is {userCount} and result is {result}");
            }
            
            dataReader.Close();
            return result;
        }
        // This method takes the username and password.
        // Find the count(*) from the users table for matching username and password.
        private bool validateUser(string userName, string password)
        {
            
            String sqlText = $"select count(*) from dbo.users where username = '{userName}' and password = '{password}' COLLATE SQL_Latin1_General_CP1_CS_AS";
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
        private void registerUser(string firstName, string lastName, string userName, string password)
        {
            string cmdString = $"INSERT INTO Dbo.Users Values(GetDate(),'{firstName}', '{lastName}', '{userName}', '{password}')";
            runNonQuerySQL(cmdString);
            MessageBox.Show("Added user details to database");
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            userName = textBoxUsernameR.Text.Trim();
            firstName = textBoxFirstName.Text.Trim();
            lastName = textBoxLastName.Text.Trim();
            password = textBoxPasswordR.Text.Trim();
            confirmPassword = textBoxConfirmPassword.Text.Trim();
            //Converts the text in the textbox into the corresponding variables

            //Check that all mandotary fields are supplied.
            if (firstName.Length == 0 || lastName.Length == 0 || userName.Length == 0 || password.Length == 0 || confirmPassword.Length == 0 )
            {
                MessageBox.Show("Missing mandatory files");
                //textBoxFirstName.Text = "*";
                //labelFirstName.Text += "*";
            }
            else if (!validateName(firstName))
            {
                MessageBox.Show("Invalid First name. Correct it");
                //textBoxFirstName.Text = "";
            }
            else if (!validateName(lastName))
            {
                MessageBox.Show("Invalid Last name. Correct it");
            }
            else if (userName.Length > 50)
            {
                MessageBox.Show("User Name longer than 50 characters. Correct it");
            }
            else if(password.Length < 6 || password.Length > 20)
            {
                MessageBox.Show("Password should be between 6 and 20 characters. Correct it");
            }
            else if (confirmPassword != password)
            {
                MessageBox.Show($"Password does not match. Try again");
                textBoxConfirmPassword.Text = "";

            }else if (checkUserExists(userName))
            {
                MessageBox.Show($"Username {userName} already exists. Choose a different username / try to login");
            }
            else
            {
                registerUser(firstName, lastName, userName, password);
            }

            
            //MessageBox.Show($"UserName: {userName} \n Password : {password}\n First firstName: {firstName}\n Last firstName : {lastName}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SqlConnection Conn = new SqlConnection();
            String ConnectinString = "Data Source=DESKTOP-4PD7ECD;Initial Catalog=NEAAppDb;Integrated Security=True;Connect Timeout=30";
            Conn.ConnectionString = ConnectinString;
            Conn.Open();

        }

        private void panelRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            userName = textBoxUsernameL.Text.Trim();
            password = textBoxPasswordL.Text.Trim();
            UserDetails.userName = userName;
            if ( userName.Length == 0 || password.Length == 0 )
            {
                MessageBox.Show("Missing mandatory fileds");
                
            }

            // Check if user exists

            else if (! checkUserExists(userName))
            {
                MessageBox.Show($"Username {userName} does not exist. Correct user name and try again");
            }
            else if (!  validateUser(userName, password))
            {
                MessageBox.Show($"Incorrect password {password}, please insert the correct password and try again");
            }

            // User activity after login
            else 
            {
                MessageBox.Show("UserID = " + UserDetails.userID.ToString());
                UserActivity ua = new UserActivity();
                this.Hide();


                ua.ShowDialog();
                textBoxUsernameL.Text = "";
                textBoxPasswordL.Text = "";
                this.Close();
            }




        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxUsernameL_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
