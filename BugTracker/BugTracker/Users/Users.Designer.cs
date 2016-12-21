namespace BugTracker.Users
{
    partial class Users
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
            this.userTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.viewProjects = new System.Windows.Forms.Button();
            this.createProjects = new System.Windows.Forms.Button();
            this.viewUsers = new System.Windows.Forms.Button();
            this.createUsers = new System.Windows.Forms.Button();
            this.viewBugs = new System.Windows.Forms.Button();
            this.createBugReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userTitle
            // 
            this.userTitle.AutoSize = true;
            this.userTitle.Font = new System.Drawing.Font("Verdana", 20.25F);
            this.userTitle.ForeColor = System.Drawing.Color.White;
            this.userTitle.Location = new System.Drawing.Point(12, 9);
            this.userTitle.Name = "userTitle";
            this.userTitle.Padding = new System.Windows.Forms.Padding(10);
            this.userTitle.Size = new System.Drawing.Size(306, 52);
            this.userTitle.TabIndex = 0;
            this.userTitle.Text = "Bug Tracker - Users";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(258, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(825, 314);
            this.dataGridView1.TabIndex = 1;
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
            this.menuPanel.TabIndex = 2;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.titlePanel.Controls.Add(this.userTitle);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1188, 70);
            this.titlePanel.TabIndex = 3;
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
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1188, 619);
            this.ControlBox = false;
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.titlePanel);
            this.Name = "Users";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label userTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button createBugReport;
        private System.Windows.Forms.Button viewBugs;
        private System.Windows.Forms.Button createUsers;
        private System.Windows.Forms.Button viewUsers;
        private System.Windows.Forms.Button createProjects;
        private System.Windows.Forms.Button viewProjects;
    }
}