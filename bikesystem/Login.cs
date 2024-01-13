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
        public Login()
        {
            InitializeComponent();
            Con = new Functions();
        }

        Functions Con;
        public static int SKey;
        public static string SName;
        private void Login_BackIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else if(NameTb.Text == "Admin" || PasswordTb.Text == "Admin")
            {
                Users obj = new Users();
                obj.Show();
                this.Hide();
            }
            else
            {
                string Query = "select * from UserTbl where UName = '{0}' and Password = '{1}'";
                Query = string.Format(Query, NameTb.Text, PasswordTb.Text);
                DataTable dt = Con.GetData(Query);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Wrong Credentials!!!");
                    NameTb.Text = "";
                    PasswordTb.Text = "";
                }
                else
                {
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
