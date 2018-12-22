namespace Project
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNameSignUpBox = new System.Windows.Forms.TextBox();
            this.passwordSignUpBox = new System.Windows.Forms.TextBox();
            this.CreateUserBtn = new System.Windows.Forms.Button();
            this.NameSignUpBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.MinBtn);
            this.panel1.Controls.Add(this.MaxBtn);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 53);
            this.panel1.TabIndex = 0;
            // 
            // MinBtn
            // 
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBtn.ForeColor = System.Drawing.Color.White;
            this.MinBtn.Location = new System.Drawing.Point(701, 0);
            this.MinBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(53, 49);
            this.MinBtn.TabIndex = 10;
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
            this.MaxBtn.Location = new System.Drawing.Point(756, 0);
            this.MaxBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(53, 47);
            this.MaxBtn.TabIndex = 9;
            this.MaxBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(805, 0);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(53, 49);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sign Up Screen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(57, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter A User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(57, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter A Password:";
            // 
            // UserNameSignUpBox
            // 
            this.UserNameSignUpBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.UserNameSignUpBox.Location = new System.Drawing.Point(299, 138);
            this.UserNameSignUpBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserNameSignUpBox.Name = "UserNameSignUpBox";
            this.UserNameSignUpBox.Size = new System.Drawing.Size(483, 32);
            this.UserNameSignUpBox.TabIndex = 7;
            // 
            // passwordSignUpBox
            // 
            this.passwordSignUpBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.passwordSignUpBox.Location = new System.Drawing.Point(299, 178);
            this.passwordSignUpBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordSignUpBox.MaxLength = 29;
            this.passwordSignUpBox.Name = "passwordSignUpBox";
            this.passwordSignUpBox.Size = new System.Drawing.Size(483, 32);
            this.passwordSignUpBox.TabIndex = 8;
            // 
            // CreateUserBtn
            // 
            this.CreateUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.CreateUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateUserBtn.ForeColor = System.Drawing.Color.White;
            this.CreateUserBtn.Location = new System.Drawing.Point(683, 257);
            this.CreateUserBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateUserBtn.Name = "CreateUserBtn";
            this.CreateUserBtn.Size = new System.Drawing.Size(100, 28);
            this.CreateUserBtn.TabIndex = 10;
            this.CreateUserBtn.Text = "Create User";
            this.CreateUserBtn.UseVisualStyleBackColor = false;
            this.CreateUserBtn.Click += new System.EventHandler(this.CreateUserBtn_Click);
            // 
            // NameSignUpBox
            // 
            this.NameSignUpBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.NameSignUpBox.Location = new System.Drawing.Point(300, 98);
            this.NameSignUpBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameSignUpBox.MaxLength = 29;
            this.NameSignUpBox.Name = "NameSignUpBox";
            this.NameSignUpBox.Size = new System.Drawing.Size(483, 32);
            this.NameSignUpBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(57, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Enter Name:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 346);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameSignUpBox);
            this.Controls.Add(this.CreateUserBtn);
            this.Controls.Add(this.passwordSignUpBox);
            this.Controls.Add(this.UserNameSignUpBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button MaxBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNameSignUpBox;
        private System.Windows.Forms.TextBox passwordSignUpBox;
        private System.Windows.Forms.Button CreateUserBtn;
        private System.Windows.Forms.TextBox NameSignUpBox;
        private System.Windows.Forms.Label label4;
    }
}