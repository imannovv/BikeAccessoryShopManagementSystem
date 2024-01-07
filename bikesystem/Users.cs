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
        public Users()
        {
            InitializeComponent();
            Con = new Functions();
            ShowUsers();
        }

        private void ItemsManagementHeader_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GunaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {

        }

        private void EditItemButton_Click(object sender, EventArgs e)
        {

        }
        Functions Con;
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
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PhoneTb.Text == "" || UNameTb.Text == "" || AddressTb.Text == "" || PassWordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    String Name = NameTb.Text;
                    String UName = UNameTb.Text;
                    String Password = PassWordTb.Text;
                    String Address = AddressTb.Text;
                    String Phone = PhoneTb.Text;
                    String Query = "insert into UserTbl values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, Name, UName, Password, Phone, Address);
                    Con.SetData(Query);
                    ShowUsers();
                    MessageBox.Show("Success!!!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void QuantityBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemDetailsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemCategoryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackIcon_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ItemsManagementIcon_Click(object sender, EventArgs e)
        {

        }

        private void ItemPriceBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
