namespace School_Managment_System
{
    partial class statistics_userControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statistics_userControl));
            this.studentsProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.teachersProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentsProgress
            // 
            this.studentsProgress.animated = false;
            this.studentsProgress.animationIterval = 5;
            this.studentsProgress.animationSpeed = 300;
            this.studentsProgress.BackColor = System.Drawing.Color.White;
            this.studentsProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("studentsProgress.BackgroundImage")));
            this.studentsProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.studentsProgress.ForeColor = System.Drawing.Color.SeaGreen;
            this.studentsProgress.LabelVisible = true;
            this.studentsProgress.LineProgressThickness = 8;
            this.studentsProgress.LineThickness = 5;
            this.studentsProgress.Location = new System.Drawing.Point(24, 38);
            this.studentsProgress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.studentsProgress.MaxValue = 100;
            this.studentsProgress.Name = "studentsProgress";
            this.studentsProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.studentsProgress.ProgressColor = System.Drawing.Color.SeaGreen;
            this.studentsProgress.Size = new System.Drawing.Size(201, 201);
            this.studentsProgress.TabIndex = 0;
            this.studentsProgress.Value = 0;
            // 
            // teachersProgress
            // 
            this.teachersProgress.animated = false;
            this.teachersProgress.animationIterval = 5;
            this.teachersProgress.animationSpeed = 300;
            this.teachersProgress.BackColor = System.Drawing.Color.White;
            this.teachersProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teachersProgress.BackgroundImage")));
            this.teachersProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.teachersProgress.ForeColor = System.Drawing.Color.SeaGreen;
            this.teachersProgress.LabelVisible = true;
            this.teachersProgress.LineProgressThickness = 8;
            this.teachersProgress.LineThickness = 5;
            this.teachersProgress.Location = new System.Drawing.Point(292, 38);
            this.teachersProgress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.teachersProgress.MaxValue = 100;
            this.teachersProgress.Name = "teachersProgress";
            this.teachersProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.teachersProgress.ProgressColor = System.Drawing.Color.SeaGreen;
            this.teachersProgress.Size = new System.Drawing.Size(192, 192);
            this.teachersProgress.TabIndex = 1;
            this.teachersProgress.Value = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(318, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "# of Teachers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(60, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "# of Students";
            // 
            // statistics_userControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teachersProgress);
            this.Controls.Add(this.studentsProgress);
            this.Name = "statistics_userControl";
            this.Size = new System.Drawing.Size(528, 363);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar studentsProgress;
        private Bunifu.Framework.UI.BunifuCircleProgressbar teachersProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
