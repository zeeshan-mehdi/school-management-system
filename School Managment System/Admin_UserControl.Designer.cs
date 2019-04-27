namespace School_Managment_System
{
    partial class Admin_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_UserControl));
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.btnAddClass = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile4
            // 
            this.metroTile4.Location = new System.Drawing.Point(98, 239);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(154, 106);
            this.metroTile4.TabIndex = 12;
            this.metroTile4.Text = "Add Course";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile4.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile4.TileImage")));
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseTileImage = true;
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(543, 85);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(152, 105);
            this.metroTile3.TabIndex = 11;
            this.metroTile3.Text = "Add Staff";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseTileImage = true;
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(318, 88);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(157, 102);
            this.metroTile2.TabIndex = 10;
            this.metroTile2.Text = "Add Teacher";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseTileImage = true;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(98, 88);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(154, 102);
            this.btnAddClass.TabIndex = 9;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddClass.TileImage = ((System.Drawing.Image)(resources.GetObject("btnAddClass.TileImage")));
            this.btnAddClass.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddClass.UseTileImage = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(318, 239);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(157, 106);
            this.metroTile1.TabIndex = 13;
            this.metroTile1.Text = "metroTile1";
            // 
            // metroTile5
            // 
            this.metroTile5.Location = new System.Drawing.Point(543, 239);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(152, 106);
            this.metroTile5.TabIndex = 14;
            this.metroTile5.Text = "metroTile5";
            // 
            // Admin_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 431);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.btnAddClass);
            this.Name = "Admin_UserControl";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile btnAddClass;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile5;
    }
}
