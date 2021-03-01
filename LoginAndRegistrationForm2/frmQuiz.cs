using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;

namespace LoginAndRegistrationForm2
{
    public partial class frmQuiz : Form
    {
        string[] breakfastOptions = new string[] { };
        string[] lunchOptions = new string[] { };
        string[] dinnerOptions = new string[] { };

        string userName;
        bool userExists;
        DateTime dob ;
        string gender = "";
        string diet;
        decimal currentWeight ;
        decimal targetWeight ;
        decimal startWeight;
        decimal change = 0;
        string exerciseType = "";
        //string[] exercise = new string[] { "Press Ups", "Sit Ups", "Mountain Climbers", "Squats" };




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
                cmdString = $"update Dbo.user_details set datecreated = GetDate()," +
                    $"DateOfBirth ='{sqlformatdate}', gender = '{gender}', " +
                    $"currentweight = {currentWeight}, targetWeight = {targetWeight}, " +
                    $"dietType = '{diet}'" +
                    $" where username =  '{userName}'";
                runNonQuerySQL(cmdString);
                

            }
            else //adds user data if user doesn't exist
            {
                cmdString = $"INSERT INTO Dbo.user_details Values(GetDate(),'{userName}', '{dob}', '{gender}', " +
                    $"{currentWeight}, {targetWeight}, '{diet}')";
                runNonQuerySQL(cmdString);

                
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
                diet = "Vegetarian";
                

            }
            else if (radioNonVeg.Checked)
            {
                diet = "Non-Vegetarian";
            }
            else if (radioVegan.Checked)
            {
                diet = "Vegan";
            }
            change = currentWeight - targetWeight;
            if (change > 0)
            {
                exerciseType = "Weight Loss";
            }
            else if (change < 0)
            {
                exerciseType = "Weight Gain";
            }
            

              
            


            //frmSetTimetable st = new frmSetTimetable();
            ////st.Show();
            ////st.ShowDialog();
            ////this.Show();

            if (diet == "Vegetarian")
            {
                breakfastOptions = new string[]{ "Healthy Yogurt Parfait", "Pear Walnut Salad with a Mustard Orange Dressing", "Healthy Pumpkin Oatmeal Mini Muffins", "Vegan Overnight Oats in a Jar",  
                                          "Low Carb Cream Cheese Pancakes", "Chia Seeds Natural Energy Drink", "Smashed Chickpea Salad Sandwich", "Spinach Feta Pancakes"};

                lunchOptions = new string[] { "Meatless Chili Con Carne", "Vegan Chickpea Summer Salad", "Turkish Lentil Salad", "Tangy Veggie Wrap", "Vegan Spanish Beans with Tomatoes", 
                                       "Thai Quinoa Salad", "Vegetarian Tacos", "Vegan Cauliflower Risotto", "Curried Parsnip Soup", "Fitness Lentil Bean Salad"};

                dinnerOptions = new string[] { "Easy Stuffed Bell Peppers in Mediterranean Tomato Sauce", "Easy Cauliflower Curry", "Roasted Eggplant And Tomato Gnocchi", "Baked Ricotta",
                                        "Broccoli and Cauliflower Soup", "Speedy Vegan Burrito", "Traditional Meatless Meatloaf", "Spicy Black Bean Soup", "Red Lentil Spinach Soup"};

                //Link - https://hurrythefoodup.com/vegetarian-weight-loss-recipes-diet-month/
            }

            if (diet == "Vegan")
            {
                breakfastOptions = new string[]{ "Banana Egg Pancakes", "Healthy Yogurt Parfait", "Pear Walnut Salad with a Mustard Orange Dressing", "Healthy Pumpkin Oatmeal Mini Muffins",
                                          "Vegan Overnight Oats in a Jar", "Italian-Style Healthy breakfast Egg Muffins" , "Low Carb Cream Cheese Pancakes",
                                          "Chia Seeds Natural Energy Drink", "Smashed Chickpea Salad Sandwich", "Spinach Feta Pancakes"};

                lunchOptions = new string[] { "Meatless Chili Con Carne", "Vegan Chickpea Summer Salad", "Turkish Lentil Salad", "Easy Hemp Granola", "Tangy Veggie Wrap",
                                        "Vegan Spanish Beans with Tomatoes", "Smoked Salmon Eggs Benedict", "Vegetarian Tacos", "Vegan Cauliflower Risotto", 
                                       "Curried Parsnip Soup", "Fitness Lentil Bean Salad"};

                dinnerOptions = new string[] { "Easy Stuffed Bell Peppers in Mediterranean Tomato Sauce", "Easy Cauliflower Curry", "Roasted Eggplant And Tomato Gnocchi", "Baked Ricotta", 
                                        " Broccoli and Cauliflower Soup", "Speedy Vegan Burrito", "Traditional Meatless Meatloaf", "Spicy Black Bean Soup", "Red Lentil Spinach Soup"};

                //Link - https://hurrythefoodup.com/vegetarian-weight-loss-recipes-diet-month/
            }

            if (diet == "Non-Vegetarian")
            {
                breakfastOptions = new string[]{ "Banana Egg Pancakes", "Bacon Egg in a Hole with Smashed Avocado", "Healthy Bacon, Egg, and Potato breakfast Casserole", 
                                          "Healthy Pumpkin Oatmeal Mini Muffins", "Vegan Overnight Oats in a Jar", "Italian-Style Healthy breakfast Egg Muffins" , 
                                          "Low Carb Cream Cheese Pancakes", "Chia Seeds Natural Energy Drink", "Smashed Chickpea Salad Sandwich", "Spinach Feta Pancakes"};

                lunchOptions = new string[] { "Kale Salad with salmon and avocado", "Turkish Lentil Salad", "Easy Hemp Granola", "Tangy Veggie Wrap",
                                        "Tuna wraps with pesto and tomato", "Smoked Salmon Eggs Benedict", "Brussels sprout salad with grilled chicken",
                                        "Fish Tacos","Curried Parsnip Soup", "Tuna salad"};

                dinnerOptions = new string[] { "Easy Stuffed Bell Peppers in Mediterranean Tomato Sauce", "Healthy chicken and coconut curry", "Roasted Eggplant And Tomato Gnocchi", "Salmon, chia and broccoli fish cakes",
                                        " Broccoli and Cauliflower Soup", "Creamy chicken and pea carbonara pasta", "Spicy prawn tacos with bean salad", "Spicy Black Bean Soup", "Red Lentil Spinach Soup"};

                /*Links:       
                 *             https://hurrythefoodup.com/vegetarian-weight-loss-recipes-diet-month/,
                 * breakfast - https://www.taste.com.au/healthy/galleries/top-100-weight-loss-dinners-kickstart-healthy-eating-regime/zov73zkp 
                 * lunch     - https://www.womenshealthmag.com/weight-loss/a19924506/easy-lunches-for-weight-loss/
                 * dinner    - https://www.taste.com.au/healthy/galleries/top-100-weight-loss-dinners-kickstart-healthy-eating-regime/zov73zkp?page=11
                 */
            }

           
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conn;
            cmd.CommandText = $"INSERT into progress values ('{userName}', '{numCurrentWeight.Value}','{numTargetWeight.Value}')";

            //UserActivity ua = new UserActivity();
            //ua.Show();
            //this.Close();

            saveDetails(UserDetails.userName, dob, gender, currentWeight, targetWeight, diet); //Passes these values over to the subroutine saveDetails

            MessageBox.Show($"User details for {userName} saved");
            //UserActivity.Quiz
            //this.Close();

            this.Close();


        }
        private void getGoalChecker()
        {
            String sqlGoalText =  $"INSERT INTO Dbo.goals Values(GetDate(),'{userName}', '{startWeight}', '{targetWeight}', '{currentWeight}')";
            runNonQuerySQL(sqlGoalText);


        }
        private void fetchUserDetails()
        {
            String sqlText = $"select dateofbirth, gender, CurrentWeight, TargetWeight, DietType " +
                             $"from dbo.user_details " +
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
                //query and set below values
                
                dob = dateTimePicker1.Value.Date;
                gender = "";
                diet = "";
                currentWeight = numCurrentWeight.Value;
                targetWeight = numTargetWeight.Value;
                startWeight = numCurrentWeight.Value;
                fetchUserDetails();
            }
        }

        private void numCurrentWeight_ValueChanged(object sender, EventArgs e)
        {




        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numTargetWeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioNonVeg_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
