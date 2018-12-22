namespace Project
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MaxBtn = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.MaxBtn);
            this.panel1.Controls.Add(this.MinBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 55);
            this.panel1.TabIndex = 0;
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(799, 0);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(53, 55);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MaxBtn
            // 
            this.MaxBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MaxBtn.BackgroundImage")));
            this.MaxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MaxBtn.FlatAppearance.BorderSize = 0;
            this.MaxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxBtn.ForeColor = System.Drawing.Color.White;
            this.MaxBtn.Location = new System.Drawing.Point(737, 2);
            this.MaxBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxBtn.Name = "MaxBtn";
            this.MaxBtn.Size = new System.Drawing.Size(63, 49);
            this.MaxBtn.TabIndex = 9;
            this.MaxBtn.UseVisualStyleBackColor = true;
            this.MaxBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            // 
            // MinBtn
            // 
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBtn.ForeColor = System.Drawing.Color.White;
            this.MinBtn.Location = new System.Drawing.Point(676, 2);
            this.MinBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(63, 49);
            this.MinBtn.TabIndex = 8;
            this.MinBtn.Text = "-";
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Screen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(80, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(80, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.UserNameBox.Location = new System.Drawing.Point(255, 101);
            this.UserNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(483, 32);
            this.UserNameBox.TabIndex = 6;
            this.UserNameBox.TextChanged += new System.EventHandler(this.UserNameBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PasswordBox.Location = new System.Drawing.Point(255, 161);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordBox.MaxLength = 29;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(483, 32);
            this.PasswordBox.TabIndex = 7;
            // 
            // LogInBtn
            // 
            this.LogInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInBtn.Location = new System.Drawing.Point(483, 250);
            this.LogInBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(100, 28);
            this.LogInBtn.TabIndex = 8;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.SignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpBtn.ForeColor = System.Drawing.Color.White;
            this.SignUpBtn.Location = new System.Drawing.Point(639, 250);
            this.SignUpBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(100, 28);
            this.SignUpBtn.TabIndex = 9;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 346);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Button MaxBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Button SignUpBtn;
    }
}