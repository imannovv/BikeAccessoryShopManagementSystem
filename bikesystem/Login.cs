using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bikesystem
{
    public partial class Login : Form
    {
        // Create an instance of the Functions class
        Functions Con;

        // Static variables to store user information
        public static int SKey;
        public static string SName;

        // Constructor for the Login form
        public Login()
        {
            InitializeComponent();

            // Initialize the Functions class
            Con = new Functions();
        }

        // Event handler for the button to close the application
        private void Login_BackIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event handler for the login button
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Check if either the username or password fields are empty
            if (NameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            // Check if the input is the admin's credentials
            else if (NameTb.Text == "Admin" || PasswordTb.Text == "Admin")
            {
                // If admin credentials, open the Users form and hide the Login form
                Users obj = new Users();
                obj.Show();
                this.Hide();
            }
            else
            {
                // If not admin, check the credentials in the database
                string Query = "select * from UserTbl where UName = '{0}' and Password = '{1}'";
                Query = string.Format(Query, NameTb.Text, PasswordTb.Text);

                // Get data from the database using the Functions class
                DataTable dt = Con.GetData(Query);

                // Check if there are no rows returned (wrong credentials)
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Wrong Credentials!!!");
                    NameTb.Text = "";
                    PasswordTb.Text = "";
                }
                else
                {
                    // If credentials are correct, store user information and open the Bikes form
                    SName = NameTb.Text;
                    SKey = Convert.ToInt32(dt.Rows[0][0].ToString());
                    Bikes obj = new Bikes();
                    obj.Show();
                    this.Hide();
                }
            }
        }
    }
}
