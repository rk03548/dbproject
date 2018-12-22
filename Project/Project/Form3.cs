using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();

            DataTable dt = db.Select("exec SignIn @ID = '" + UserNameBox.Text + "', @password = '" +PasswordBox.Text+ "'");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("The Username or Password are incorrect");
            }
            else if (dt.Rows.Count == 1)
            {
                Form f1 = new Form1(UserNameBox.Text);
                this.Hide();
                f1.ShowDialog();
                this.Close();
            }
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
            this.Show();
        }

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
