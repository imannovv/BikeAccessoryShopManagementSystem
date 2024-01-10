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
        public Bikes()
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
                string Query = "select * from ItemTbl";
                ItemsDGV.DataSource = Con.GetData(Query);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ItemsManagementHeader_Click(object sender, EventArgs e)
        {

        }

        int Key = 0;
        int User = 1;
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
                    String Name = NameTb.Text;
                    String Price = PriceTb.Text;
                    String Cat = CategoryTb.Text;
                    String Details = DetailsTb.Text;
                    String Qty = QtyTb.Text;
                    String Query = "insert into ItemTbl values('{0}',{1},'{2}','{3}',{4},{5})";
                    Query = string.Format(Query, Name, Price, Cat, Details, User, Qty);
                    Con.SetData(Query);
                    ShowItems();
                    MessageBox.Show("Success!!!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String Name = NameTb.Text;
                String Price = PriceTb.Text;
                String Cat = CategoryTb.Text;
                String Details = DetailsTb.Text;
                String Qty = QtyTb.Text;
                String Query = "update ItemTbl set ItName = '{0}',ItPrice = {1},ItCategory = '{2}',ItDetails = '{3}',AddedBy = '{4}',Qty = {5} where ItCode = {6}";
                Query = string.Format(Query, Name, Price, Cat, Details, User, Qty, Key);
                Con.SetData(Query);
                ShowItems();
                MessageBox.Show("Success!!!");
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String Query = "delete from ItemTbl where ItCode = {0}";
                Query = string.Format(Query, Key);
                Con.SetData(Query);
                ShowItems();
                MessageBox.Show("Success!!!");
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

        private void ItemsDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = ItemsDGV.SelectedRows[0].Cells[1].Value.ToString();
            PriceTb.Text = ItemsDGV.SelectedRows[0].Cells[2].Value.ToString();
            CategoryTb.Text = ItemsDGV.SelectedRows[0].Cells[3].Value.ToString();
            DetailsTb.Text = ItemsDGV.SelectedRows[0].Cells[4].Value.ToString();
            QtyTb.Text = ItemsDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (NameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ItemsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
