namespace School_Managment_System
{
    partial class Collect_fee
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
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbclass = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAmount2 = new System.Windows.Forms.TextBox();
            this.txtremainingamount = new System.Windows.Forms.TextBox();
            this.txtamount = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtStudent = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.FlatAppearance.BorderSize = 0;
            this.materialRaisedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialRaisedButton1.ForeColor = System.Drawing.Color.White;
            this.materialRaisedButton1.Location = new System.Drawing.Point(2, 55);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "Back";
            this.materialRaisedButton1.UseVisualStyleBackColor = false;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(210, 80);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(144, 23);
            this.materialSingleLineTextField1.TabIndex = 1;
            this.materialSingleLineTextField1.Text = "Select Student";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // cbclass
            // 
            this.cbclass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbclass.FormattingEnabled = true;
            this.cbclass.Location = new System.Drawing.Point(308, 145);
            this.cbclass.Name = "cbclass";
            this.cbclass.Size = new System.Drawing.Size(121, 21);
            this.cbclass.TabIndex = 2;
            this.cbclass.SelectedIndexChanged += new System.EventHandler(this.cbclass_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(183, 145);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(47, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Class";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(175, 187);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Student:";
            // 
            // txtAmount2
            // 
            this.txtAmount2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmount2.Location = new System.Drawing.Point(308, 231);
            this.txtAmount2.Name = "txtAmount2";
            this.txtAmount2.Size = new System.Drawing.Size(121, 20);
            this.txtAmount2.TabIndex = 6;
            // 
            // txtremainingamount
            // 
            this.txtremainingamount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtremainingamount.Location = new System.Drawing.Point(308, 273);
            this.txtremainingamount.Name = "txtremainingamount";
            this.txtremainingamount.Size = new System.Drawing.Size(121, 20);
            this.txtremainingamount.TabIndex = 7;
            // 
            // txtamount
            // 
            this.txtamount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtamount.AutoSize = true;
            this.txtamount.BackColor = System.Drawing.Color.Transparent;
            this.txtamount.Depth = 0;
            this.txtamount.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtamount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtamount.Location = new System.Drawing.Point(146, 229);
            this.txtamount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(126, 19);
            this.txtamount.TabIndex = 8;
            this.txtamount.Text = "Amount Credited:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(138, 271);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(140, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Remaining Amount:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(181, 314);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(52, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Status";
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialRaisedButton2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.FlatAppearance.BorderSize = 0;
            this.materialRaisedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialRaisedButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton2.Location = new System.Drawing.Point(229, 375);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(118, 35);
            this.materialRaisedButton2.TabIndex = 12;
            this.materialRaisedButton2.Text = "Done";
            this.materialRaisedButton2.UseVisualStyleBackColor = false;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtstatus.Location = new System.Drawing.Point(308, 315);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(121, 20);
            this.txtstatus.TabIndex = 13;
            // 
            // txtStudent
            // 
            this.txtStudent.FormattingEnabled = true;
            this.txtStudent.Location = new System.Drawing.Point(308, 184);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(121, 21);
            this.txtStudent.TabIndex = 14;
            // 
            // Collect_fee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.txtremainingamount);
            this.Controls.Add(this.txtAmount2);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cbclass);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Name = "Collect_fee";
            this.Text = "Collect Fee";
            this.Load += new System.EventHandler(this.Collect_fee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.ComboBox cbclass;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TextBox txtAmount2;
        private System.Windows.Forms.TextBox txtremainingamount;
        private MaterialSkin.Controls.MaterialLabel txtamount;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.ComboBox txtStudent;
    }
}