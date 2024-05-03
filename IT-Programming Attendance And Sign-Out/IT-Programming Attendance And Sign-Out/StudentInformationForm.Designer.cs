namespace IT_Programming_Attendance_And_Sign_Out
{
    partial class frmStudentInformationForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.cmbSchools = new System.Windows.Forms.ComboBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lblFirstNameError = new System.Windows.Forms.Label();
            this.lblLastNameError = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1920, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.addStudentToolStripMenuItem.Text = "Return Home";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtFName
            // 
            this.txtFName.AcceptsTab = true;
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFName.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(91, 410);
            this.txtFName.Multiline = true;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(740, 92);
            this.txtFName.TabIndex = 3;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // txtLName
            // 
            this.txtLName.AcceptsTab = true;
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLName.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(1081, 410);
            this.txtLName.Multiline = true;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(739, 92);
            this.txtLName.TabIndex = 4;
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            // 
            // cmbGrade
            // 
            this.cmbGrade.BackColor = System.Drawing.SystemColors.Info;
            this.cmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrade.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.ItemHeight = 59;
            this.cmbGrade.Items.AddRange(new object[] {
            "Choose A Grade",
            "9",
            "10",
            "11",
            "12"});
            this.cmbGrade.Location = new System.Drawing.Point(208, 737);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(513, 67);
            this.cmbGrade.TabIndex = 5;
            // 
            // cmbSchools
            // 
            this.cmbSchools.BackColor = System.Drawing.SystemColors.Info;
            this.cmbSchools.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchools.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSchools.FormattingEnabled = true;
            this.cmbSchools.ItemHeight = 59;
            this.cmbSchools.Items.AddRange(new object[] {
            "Choose A School",
            "Boyertown",
            "Daniel Boone",
            "Schuylkill Valley",
            "Exeter",
            "Hamburg",
            "Brandywine"});
            this.cmbSchools.Location = new System.Drawing.Point(1197, 747);
            this.cmbSchools.Name = "cmbSchools";
            this.cmbSchools.Size = new System.Drawing.Size(519, 67);
            this.cmbSchools.TabIndex = 6;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(778, 898);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(364, 104);
            this.btnAddStudent.TabIndex = 7;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lblFirstNameError
            // 
            this.lblFirstNameError.AutoSize = true;
            this.lblFirstNameError.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstNameError.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameError.ForeColor = System.Drawing.Color.Red;
            this.lblFirstNameError.Location = new System.Drawing.Point(87, 505);
            this.lblFirstNameError.Name = "lblFirstNameError";
            this.lblFirstNameError.Size = new System.Drawing.Size(305, 23);
            this.lblFirstNameError.TabIndex = 8;
            this.lblFirstNameError.Text = "(Please Enter Your First Name)";
            this.lblFirstNameError.Visible = false;
            // 
            // lblLastNameError
            // 
            this.lblLastNameError.AutoSize = true;
            this.lblLastNameError.BackColor = System.Drawing.Color.Transparent;
            this.lblLastNameError.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameError.ForeColor = System.Drawing.Color.Red;
            this.lblLastNameError.Location = new System.Drawing.Point(1077, 505);
            this.lblLastNameError.Name = "lblLastNameError";
            this.lblLastNameError.Size = new System.Drawing.Size(300, 23);
            this.lblLastNameError.TabIndex = 9;
            this.lblLastNameError.Text = "(Please Enter Your Last Name)";
            this.lblLastNameError.Visible = false;
            // 
            // frmStudentInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IT_Programming_Attendance_And_Sign_Out.Properties.Resources.AM_Background_Finished1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lblLastNameError);
            this.Controls.Add(this.lblFirstNameError);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.cmbSchools);
            this.Controls.Add(this.cmbGrade);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStudentInformationForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.ComboBox cmbSchools;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblFirstNameError;
        private System.Windows.Forms.Label lblLastNameError;
    }
}