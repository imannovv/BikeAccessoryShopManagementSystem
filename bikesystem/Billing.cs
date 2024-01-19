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
    public partial class Billing : Form
    {
        // Create an instance of the Functions class
        Functions Con;

        // Constructor for the Billing form
        public Billing()
        {
            InitializeComponent();

            // Initialize the Functions class
            Con = new Functions();

            // Display the items in the DataGridView
            ShowItems();

            // Set the username label to the currently logged-in user
            ULabel.Text = Login.SName;

            // Hide the Grand Total label initially
            GrdTotalbl.Visible = false;
        }

        // Method to display items in the DataGridView
        private void ShowItems()
        {
            try
            {
                // SQL query to select items from the database
                string Query = "select ItCode as Code, ItName as Item, ItPrice as Price, Qty as Stock from ItemTbl";
                // Get data from the database using the Functions class and bind it to the DataGridView
                ItemsDGV.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        // Variables for tracking the added items and total
        int n = 0;
        int GrdTotal = 0;

        // Event handler for the "Add" button
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else if (Convert.ToInt32(QtyTb.Text) > Stock)
            {
                MessageBox.Show("Not Enough Stock!!!");
            }
            else
            {
                // Calculate total cost for the current item
                int total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(AmountTb.Text);

                // Create a new row in the DataGridView
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = NameTb.Text;
                newRow.Cells[2].Value = AmountTb.Text;
                newRow.Cells[3].Value = QtyTb.Text;
                newRow.Cells[4].Value = total + "$";

                // Add the new row to the DataGridView
                BillDGV.Rows.Add(newRow);

                // Update counters and total
                n++;
                GrdTotal = GrdTotal + total;

                // Display the Grand Total and make it visible
                GrdTotalbl.Visible = true;
                GrdTotalbl.Text = GrdTotal + "$";
            }
        }

        // Variables for tracking the selected item
        int Key = Login.SKey;
        int Stock = 0;

        // Event handler for clicking on a cell in the Items DataGridView
        private void ItemsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get information from the selected row in the Items DataGridView
            NameTb.Text = ItemsDGV.SelectedRows[0].Cells[1].Value.ToString();
            AmountTb.Text = ItemsDGV.SelectedRows[0].Cells[2].Value.ToString();
            Stock = Convert.ToInt32(ItemsDGV.SelectedRows[0].Cells[3].Value.ToString());

            // Store the key for the selected item
            if (NameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ItemsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        // Event handler for the "Reset" button
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            // Clear the input fields
            NameTb.Text = "";
            AmountTb.Text = "";
            QtyTb.Text = "";
        }

        // Event handler for the "Bikes" button
        private void AccessoriesButton_Click(object sender, EventArgs e)
        {
            // Open the Bikes form and hide the current form
            Bikes Obj = new Bikes();
            Obj.Show();
            this.Hide();
        }

        // Event handler for the "Logout" button
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            // Open the Login form and hide the current form
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        // Event handler for clicking the exit icon
        private void ExitIcon_Click_1(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }
    }
}
