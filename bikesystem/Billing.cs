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
        public Billing()
        {
            InitializeComponent();
            Con = new Functions();
            ShowItems();
        }

        Functions Con;
        private void ShowItems()
        {
            try
            {
                string Query = "select ItCode as Code, ItName as Item, ItPrice as Price, Qty as Stock from ItemTbl";
                ItemsDGV.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        private void UsersManagementHeader_Click(object sender, EventArgs e)
        {

        }

        private void ItemsManagementIcon_Click(object sender, EventArgs e)
        {

        }

        private void BackIcon_Click(object sender, EventArgs e)
        {

        }

        private void User_UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void User_PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_DeleteUserButton_Click(object sender, EventArgs e)
        {

        }

        private void User_EditUserButton_Click(object sender, EventArgs e)
        {

        }

        private void User_AddUserButton_Click(object sender, EventArgs e)
        {

        }

        private void User_AddressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_PhoneBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GunaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Billing_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        int Key = Login.SKey;
        int Stock = 0;
        private void ItemsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = ItemsDGV.SelectedRows[0].Cells[1].Value.ToString();
            AmountTb.Text = ItemsDGV.SelectedRows[0].Cells[2].Value.ToString();
            Stock = Convert.ToInt32(ItemsDGV.SelectedRows[0].Cells[3].Value.ToString());
            //DetailsTb.Text = ItemsDGV.SelectedRows[0].Cells[4].Value.ToString();
            //QtyTb.Text = ItemsDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (NameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ItemsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            AmountTb.Text = "";
            QtyTb.Text = "";
        }

        private void AccessoriesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
