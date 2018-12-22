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
    public partial class Form2 : Form
    {
        String UserId;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(DataTable dtable, string S)
        {
            InitializeComponent();
            ResultsGrid.DataSource = dtable;
            UserId = S;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ReviewSearchButton_Click(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();
            DataTable dt = db.Select("Exec SearchReviews @GameID = '" + ameReviewIDBox.Text + "'");
            ReviewGrid.DataSource = dt;
        }

        private void ameReviewIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReviewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddReviewBtn_Click(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();
            db.Inserts("exec AddReview @Score = '" + ScoreBox.Text + "', @ID = '" + UserId + "', @Text = '" + ReviewBox.Text + "', @game = '" +ameReviewIDBox.Text+ "'");
            DataTable dt = db.Select("Exec SearchReviews @GameID = '" + ameReviewIDBox.Text + "'");
            ReviewGrid.DataSource = dt;
        }
    }
}
