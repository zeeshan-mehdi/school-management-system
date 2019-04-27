namespace School_Managment_System
{
    partial class Student_portal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_portal));
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.coursesGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentEmail = new System.Windows.Forms.Label();
            this.lblEnrolledIn = new System.Windows.Forms.Label();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.gradesGrid = new System.Windows.Forms.DataGridView();
            this.btnLgout = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.coursesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialDivider1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(14, 66);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(776, 141);
            this.materialDivider1.TabIndex = 0;
            this.materialDivider1.Text = "materialDivider1";
            this.materialDivider1.Click += new System.EventHandler(this.materialDivider1_Click);
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // materialDivider3
            // 
            this.materialDivider3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialDivider3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialDivider3.Location = new System.Drawing.Point(12, 440);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(776, 336);
            this.materialDivider3.TabIndex = 9;
            this.materialDivider3.Click += new System.EventHandler(this.materialDivider3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(27, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Personal Information:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(27, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Grades:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(27, 440);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Academic Information:";
            // 
            // coursesGrid
            // 
            this.coursesGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.coursesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesGrid.Location = new System.Drawing.Point(30, 473);
            this.coursesGrid.Name = "coursesGrid";
            this.coursesGrid.Size = new System.Drawing.Size(742, 228);
            this.coursesGrid.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(41, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Name :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(44, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "CNIC";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(41, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "enrolled In";
            // 
            // lblStudentName
            // 
            this.lblStudentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(196, 108);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(0, 13);
            this.lblStudentName.TabIndex = 23;
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.Location = new System.Drawing.Point(199, 141);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(0, 13);
            this.lblStudentEmail.TabIndex = 24;
            // 
            // lblEnrolledIn
            // 
            this.lblEnrolledIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnrolledIn.AutoSize = true;
            this.lblEnrolledIn.Location = new System.Drawing.Point(199, 180);
            this.lblEnrolledIn.Name = "lblEnrolledIn";
            this.lblEnrolledIn.Size = new System.Drawing.Size(0, 13);
            this.lblEnrolledIn.TabIndex = 25;
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialDivider2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.materialDivider2.Location = new System.Drawing.Point(14, 213);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(776, 196);
            this.materialDivider2.TabIndex = 6;
            this.materialDivider2.Click += new System.EventHandler(this.materialDivider2_Click);
            // 
            // gradesGrid
            // 
            this.gradesGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gradesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradesGrid.Location = new System.Drawing.Point(30, 253);
            this.gradesGrid.Name = "gradesGrid";
            this.gradesGrid.Size = new System.Drawing.Size(742, 150);
            this.gradesGrid.TabIndex = 26;
            // 
            // btnLgout
            // 
            this.btnLgout.ActiveBorderThickness = 1;
            this.btnLgout.ActiveCornerRadius = 20;
            this.btnLgout.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLgout.ActiveForecolor = System.Drawing.Color.White;
            this.btnLgout.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLgout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLgout.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLgout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLgout.BackgroundImage")));
            this.btnLgout.ButtonText = "Logout";
            this.btnLgout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLgout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLgout.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLgout.IdleBorderThickness = 1;
            this.btnLgout.IdleCornerRadius = 20;
            this.btnLgout.IdleFillColor = System.Drawing.Color.White;
            this.btnLgout.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLgout.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLgout.Location = new System.Drawing.Point(585, 709);
            this.btnLgout.Margin = new System.Windows.Forms.Padding(5);
            this.btnLgout.Name = "btnLgout";
            this.btnLgout.Size = new System.Drawing.Size(187, 45);
            this.btnLgout.TabIndex = 27;
            this.btnLgout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLgout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Student_portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 788);
            this.Controls.Add(this.btnLgout);
            this.Controls.Add(this.gradesGrid);
            this.Controls.Add(this.lblEnrolledIn);
            this.Controls.Add(this.lblStudentEmail);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.coursesGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialDivider3);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider1);
            this.Name = "Student_portal";
            this.ShowIcon = false;
            this.Text = "Student Portal";
            this.Load += new System.EventHandler(this.Student_portal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView coursesGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentEmail;
        private System.Windows.Forms.Label lblEnrolledIn;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.DataGridView gradesGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLgout;
    }
}