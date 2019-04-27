namespace School_Managment_System
{
    partial class teacher_loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacher_loginform));
            this.forgotpassword = new System.Windows.Forms.LinkLabel();
            this.login = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.staff_id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCnic_ = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // forgotpassword
            // 
            this.forgotpassword.AutoSize = true;
            this.forgotpassword.BackColor = System.Drawing.Color.Transparent;
            this.forgotpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotpassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.forgotpassword.Location = new System.Drawing.Point(333, 371);
            this.forgotpassword.Name = "forgotpassword";
            this.forgotpassword.Size = new System.Drawing.Size(138, 20);
            this.forgotpassword.TabIndex = 24;
            this.forgotpassword.TabStop = true;
            this.forgotpassword.Text = "Forgot Password?";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.Info;
            this.login.Location = new System.Drawing.Point(276, 306);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(245, 40);
            this.login.TabIndex = 23;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(247, 232);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(373, 20);
            this.txtPassword.TabIndex = 22;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(106, 232);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(114, 26);
            this.password.TabIndex = 21;
            this.password.Text = "Password:";
            // 
            // staff_id
            // 
            this.staff_id.AutoSize = true;
            this.staff_id.BackColor = System.Drawing.Color.Transparent;
            this.staff_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_id.Location = new System.Drawing.Point(106, 172);
            this.staff_id.Name = "staff_id";
            this.staff_id.Size = new System.Drawing.Size(72, 26);
            this.staff_id.TabIndex = 19;
            this.staff_id.Text = "CNIC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 36);
            this.label3.TabIndex = 30;
            this.label3.Text = "Teacher Account Login";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(0, 64);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 31);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.txtCnic_);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.staff_id);
            this.panel1.Controls.Add(this.forgotpassword);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Location = new System.Drawing.Point(368, 260);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 405);
            this.panel1.TabIndex = 32;
            // 
            // txtCnic_
            // 
            this.txtCnic_.Location = new System.Drawing.Point(247, 172);
            this.txtCnic_.Mask = "00000-0000000-0";
            this.txtCnic_.Name = "txtCnic_";
            this.txtCnic_.Size = new System.Drawing.Size(373, 20);
            this.txtCnic_.TabIndex = 31;
            // 
            // teacher_loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Name = "teacher_loginform";
            this.ShowIcon = false;
            this.Text = "Teacher Login";
            this.Load += new System.EventHandler(this.teacher_loginform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel forgotpassword;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label staff_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtCnic_;
    }
}