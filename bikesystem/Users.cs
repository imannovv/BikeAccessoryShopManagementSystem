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
        
        int Key = 0;
        private void UsersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = UsersDGV.SelectedRows[0].Cells[1].Value.ToString();
            UNameTb.Text = UsersDGV.SelectedRows[0].Cells[2].Value.ToString();
            PassWordTb.Text = UsersDGV.SelectedRows[0].Cells[3].Value.ToString();
            PhoneTb.Text = UsersDGV.SelectedRows[0].Cells[4].Value.ToString();
            AddressTb.Text = UsersDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (NameTb.Text == "")
            {
                Key = 0;
            }
            else 
            {
                Key = Convert.ToInt32(UsersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void GunaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select a User!!!");
            }
            else
            {
                try
                {
                    String Query = "delete from UserTbl where UCode = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowUsers();
                    MessageBox.Show("Success!!!");
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

        private void EditBtn_Click(object sender, EventArgs e)
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
                    String Query = "update UserTbl set Name = '{0}',UName = '{1}',Password = '{2}',Phone = '{3}',Address = '{4}' where UCode = {5}";
                    Query = string.Format(Query, Name, UName, Password, Phone, Address, Key);
                    Con.SetData(Query);
                    ShowUsers();
                    MessageBox.Show("Success!!!");
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
        private void AddBtn_Click(object sender, EventArgs e)
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

        private void ExitIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
