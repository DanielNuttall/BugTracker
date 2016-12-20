namespace BugTracker
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBugsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectsToolStripMenuItem1,
            this.openBugsToolStripMenuItem1});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // projectsToolStripMenuItem1
            // 
            this.projectsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProjectsToolStripMenuItem,
            this.createProjectsToolStripMenuItem});
            this.projectsToolStripMenuItem1.Name = "projectsToolStripMenuItem1";
            this.projectsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.projectsToolStripMenuItem1.Text = "Projects";
            // 
            // viewProjectsToolStripMenuItem
            // 
            this.viewProjectsToolStripMenuItem.Name = "viewProjectsToolStripMenuItem";
            this.viewProjectsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.viewProjectsToolStripMenuItem.Text = "View Projects";
            this.viewProjectsToolStripMenuItem.Click += new System.EventHandler(this.viewProjectsToolStripMenuItem_Click);
            // 
            // createProjectsToolStripMenuItem
            // 
            this.createProjectsToolStripMenuItem.Name = "createProjectsToolStripMenuItem";
            this.createProjectsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.createProjectsToolStripMenuItem.Text = "Create Projects";
            this.createProjectsToolStripMenuItem.Click += new System.EventHandler(this.createProjectsToolStripMenuItem_Click);
            // 
            // openBugsToolStripMenuItem1
            // 
            this.openBugsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBugsToolStripMenuItem,
            this.createBugsToolStripMenuItem});
            this.openBugsToolStripMenuItem1.Name = "openBugsToolStripMenuItem1";
            this.openBugsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.openBugsToolStripMenuItem1.Text = "OpenBugs";
            // 
            // viewBugsToolStripMenuItem
            // 
            this.viewBugsToolStripMenuItem.Name = "viewBugsToolStripMenuItem";
            this.viewBugsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.viewBugsToolStripMenuItem.Text = "View bugs";
            // 
            // createBugsToolStripMenuItem
            // 
            this.createBugsToolStripMenuItem.Name = "createBugsToolStripMenuItem";
            this.createBugsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.createBugsToolStripMenuItem.Text = "Create bugs";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem,
            this.listUsersToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.createUserToolStripMenuItem.Text = "Create User";
            // 
            // listUsersToolStripMenuItem
            // 
            this.listUsersToolStripMenuItem.Name = "listUsersToolStripMenuItem";
            this.listUsersToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.listUsersToolStripMenuItem.Text = "List Users";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            this.toolStripStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBugsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewBugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listUsersToolStripMenuItem;
    }
}



