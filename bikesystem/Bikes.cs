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
    public partial class Bikes : Form
    {
        // Create an instance of the Functions class
        Functions Con;

        // Constructor for the Bikes form
        public Bikes()
        {
            InitializeComponent();

            // Initialize the Functions class
            Con = new Functions();

            // Display items in the DataGridView
            ShowItems();
        }

        // Method to display items in the DataGridView
        private void ShowItems()
        {
            try
            {
                // SQL query to select all items from the ItemTbl table
                string Query = "select * from ItemTbl";
                // Get data from the database using the Functions class and bind it to the DataGridView
                ItemsDGV.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        // Variables for tracking the selected item and the logged-in user
        int Key = 0;
        int User = Login.SKey;

        // Event handler for the "Add" button
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PriceTb.Text == "" || CategoryTb.Text == "" || DetailsTb.Text == "" || QtyTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    // Retrieve data from input fields
                    String Name = NameTb.Text;
                    String Price = PriceTb.Text;
                    String Cat = CategoryTb.Text;
                    String Details = DetailsTb.Text;
                    String Qty = QtyTb.Text;

                    // SQL query to insert a new item into the ItemTbl table
                    String Query = "insert into ItemTbl values('{0}',{1},'{2}','{3}',{4},{5})";
                    Query = string.Format(Query, Name, Price, Cat, Details, User, Qty);

                    // Execute the query using the Functions class
                    Con.SetData(Query);

                    // Refresh the displayed items in the DataGridView
                    ShowItems();

                    MessageBox.Show("Success!!!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Event handler for the "Edit" button
        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve data from input fields
                String Name = NameTb.Text;
                String Price = PriceTb.Text;
                String Cat = CategoryTb.Text;
                String Details = DetailsTb.Text;
                String Qty = QtyTb.Text;

                // SQL query to update an existing item in the ItemTbl table
                String Query = "update ItemTbl set ItName = '{0}',ItPrice = {1},ItCategory = '{2}',ItDetails = '{3}',AddedBy = '{4}',Qty = {5} where ItCode = {6}";
                Query = string.Format(Query, Name, Price, Cat, Details, User, Qty, Key);

                // Execute the query using the Functions class
                Con.SetData(Query);

                // Refresh the displayed items in the DataGridView
                ShowItems();

                MessageBox.Show("Success!!!");

                // Clear input fields
                NameTb.Text = "";
                PriceTb.Text = "";
                CategoryTb.Text = "";
                DetailsTb.Text = "";
                QtyTb.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        // Event handler for the "Delete" button
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // SQL query to delete an item from the ItemTbl table
                String Query = "delete from ItemTbl where ItCode = {0}";
                Query = string.Format(Query, Key);

                // Execute the query using the Functions class
                Con.SetData(Query);

                // Refresh the displayed items in the DataGridView
                ShowItems();

                MessageBox.Show("Success!!!");

                // Clear input fields
                NameTb.Text = "";
                PriceTb.Text = "";
                CategoryTb.Text = "";
                DetailsTb.Text = "";
                QtyTb.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        // Event handler for clicking on a cell in the Items DataGridView
        private void ItemsDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Retrieve data from the selected row in the Items DataGridView
            NameTb.Text = ItemsDGV.SelectedRows[0].Cells[1].Value.ToString();
            PriceTb.Text = ItemsDGV.SelectedRows[0].Cells[2].Value.ToString();
            CategoryTb.Text = ItemsDGV.SelectedRows[0].Cells[3].Value.ToString();
            DetailsTb.Text = ItemsDGV.SelectedRows[0].Cells[4].Value.ToString();
            QtyTb.Text = ItemsDGV.SelectedRows[0].Cells[6].Value.ToString();

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

        // Event handler for the "Bills" button
        private void BillsButton_Click(object sender, EventArgs e)
        {
            // Open the Billing form and hide the current form
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
