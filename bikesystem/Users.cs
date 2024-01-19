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
    public partial class Users : Form
    {
        // Creating an instance of the Functions class
        Functions Con;

        // Key variable to store the selected user's unique identifier
        int Key = 0;

        // Constructor for the Users form
        public Users()
        {
            InitializeComponent();
            // Initializing the Con variable with a new instance of the Functions class
            Con = new Functions();
            // Calling the ShowUsers method to display user data in the DataGridView
            ShowUsers();
        }

        // Event handler for clicking on a cell in the DataGridView
        private void UsersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Populating textboxes with the selected user's information
            NameTb.Text = UsersDGV.SelectedRows[0].Cells[1].Value.ToString();
            UNameTb.Text = UsersDGV.SelectedRows[0].Cells[2].Value.ToString();
            PassWordTb.Text = UsersDGV.SelectedRows[0].Cells[3].Value.ToString();
            PhoneTb.Text = UsersDGV.SelectedRows[0].Cells[4].Value.ToString();
            AddressTb.Text = UsersDGV.SelectedRows[0].Cells[5].Value.ToString();

            // Setting the Key variable to the selected user's unique identifier
            if (NameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(UsersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        // Event handler for the Delete button click
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Checking if a user is selected
            if (Key == 0)
            {
                MessageBox.Show("Select a User!!!");
            }
            else
            {
                try
                {
                    // Deleting the selected user from the database
                    String Query = "delete from UserTbl where UCode = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    // Refreshing the DataGridView to reflect the changes
                    ShowUsers();
                    MessageBox.Show("Success!!!");

                    // Clearing the textboxes
                    NameTb.Text = "";
                    UNameTb.Text = "";
                    PassWordTb.Text = "";
                    PhoneTb.Text = "";
                    AddressTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Event handler for the Edit button click
        private void EditBtn_Click(object sender, EventArgs e)
        {
            // Checking if any data is missing in the textboxes
            if (NameTb.Text == "" || PhoneTb.Text == "" || UNameTb.Text == "" || AddressTb.Text == "" || PassWordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    // Updating the selected user's information in the database
                    String Name = NameTb.Text;
                    String UName = UNameTb.Text;
                    String Password = PassWordTb.Text;
                    String Address = AddressTb.Text;
                    String Phone = PhoneTb.Text;
                    String Query = "update UserTbl set Name = '{0}',UName = '{1}',Password = '{2}',Phone = '{3}',Address = '{4}' where UCode = {5}";
                    Query = string.Format(Query, Name, UName, Password, Phone, Address, Key);
                    Con.SetData(Query);
                    // Refreshing the DataGridView to reflect the changes
                    ShowUsers();
                    MessageBox.Show("Success!!!");

                    // Clearing the textboxes
                    NameTb.Text = "";
                    UNameTb.Text = "";
                    PassWordTb.Text = "";
                    PhoneTb.Text = "";
                    AddressTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Method to retrieve and display user data in the DataGridView
        private void ShowUsers()
        {
            try
            {
                string Query = "select * from UserTbl";
                UsersDGV.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        // Event handler for the Add button click
        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Checking if any data is missing in the textboxes
            if (NameTb.Text == "" || PhoneTb.Text == "" || UNameTb.Text == "" || AddressTb.Text == "" || PassWordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    // Inserting a new user into the database
                    String Name = NameTb.Text;
                    String UName = UNameTb.Text;
                    String Password = PassWordTb.Text;
                    String Address = AddressTb.Text;
                    String Phone = PhoneTb.Text;
                    String Query = "insert into UserTbl values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, Name, UName, Password, Phone, Address);
                    Con.SetData(Query);
                    // Refreshing the DataGridView to reflect the changes
                    ShowUsers();
                    MessageBox.Show("Success!!!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Event handler for the LogOutButton click
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            // Redirecting to the Login form
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        // Event handler for the AccessoriesButton click
        private void AccessoriesButton_Click(object sender, EventArgs e)
        {
            // Redirecting to the Bikes form
            Bikes Obj = new Bikes();
            Obj.Show();
            this.Hide();
        }

        // Event handler for the BillsButton click
        private void BillsButton_Click(object sender, EventArgs e)
        {
            // Redirecting to the Billing form
            Billing Obj = new Billing();
            Obj.Show();
            this.Hide();
        }

        // Event handler for clicking the exit icon
        private void ExitIcon_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }
    }
}
