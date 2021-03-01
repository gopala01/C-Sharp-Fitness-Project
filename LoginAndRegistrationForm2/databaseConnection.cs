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
    public partial class databaseConnection : Form
    { 
        
        SqlConnection Conn = new SqlConnection();
        string DBConnectionString = "Data Source=DESKTOP-4PD7ECD;Initial Catalog=NEAAppDb;Integrated Security=True;Connect Timeout=30";
        
    
        public databaseConnection()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            Conn.ConnectionString = textBoxConnection.Text;
            Conn.Open();
            
        }

        private void textBoxConnection_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            Conn.Close();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxSetDate.Text);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into activity_timetable (userID, setDate, setTime, activity) values('2','{textBoxSetDate.Text}','{textBoxSetTime.Text}','{textBoxSetActivity.Text}')";
            cmd.Connection = Conn;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succeeded");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void textBoxSetDate_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void databaseConnection_Load(object sender, EventArgs e)
        {

        }
    }
}

