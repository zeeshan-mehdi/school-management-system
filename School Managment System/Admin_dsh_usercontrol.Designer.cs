namespace School_Managment_System
{
    partial class Admin_dsh_usercontrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_dsh_usercontrol));
            this.btnAddCourse = new MetroFramework.Controls.MetroTile();
            this.btnAddStaff = new MetroFramework.Controls.MetroTile();
            this.btnAddTeacher = new MetroFramework.Controls.MetroTile();
            this.btnAddClass = new MetroFramework.Controls.MetroTile();
            this.btnTeachersList = new MetroFramework.Controls.MetroTile();
            this.btnStudentsList = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(14, 212);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(154, 106);
            this.btnAddCourse.TabIndex = 16;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCourse.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddCourse.TileImage")));
            this.btnAddCourse.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCourse.UseTileImage = true;
            this.btnAddCourse.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(402, 61);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(152, 105);
            this.btnAddStaff.TabIndex = 15;
            this.btnAddStaff.Text = "View Applications";
            this.btnAddStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddStaff.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddStaff.TileImage")));
            this.btnAddStaff.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddStaff.UseTileImage = true;
            this.btnAddStaff.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(207, 61);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(157, 102);
            this.btnAddTeacher.TabIndex = 14;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddTeacher.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddTeacher.TileImage")));
            this.btnAddTeacher.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddTeacher.UseTileImage = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(14, 61);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(154, 102);
            this.btnAddClass.TabIndex = 13;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddClass.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddClass.TileImage")));
            this.btnAddClass.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddClass.UseTileImage = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnTeachersList
            // 
            this.btnTeachersList.Location = new System.Drawing.Point(402, 212);
            this.btnTeachersList.Name = "btnTeachersList";
            this.btnTeachersList.Size = new System.Drawing.Size(152, 106);
            this.btnTeachersList.TabIndex = 18;
            this.btnTeachersList.Text = "teachers";
            this.btnTeachersList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeachersList.TileImage = ((System.Drawing.Image)(resources.GetObject("btnTeachersList.TileImage")));
            this.btnTeachersList.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTeachersList.UseTileImage = true;
            this.btnTeachersList.Click += new System.EventHandler(this.btnTeachersList_Click);
            // 
            // btnStudentsList
            // 
            this.btnStudentsList.Location = new System.Drawing.Point(207, 212);
            this.btnStudentsList.Name = "btnStudentsList";
            this.btnStudentsList.Size = new System.Drawing.Size(157, 106);
            this.btnStudentsList.TabIndex = 17;
            this.btnStudentsList.Text = "students list";
            this.btnStudentsList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudentsList.TileImage = ((System.Drawing.Image)(resources.GetObject("btnStudentsList.TileImage")));
            this.btnStudentsList.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStudentsList.UseTileImage = true;
            this.btnStudentsList.Click += new System.EventHandler(this.btnStudentsList_Click);
            // 
            // Admin_dsh_usercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTeachersList);
            this.Controls.Add(this.btnStudentsList);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.btnAddClass);
            this.Name = "Admin_dsh_usercontrol";
            this.Size = new System.Drawing.Size(570, 376);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnAddCourse;
        private MetroFramework.Controls.MetroTile btnAddStaff;
        private MetroFramework.Controls.MetroTile btnAddTeacher;
        private MetroFramework.Controls.MetroTile btnAddClass;
        private MetroFramework.Controls.MetroTile btnTeachersList;
        private MetroFramework.Controls.MetroTile btnStudentsList;

    }
}
