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
    public partial class frmProgress : Form
    {
        decimal[] weight = new decimal[] { };
        decimal endWeight = 45;
        SqlConnection Conn = new SqlConnection();
        string DBConnectionString = "Data Source=DESKTOP-4PD7ECD;Initial Catalog=NEAAppDb;Integrated Security=True;Connect Timeout=30";
        DateTime today = DateTime.Today;

        public frmProgress()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmProgress_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEAAppDbDataSet1.progress1' table. You can move, or remove it, as needed.
            this.progress1TableAdapter.Fill(this.nEAAppDbDataSet1.progress1);

        }

        private void buttonUpdateProgress_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conn;
            cmd.CommandText = $"INSERT into progress1 values ('{UserDetails.userID}', '{today}', '{numericUpDownCurrentWeight.Value}','{endWeight}')";
        }
    }
}
