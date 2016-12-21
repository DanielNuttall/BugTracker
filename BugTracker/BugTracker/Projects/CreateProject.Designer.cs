namespace BugTracker.Projects
{
    partial class CreateProject
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
            this.createProjectGroup = new System.Windows.Forms.GroupBox();
            this.CreateProjectsTitle = new System.Windows.Forms.Label();
            this.projectNameValue = new System.Windows.Forms.TextBox();
            this.projectDescValue = new System.Windows.Forms.TextBox();
            this.gitURLValue = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.projectName = new System.Windows.Forms.Label();
            this.projectDesc = new System.Windows.Forms.Label();
            this.gitURL = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.createBugReport = new System.Windows.Forms.Button();
            this.viewBugs = new System.Windows.Forms.Button();
            this.createUsers = new System.Windows.Forms.Button();
            this.viewUsers = new System.Windows.Forms.Button();
            this.createProjects = new System.Windows.Forms.Button();
            this.viewProjects = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.userTitle = new System.Windows.Forms.Label();
            this.createProjectGroup.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createProjectGroup
            // 
            this.createProjectGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createProjectGroup.Controls.Add(this.Submit);
            this.createProjectGroup.Controls.Add(this.gitURLValue);
            this.createProjectGroup.Controls.Add(this.gitURL);
            this.createProjectGroup.Controls.Add(this.projectDescValue);
            this.createProjectGroup.Controls.Add(this.projectDesc);
            this.createProjectGroup.Controls.Add(this.projectNameValue);
            this.createProjectGroup.Controls.Add(this.projectName);
            this.createProjectGroup.Controls.Add(this.CreateProjectsTitle);
            this.createProjectGroup.Location = new System.Drawing.Point(258, 70);
            this.createProjectGroup.MaximumSize = new System.Drawing.Size(500, 500);
            this.createProjectGroup.Name = "createProjectGroup";
            this.createProjectGroup.Size = new System.Drawing.Size(500, 492);
            this.createProjectGroup.TabIndex = 18;
            this.createProjectGroup.TabStop = false;
            // 
            // CreateProjectsTitle
            // 
            this.CreateProjectsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateProjectsTitle.AutoSize = true;
            this.CreateProjectsTitle.Font = new System.Drawing.Font("Verdana", 20.25F);
            this.CreateProjectsTitle.Location = new System.Drawing.Point(80, 11);
            this.CreateProjectsTitle.Name = "CreateProjectsTitle";
            this.CreateProjectsTitle.Size = new System.Drawing.Size(209, 32);
            this.CreateProjectsTitle.TabIndex = 2;
            this.CreateProjectsTitle.Text = "Create Project";
            this.CreateProjectsTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // projectNameValue
            // 
            this.projectNameValue.Location = new System.Drawing.Point(159, 50);
            this.projectNameValue.Name = "projectNameValue";
            this.projectNameValue.Size = new System.Drawing.Size(100, 20);
            this.projectNameValue.TabIndex = 4;
            // 
            // projectDescValue
            // 
            this.projectDescValue.Location = new System.Drawing.Point(159, 75);
            this.projectDescValue.Name = "projectDescValue";
            this.projectDescValue.Size = new System.Drawing.Size(100, 20);
            this.projectDescValue.TabIndex = 8;
            // 
            // gitURLValue
            // 
            this.gitURLValue.Location = new System.Drawing.Point(159, 101);
            this.gitURLValue.Name = "gitURLValue";
            this.gitURLValue.Size = new System.Drawing.Size(100, 20);
            this.gitURLValue.TabIndex = 10;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(113, 127);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 15;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.Location = new System.Drawing.Point(50, 53);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(77, 13);
            this.projectName.TabIndex = 3;
            this.projectName.Text = "Project Name :";
            // 
            // projectDesc
            // 
            this.projectDesc.AutoSize = true;
            this.projectDesc.Location = new System.Drawing.Point(50, 78);
            this.projectDesc.Name = "projectDesc";
            this.projectDesc.Size = new System.Drawing.Size(102, 13);
            this.projectDesc.TabIndex = 7;
            this.projectDesc.Text = "Project Description :";
            // 
            // gitURL
            // 
            this.gitURL.AutoSize = true;
            this.gitURL.Location = new System.Drawing.Point(50, 104);
            this.gitURL.Name = "gitURL";
            this.gitURL.Size = new System.Drawing.Size(51, 13);
            this.gitURL.TabIndex = 9;
            this.gitURL.Text = "Git URL :";
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
            this.menuPanel.TabIndex = 19;
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
            this.titlePanel.TabIndex = 20;
            // 
            // userTitle
            // 
            this.userTitle.AutoSize = true;
            this.userTitle.Font = new System.Drawing.Font("Verdana", 20.25F);
            this.userTitle.ForeColor = System.Drawing.Color.White;
            this.userTitle.Location = new System.Drawing.Point(12, 9);
            this.userTitle.Name = "userTitle";
            this.userTitle.Padding = new System.Windows.Forms.Padding(10);
            this.userTitle.Size = new System.Drawing.Size(424, 52);
            this.userTitle.TabIndex = 0;
            this.userTitle.Text = "Bug Tracker - Create Project";
            // 
            // CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1188, 619);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.createProjectGroup);
            this.Name = "CreateProject";
            this.Text = "CreateProject";
            this.createProjectGroup.ResumeLayout(false);
            this.createProjectGroup.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox createProjectGroup;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox gitURLValue;
        private System.Windows.Forms.Label gitURL;
        private System.Windows.Forms.TextBox projectDescValue;
        private System.Windows.Forms.Label projectDesc;
        private System.Windows.Forms.TextBox projectNameValue;
        private System.Windows.Forms.Label projectName;
        private System.Windows.Forms.Label CreateProjectsTitle;
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