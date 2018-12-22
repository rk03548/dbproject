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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();

            DataTable dt = db.Select("select* from Users U where U.UserID = '" +UserNameSignUpBox.Text+"'");
            if (dt.Rows.Count == 0)
            {
                db.Inserts("exec AddUser @ID = '" + UserNameSignUpBox.Text + "', @Name = '" + NameSignUpBox.Text + "', @Password = '" + passwordSignUpBox.Text + "'");
            }
            else if (dt.Rows.Count == 1)
            {
                MessageBox.Show("That User Name already Exists");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
