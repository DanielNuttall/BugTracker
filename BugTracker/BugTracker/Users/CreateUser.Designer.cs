namespace BugTracker.Users
{
    partial class CreateUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Submit = new System.Windows.Forms.Button();
            this.userTypeValue = new System.Windows.Forms.TextBox();
            this.userType = new System.Windows.Forms.Label();
            this.passwordValue = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.userNameValue = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.createBugReport = new System.Windows.Forms.Button();
            this.viewBugs = new System.Windows.Forms.Button();
            this.createUsers = new System.Windows.Forms.Button();
            this.viewUsers = new System.Windows.Forms.Button();
            this.createProjects = new System.Windows.Forms.Button();
            this.viewProjects = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.userTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Submit);
            this.groupBox1.Controls.Add(this.userTypeValue);
            this.groupBox1.Controls.Add(this.userType);
            this.groupBox1.Controls.Add(this.passwordValue);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.userNameValue);
            this.groupBox1.Controls.Add(this.userName);
            this.groupBox1.Controls.Add(this.userLabel);
            this.groupBox1.Location = new System.Drawing.Point(258, 70);
            this.groupBox1.MaximumSize = new System.Drawing.Size(500, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(113, 127);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // userTypeValue
            // 
            this.userTypeValue.Location = new System.Drawing.Point(159, 102);
            this.userTypeValue.Name = "userTypeValue";
            this.userTypeValue.Size = new System.Drawing.Size(100, 20);
            this.userTypeValue.TabIndex = 6;
            // 
            // userType
            // 
            this.userType.AutoSize = true;
            this.userType.Location = new System.Drawing.Point(50, 105);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(62, 13);
            this.userType.TabIndex = 5;
            this.userType.Text = "User Type :";
            // 
            // passwordValue
            // 
            this.passwordValue.Location = new System.Drawing.Point(159, 76);
            this.passwordValue.Name = "passwordValue";
            this.passwordValue.Size = new System.Drawing.Size(100, 20);
            this.passwordValue.TabIndex = 4;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(50, 79);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(59, 13);
            this.password.TabIndex = 3;
            this.password.Text = "Password :";
            // 
            // userNameValue
            // 
            this.userNameValue.Location = new System.Drawing.Point(159, 50);
            this.userNameValue.Name = "userNameValue";
            this.userNameValue.Size = new System.Drawing.Size(100, 20);
            this.userNameValue.TabIndex = 2;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(50, 53);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(66, 13);
            this.userName.TabIndex = 1;
            this.userName.Text = "User Name :";
            // 
            // userLabel
            // 
            this.userLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Verdana", 20.25F);
            this.userLabel.Location = new System.Drawing.Point(80, 11);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(177, 32);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Create User";
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuPanel.Controls.Add(this.createBugReport);
            this.menuPanel.Controls.Add(this.viewBugs);
            this.menuPanel.Controls.Add(this.createUsers);
            this.menuPanel.Controls.Add(this.viewUsers);
            this.menuPanel.Controls.Add(this.createProjects);
            this.menuPanel.Controls.Add(this.viewProjects);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 70);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(250, 549);
            this.menuPanel.TabIndex = 4;
            // 
            // createBugReport
            // 
            this.createBugReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.createBugReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createBugReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.createBugReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBugReport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBugReport.Location = new System.Drawing.Point(3, 257);
            this.createBugReport.Name = "createBugReport";
            this.createBugReport.Size = new System.Drawing.Size(249, 44);
            this.createBugReport.TabIndex = 6;
            this.createBugReport.Text = "Create Bug Report";
            this.createBugReport.UseVisualStyleBackColor = false;
            // 
            // viewBugs
            // 
            this.viewBugs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.viewBugs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewBugs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.viewBugs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBugs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBugs.Location = new System.Drawing.Point(3, 207);
            this.viewBugs.Name = "viewBugs";
            this.viewBugs.Size = new System.Drawing.Size(249, 44);
            this.viewBugs.TabIndex = 5;
            this.viewBugs.Text = "ViewBugs";
            this.viewBugs.UseVisualStyleBackColor = false;
            // 
            // createUsers
            // 
            this.createUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.createUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.createUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUsers.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUsers.Location = new System.Drawing.Point(3, 157);
            this.createUsers.Name = "createUsers";
            this.createUsers.Size = new System.Drawing.Size(249, 44);
            this.createUsers.TabIndex = 4;
            this.createUsers.Text = "Create Users";
            this.createUsers.UseVisualStyleBackColor = false;
            // 
            // viewUsers
            // 
            this.viewUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.viewUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.viewUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewUsers.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUsers.Location = new System.Drawing.Point(3, 107);
            this.viewUsers.Name = "viewUsers";
            this.viewUsers.Size = new System.Drawing.Size(249, 44);
            this.viewUsers.TabIndex = 3;
            this.viewUsers.Text = "View Users";
            this.viewUsers.UseVisualStyleBackColor = false;
            // 
            // createProjects
            // 
            this.createProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.createProjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createProjects.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.createProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createProjects.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createProjects.Location = new System.Drawing.Point(3, 57);
            this.createProjects.Name = "createProjects";
            this.createProjects.Size = new System.Drawing.Size(249, 44);
            this.createProjects.TabIndex = 2;
            this.createProjects.Text = "Create Projects";
            this.createProjects.UseVisualStyleBackColor = false;
            // 
            // viewProjects
            // 
            this.viewProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.viewProjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewProjects.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.viewProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewProjects.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProjects.Location = new System.Drawing.Point(3, 7);
            this.viewProjects.Name = "viewProjects";
            this.viewProjects.Size = new System.Drawing.Size(249, 44);
            this.viewProjects.TabIndex = 1;
            this.viewProjects.Text = "View Projects";
            this.viewProjects.UseVisualStyleBackColor = false;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.titlePanel.Controls.Add(this.userTitle);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1188, 70);
            this.titlePanel.TabIndex = 5;
            // 
            // userTitle
            // 
            this.userTitle.AutoSize = true;
            this.userTitle.Font = new System.Drawing.Font("Verdana", 20.25F);
            this.userTitle.ForeColor = System.Drawing.Color.White;
            this.userTitle.Location = new System.Drawing.Point(12, 9);
            this.userTitle.Name = "userTitle";
            this.userTitle.Padding = new System.Windows.Forms.Padding(10);
            this.userTitle.Size = new System.Drawing.Size(392, 52);
            this.userTitle.TabIndex = 0;
            this.userTitle.Text = "Bug Tracker - Create User";
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1188, 619);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox userNameValue;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox userTypeValue;
        private System.Windows.Forms.Label userType;
        private System.Windows.Forms.TextBox passwordValue;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button createBugReport;
        private System.Windows.Forms.Button viewBugs;
        private System.Windows.Forms.Button createUsers;
        private System.Windows.Forms.Button viewUsers;
        private System.Windows.Forms.Button createProjects;
        private System.Windows.Forms.Button viewProjects;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label userTitle;
    }
}