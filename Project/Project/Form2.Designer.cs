namespace Project
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ResultsGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ameReviewIDBox = new System.Windows.Forms.TextBox();
            this.ReviewBox = new System.Windows.Forms.TextBox();
            this.AddReviewBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReviewGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.ScoreBox = new System.Windows.Forms.TextBox();
            this.ReviewSearchButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.MinBtn);
            this.panel1.Controls.Add(this.MaxBtn);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 47);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MinBtn
            // 
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBtn.ForeColor = System.Drawing.Color.White;
            this.MinBtn.Location = new System.Drawing.Point(927, 0);
            this.MinBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(53, 49);
            this.MinBtn.TabIndex = 7;
            this.MinBtn.Text = "-";
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // MaxBtn
            // 
            this.MaxBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MaxBtn.BackgroundImage")));
            this.MaxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MaxBtn.FlatAppearance.BorderSize = 0;
            this.MaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxBtn.ForeColor = System.Drawing.Color.White;
            this.MaxBtn.Location = new System.Drawing.Point(981, 0);
            this.MaxBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(53, 47);
            this.MaxBtn.TabIndex = 6;
            this.MaxBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(1031, 0);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(53, 49);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox1.Location = new System.Drawing.Point(16, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Results Screen";
            // 
            // ResultsGrid
            // 
            this.ResultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsGrid.Location = new System.Drawing.Point(16, 105);
            this.ResultsGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultsGrid.Name = "ResultsGrid";
            this.ResultsGrid.Size = new System.Drawing.Size(988, 133);
            this.ResultsGrid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(11, 497);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Game ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(16, 535);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Review";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(136, 453);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(672, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Drop A Review For A Game Of Your Choice Using The Space Below!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ameReviewIDBox
            // 
            this.ameReviewIDBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ameReviewIDBox.Location = new System.Drawing.Point(171, 494);
            this.ameReviewIDBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ameReviewIDBox.Name = "ameReviewIDBox";
            this.ameReviewIDBox.Size = new System.Drawing.Size(132, 32);
            this.ameReviewIDBox.TabIndex = 5;
            this.ameReviewIDBox.TextChanged += new System.EventHandler(this.ameReviewIDBox_TextChanged);
            // 
            // ReviewBox
            // 
            this.ReviewBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ReviewBox.Location = new System.Drawing.Point(16, 576);
            this.ReviewBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReviewBox.Multiline = true;
            this.ReviewBox.Name = "ReviewBox";
            this.ReviewBox.Size = new System.Drawing.Size(987, 94);
            this.ReviewBox.TabIndex = 6;
            // 
            // AddReviewBtn
            // 
            this.AddReviewBtn.Location = new System.Drawing.Point(904, 697);
            this.AddReviewBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddReviewBtn.Name = "AddReviewBtn";
            this.AddReviewBtn.Size = new System.Drawing.Size(100, 28);
            this.AddReviewBtn.TabIndex = 7;
            this.AddReviewBtn.Text = "Add";
            this.AddReviewBtn.UseVisualStyleBackColor = true;
            this.AddReviewBtn.Click += new System.EventHandler(this.AddReviewBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(16, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Results";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(16, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Reviews:";
            // 
            // ReviewGrid
            // 
            this.ReviewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReviewGrid.Location = new System.Drawing.Point(16, 294);
            this.ReviewGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReviewGrid.Name = "ReviewGrid";
            this.ReviewGrid.Size = new System.Drawing.Size(988, 133);
            this.ReviewGrid.TabIndex = 10;
            this.ReviewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReviewGrid_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(11, 699);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Your Score:";
            // 
            // ScoreBox
            // 
            this.ScoreBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ScoreBox.Location = new System.Drawing.Point(171, 697);
            this.ScoreBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(132, 32);
            this.ScoreBox.TabIndex = 12;
            // 
            // ReviewSearchButton
            // 
            this.ReviewSearchButton.Location = new System.Drawing.Point(903, 497);
            this.ReviewSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReviewSearchButton.Name = "ReviewSearchButton";
            this.ReviewSearchButton.Size = new System.Drawing.Size(100, 28);
            this.ReviewSearchButton.TabIndex = 13;
            this.ReviewSearchButton.Text = "Search";
            this.ReviewSearchButton.UseVisualStyleBackColor = true;
            this.ReviewSearchButton.Click += new System.EventHandler(this.ReviewSearchButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(581, 497);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(301, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Search Reviews for this game!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 764);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ReviewSearchButton);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ReviewGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddReviewBtn);
            this.Controls.Add(this.ReviewBox);
            this.Controls.Add(this.ameReviewIDBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultsGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MaxBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.DataGridView ResultsGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ameReviewIDBox;
        private System.Windows.Forms.TextBox ReviewBox;
        private System.Windows.Forms.Button AddReviewBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ReviewGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ScoreBox;
        private System.Windows.Forms.Button ReviewSearchButton;
        private System.Windows.Forms.Label label7;
    }
}