namespace School_Managment_System
{
    partial class teacher_portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacher_portal));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCnic = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.coursesGrid = new System.Windows.Forms.DataGridView();
            this.lblClass = new System.Windows.Forms.Label();
            this.btnMarkAttendance = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.labelCNIC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coursesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(7, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Personal Information:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(7, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Course Information:";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblName.Location = new System.Drawing.Point(23, 141);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 18);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Name : ";
            // 
            // lblCnic
            // 
            this.lblCnic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCnic.AutoSize = true;
            this.lblCnic.BackColor = System.Drawing.Color.White;
            this.lblCnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCnic.Location = new System.Drawing.Point(28, 234);
            this.lblCnic.Name = "lblCnic";
            this.lblCnic.Size = new System.Drawing.Size(44, 18);
            this.lblCnic.TabIndex = 36;
            this.lblCnic.Text = "CNIC";
            // 
            // lblDesignation
            // 
            this.lblDesignation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.BackColor = System.Drawing.Color.White;
            this.lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDesignation.Location = new System.Drawing.Point(26, 211);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(98, 18);
            this.lblDesignation.TabIndex = 37;
            this.lblDesignation.Text = "Designation : ";
            // 
            // coursesGrid
            // 
            this.coursesGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.coursesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesGrid.Location = new System.Drawing.Point(10, 311);
            this.coursesGrid.Name = "coursesGrid";
            this.coursesGrid.Size = new System.Drawing.Size(740, 165);
            this.coursesGrid.TabIndex = 38;
            // 
            // lblClass
            // 
            this.lblClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.Color.White;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblClass.Location = new System.Drawing.Point(29, 238);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(46, 18);
            this.lblClass.TabIndex = 39;
            this.lblClass.Text = "Class";
            // 
            // btnMarkAttendance
            // 
            this.btnMarkAttendance.ActiveBorderThickness = 1;
            this.btnMarkAttendance.ActiveCornerRadius = 20;
            this.btnMarkAttendance.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnMarkAttendance.ActiveForecolor = System.Drawing.Color.White;
            this.btnMarkAttendance.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnMarkAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMarkAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMarkAttendance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMarkAttendance.BackgroundImage")));
            this.btnMarkAttendance.ButtonText = "Mark Attendance";
            this.btnMarkAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkAttendance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkAttendance.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnMarkAttendance.IdleBorderThickness = 1;
            this.btnMarkAttendance.IdleCornerRadius = 20;
            this.btnMarkAttendance.IdleFillColor = System.Drawing.Color.White;
            this.btnMarkAttendance.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnMarkAttendance.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnMarkAttendance.Location = new System.Drawing.Point(10, 543);
            this.btnMarkAttendance.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMarkAttendance.Name = "btnMarkAttendance";
            this.btnMarkAttendance.Size = new System.Drawing.Size(192, 56);
            this.btnMarkAttendance.TabIndex = 40;
            this.btnMarkAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMarkAttendance.Click += new System.EventHandler(this.btnMarkAttendance_Click);
            // 
            // button2
            // 
            this.button2.ActiveBorderThickness = 1;
            this.button2.ActiveCornerRadius = 20;
            this.button2.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button2.ActiveForecolor = System.Drawing.Color.White;
            this.button2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.ButtonText = "Assign Grades";
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SeaGreen;
            this.button2.IdleBorderThickness = 1;
            this.button2.IdleCornerRadius = 20;
            this.button2.IdleFillColor = System.Drawing.Color.White;
            this.button2.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button2.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button2.Location = new System.Drawing.Point(273, 543);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 56);
            this.button2.TabIndex = 41;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ActiveBorderThickness = 1;
            this.button1.ActiveCornerRadius = 20;
            this.button1.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button1.ActiveForecolor = System.Drawing.Color.White;
            this.button1.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ButtonText = "Log Out";
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SeaGreen;
            this.button1.IdleBorderThickness = 1;
            this.button1.IdleCornerRadius = 20;
            this.button1.IdleFillColor = System.Drawing.Color.White;
            this.button1.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button1.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button1.Location = new System.Drawing.Point(554, 543);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 56);
            this.button1.TabIndex = 42;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelCNIC
            // 
            this.labelCNIC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCNIC.AutoSize = true;
            this.labelCNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelCNIC.Location = new System.Drawing.Point(26, 176);
            this.labelCNIC.Name = "labelCNIC";
            this.labelCNIC.Size = new System.Drawing.Size(44, 18);
            this.labelCNIC.TabIndex = 43;
            this.labelCNIC.Text = "CNIC";
            // 
            // teacher_portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.labelCNIC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMarkAttendance);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.coursesGrid);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.lblCnic);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "teacher_portal";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Teacher Portal";
            this.Load += new System.EventHandler(this.teacher_portal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCnic;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.DataGridView coursesGrid;
        private System.Windows.Forms.Label lblClass;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMarkAttendance;
        private Bunifu.Framework.UI.BunifuThinButton2 button2;
        private Bunifu.Framework.UI.BunifuThinButton2 button1;
        private System.Windows.Forms.Label labelCNIC;
    }
}