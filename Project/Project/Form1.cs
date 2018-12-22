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
    public partial class Form1 : Form
    {
        String UserId;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string s)
        {
            UserId = s;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CharPanel.Visible = false;
            PlatformPanel.Visible = false;
            DevPanel.Visible = false;
            GamePanel.Visible = false;
            HardwarePanel.Visible = false;
            MainPanel.Visible = true;
            CharPanel.Location = MainPanel.Location;
            PlatformPanel.Location = MainPanel.Location;
            HardwarePanel.Location = MainPanel.Location;
            GamePanel.Location = MainPanel.Location;
            DevPanel.Location = MainPanel.Location;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MaxBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DevBasedBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CharPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HardwareSearch_Click(object sender, EventArgs e)
        {
            CharPanel.Visible = false;
            PlatformPanel.Visible = false;
            DevPanel.Visible = false;
            GamePanel.Visible = false;
            HardwarePanel.Visible = true;
            MainPanel.Visible = false;
        }

        private void PlatformSearch_Click(object sender, EventArgs e)
        {
            CharPanel.Visible = false;
            PlatformPanel.Visible = true;
            DevPanel.Visible = false;
            GamePanel.Visible = false;
            HardwarePanel.Visible = false;
            MainPanel.Visible = false;
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GameSearch_Click(object sender, EventArgs e)
        {
            CharPanel.Visible = false;
            PlatformPanel.Visible = false;
            DevPanel.Visible = false;
            GamePanel.Visible = true;
            HardwarePanel.Visible = false;
            MainPanel.Visible = false;
        }

        private void DevSearch_Click(object sender, EventArgs e)
        {
            CharPanel.Visible = false;
            PlatformPanel.Visible = false;
            DevPanel.Visible = true;
            GamePanel.Visible = false;
            HardwarePanel.Visible = false;
            MainPanel.Visible = false;
        }

        private void CharSearch_Click(object sender, EventArgs e)
        {
            CharPanel.Visible = true;
            PlatformPanel.Visible = false;
            DevPanel.Visible = false;
            GamePanel.Visible = false;
            HardwarePanel.Visible = false;
            MainPanel.Visible = false;
        }

        private void LeftPanel1_Paint(object sender, PaintEventArgs e)
        {
            //DbConnection db = new DbConnection();
            //Form2 eps = new Form2();
            //this.Visible = false;
            //eps.ShowDialog();
            //this.Visible = true;
        }


        private void GameSearchBtn_Click_1(object sender, EventArgs e)
        {
            //DbConnection db = new DbConnection();
            //DataTable dt = db.Select("Exec ")
            if((GameNameBox.Text.Length > 0) && (FranchiseNameBox.Text.Length > 0) && (GenreNameBox.Text.Length > 0))
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByGame @GameName = '" + GameNameBox.Text + "', @FranName = '" + FranchiseNameBox.Text + "', @GenreName = '" + GenreNameBox.Text + "'");              
                Form2 f2 = new Form2(dt,UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
                
            }
            else if((GenreNameBox.Text.Length > 0) && (FranchiseNameBox.Text.Length > 0)) //Genre and franchise
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByGameBottomTwo  @FranName = '" + FranchiseNameBox.Text + "', @GenreName = '" + GenreNameBox.Text + "'");
                Form2 f2 = new Form2(dt,UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if ((GenreNameBox.Text.Length > 0) && (GameNameBox.Text.Length > 0)) //Genre and Game
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByGameTopTwo  @GameName = '" + GameNameBox.Text + "',  @GenreName = '" + GenreNameBox.Text + "'");
                Form2 f2 = new Form2(dt,UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }

            else if ((FranchiseNameBox.Text.Length > 0) && (GameNameBox.Text.Length > 0)) //Franchise and Game
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByGameAlternateTwo  @GameName = '" + GameNameBox.Text + "',  @FranName = '" + FranchiseNameBox.Text + "'");
                Form2 f2 = new Form2(dt,UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if (FranchiseNameBox.Text.Length > 0)
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByFanchiseName @FranNameAlter = '" + FranchiseNameBox.Text + "'");
                Form2 f2 = new Form2(dt,UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if(GenreNameBox.Text.Length > 0)
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByGenreName @GenreNameAlter = '" + GenreNameBox.Text + "'");
                Form2 f2 = new Form2(dt,UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if (GameNameBox.Text.Length > 0)
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByGameName @GameNameAlter = '" + GameNameBox.Text + "'");
                Form2 f2 = new Form2(dt,UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Please Fill in Atleast One Field");
            }
        }

        private void Char1Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Char2Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Char3Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Actor1Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Actor2Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Actor3Btn_TextChanged(object sender, EventArgs e)
        {

        }

        private void Voice1Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Voice2Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Voice3Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void CharMaleBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CharFemaleBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CharOtherBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CharDevBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CharActorBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CharStaffBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CharPlatBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CharHardwareBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CharSearchBtn_Click_1(object sender, EventArgs e)
        {
            if ((Char1Box.Text.Length > 0) && (Char2Box.Text.Length > 0) && (Char3Box.Text.Length > 0))
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByChar @Char1Name = '" + Char1Box.Text + "', @VActorName = '" + Voice1Box.Text + "', @ActorName = '" + Actor1Box.Text + "', @Char1Name2 = '" + Char2Box.Text + "', @VActorName2 = '" + Voice2Box.Text + "', @ActorName2 = '" + Actor2Box.Text + "', @Char1Name3 = '" + Char3Box.Text + "', @VActorName3 = '" + Voice3Box.Text + "', @ActorName3 = '" + Actor3Btn.Text + "'");
                Form2 f2 = new Form2(dt, UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if ((Char1Box.Text.Length > 0) && (Char2Box.Text.Length > 0))
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByCharTwo @Char1Name = '" + Char1Box.Text + "', @VActorName = '" + Voice1Box.Text + "', @ActorName = '" + Actor1Box.Text + "', @Char1Name2 = '" + Char2Box.Text + "', @VActorName2 = '" + Voice2Box.Text + "', @ActorName2 = '" + Actor2Box.Text + "'");
                Form2 f2 = new Form2(dt, UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if ((Char1Box.Text.Length > 0) && (CharMaleBtn.Checked))
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByCharOneMale @Char1Name = '" + Char1Box.Text + "', @VActorName = '" + Voice1Box.Text + "', @ActorName = '" + Actor1Box.Text + "'");
                Form2 f2 = new Form2(dt, UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if ((Char1Box.Text.Length > 0) && (CharFemaleBtn.Checked))
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByCharOneFeMale @Char1Name = '" + Char1Box.Text + "', @VActorName = '" + Voice1Box.Text + "', @ActorName = '" + Actor1Box.Text + "'");
                Form2 f2 = new Form2(dt, UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if ((Char1Box.Text.Length > 0) && (CharOtherBtn.Checked))
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByCharOneOther @Char1Name = '" + Char1Box.Text + "', @VActorName = '" + Voice1Box.Text + "', @ActorName = '" + Actor1Box.Text + "'");
                Form2 f2 = new Form2(dt, UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if (Char1Box.Text.Length > 0)
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByCharOne @Char1Name = '" + Char1Box.Text + "', @VActorName = '" + Voice1Box.Text + "', @ActorName = '" + Actor1Box.Text + "'");
                Form2 f2 = new Form2(dt, UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Please Fill in Vertical Search Fields Starting from the left and select a Gender");
            }
            
        }

        private void GameNameBox_TextChanged(object sender, EventArgs e)
        {
            //GamePanel
        }

        private void FranchiseNameBox_TextChanged(object sender, EventArgs e)
        {
            //GamePanel
        }

        private void GameDevBtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void GameCharBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GameActorBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GameStaffBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GamePlatBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GameHardwareBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DevSearchBtn_Click(object sender, EventArgs e)
        {            
            if ((DevNameBox.Text.Length > 0) && (DevBasedBox.Text.Length > 0) && (DevPubYesBtn.Checked))
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByDevPub @DevName = '" + DevNameBox.Text + "', @Based = '" + DevBasedBox.Text + "',  @Pub = 1");
                Form2 f2 = new Form2(dt, UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if ((DevNameBox.Text.Length > 0) && (DevBasedBox.Text.Length > 0) && (DevPubNoBtn.Checked))
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByDevPub @DevName = '" + DevNameBox.Text + "', @Based = '" + DevBasedBox.Text + "',  @Pub = 0");
                Form2 f2 = new Form2(dt, UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if ((DevNameBox.Text.Length > 0) && (DevPubYesBtn.Checked))
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByDevOnePub @DevName = '" + DevNameBox.Text + "', @Pub = 1");
                Form2 f2 = new Form2(dt, UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if ((DevNameBox.Text.Length > 0) && (DevPubNoBtn.Checked))
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByDevOnePub @DevName = '" + DevNameBox.Text + "', @Pub = 0 ");
                Form2 f2 = new Form2(dt, UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if ((DevBasedBox.Text.Length > 0) && (DevPubYesBtn.Checked))
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByDevTwoPub @Based = '" + DevBasedBox.Text + "', @Pub = 1");
                Form2 f2 = new Form2(dt, UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if ((DevBasedBox.Text.Length > 0) && (DevPubNoBtn.Checked))
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByDevTwoPub @Based = '" + DevBasedBox.Text + "', @Pub = 0");
                Form2 f2 = new Form2(dt, UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if ((DevNameBox.Text.Length > 0) && (DevBasedBox.Text.Length > 0))
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByDev @DevName = '" + DevNameBox.Text + "', @Based = '" + DevBasedBox.Text + "'");
                Form2 f2 = new Form2(dt, UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if (DevNameBox.Text.Length > 0)
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByDevOne @DevName = '" + DevNameBox.Text + "'");
                Form2 f2 = new Form2(dt,UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if (DevBasedBox.Text.Length > 0)
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByDevTwo @Based = '" + DevBasedBox.Text + "'");
                Form2 f2 = new Form2(dt, UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Please Fill in atleast one of the fields");
            }
        }

        private void DevNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DevPubYesBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DevPubNoBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DevCharBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DevActorBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DevPlatBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DevHardwareBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HardwareSearchBtn_Click(object sender, EventArgs e)
        {
            string a;
            string b;
            string c;
            string d;
            string f;
            string g;
            string h;
            string i;
            if (OSNameBox.Text == "")
            {
                a = "NULL";
            }
            else
            {
                a = "'" + OSNameBox.Text + "'";
            }

            if (DevCompanyBox.Text == "")
            {
                b = "NULL";
            }
            else
            {
                b = "'" + DevCompanyBox.Text + "'";
            }

            if (RamNameBox.Text == "")
            {
                c = "NULL";
            }
            else
            {
                c = "'" + RamNameBox.Text + "'";
            }

            if (RamPriceBox.Text == "")
            {
                d = "NULL";
            }
            else
            {
                d = "'" + RamPriceBox.Text + "'";
            }

            if (GpuNameBox.Text == "")
            {
                f = "NULL";
            }
            else
            {
                f = "'" + GpuNameBox.Text + "'";
            }

            if (GpuPriceBox.Text == "")
            {
                g = "NULL";
            }
            else
            {
                g = "'" + GpuPriceBox.Text + "'";
            }

            if (CpuNameBox.Text == "")
            {
                h = "NULL";
            }
            else
            {
                h = "'" + CpuNameBox.Text + "'";
            }

            if (CpuPriceBox.Text == "")
            {
                i = "NULL";
            }
            else
            {
                i = "'" + CpuPriceBox.Text + "'";
            }

            DbConnection db = new DbConnection();
            string s = "Exec SearchByRequirements @SoftwareName = " + a + ", @Company = " + b + ", @Ram = " + c + ", @RamPrice = " + d + ", @gpu = " + f + ", @gpuprice = " + g + ", @cpu = " + h + ", @cpuprice = " + i;
            DataTable dt = db.Select(s);
            Form2 f2 = new Form2(dt, UserId);
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }

        private void OSNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DevCompanyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RamNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RamPriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GpuNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GpuPriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CpuNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CpuPriceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HardwareDevBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HarwareActorBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HardwareStaffBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HardwareCharBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PlatSearchBtn_Click(object sender, EventArgs e)
        {
            if ((PlatNameBox.Text.Length > 0) && (PlatGameBox.Text.Length > 0))
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByPlat  @PlatName = '" + PlatNameBox.Text + "',  @GameName = '" + PlatGameBox.Text + "'");
                Form2 f2 = new Form2(dt,UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if (PlatNameBox.Text.Length > 0)
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByPlatPlat  @PlatName = '" + PlatNameBox.Text + "'");
                Form2 f2 = new Form2(dt,UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else if (PlatGameBox.Text.Length > 0)
            {
                DbConnection db = new DbConnection();
                DataTable dt = db.Select("Exec SearchByPlatGame  @GameName = '" + PlatGameBox.Text + "'");
                Form2 f2 = new Form2(dt,UserId);
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Please fill in either one of Platform Name or Game Name");
            }

            //Platform Search
            //Form2 f2 = new Form2();
            //this.Hide();
            //f2.ShowDialog();
            //this.Show();
        }

        private void PlatNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlatVersionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlatDevBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlatDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PlatDevBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PlatActorBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PlatStaffBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PlatCharBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PlatHardwareBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GenreNameBox_TextChanged(object sender, EventArgs e)
        {
            //GAmePanelGenreNameBox
        }

        private void PlatGameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
