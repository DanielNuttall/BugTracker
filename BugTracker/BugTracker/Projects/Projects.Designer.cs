namespace BugTracker.Projects
{
    partial class Projects
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projects));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pSelectedUserValue = new System.Windows.Forms.TextBox();
            this.pSelectedUser = new System.Windows.Forms.Label();
            this.pSelectedValue = new System.Windows.Forms.TextBox();
            this.projectSelectedValue = new System.Windows.Forms.Label();
            this.addUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userTitle = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.projectDesc = new System.Windows.Forms.Label();
            this.projectDescValue = new System.Windows.Forms.TextBox();
            this.projectNameValue = new System.Windows.Forms.TextBox();
            this.createProject = new System.Windows.Forms.Button();
            this.projectName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(712, 589);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 805);
            this.panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.Location = new System.Drawing.Point(12, 598);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(703, 184);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Help/Instructions";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(691, 160);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1195, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 805);
            this.panel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pSelectedUserValue);
            this.groupBox2.Controls.Add(this.pSelectedUser);
            this.groupBox2.Controls.Add(this.pSelectedValue);
            this.groupBox2.Controls.Add(this.projectSelectedValue);
            this.groupBox2.Controls.Add(this.addUser);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.shapeContainer1);
            this.groupBox2.Location = new System.Drawing.Point(3, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 234);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add user to selected project form";
            // 
            // pSelectedUserValue
            // 
            this.pSelectedUserValue.Location = new System.Drawing.Point(147, 84);
            this.pSelectedUserValue.Name = "pSelectedUserValue";
            this.pSelectedUserValue.Size = new System.Drawing.Size(100, 20);
            this.pSelectedUserValue.TabIndex = 19;
            // 
            // pSelectedUser
            // 
            this.pSelectedUser.AutoSize = true;
            this.pSelectedUser.Location = new System.Drawing.Point(28, 87);
            this.pSelectedUser.Name = "pSelectedUser";
            this.pSelectedUser.Size = new System.Drawing.Size(63, 13);
            this.pSelectedUser.TabIndex = 18;
            this.pSelectedUser.Text = "UserName :";
            // 
            // pSelectedValue
            // 
            this.pSelectedValue.Location = new System.Drawing.Point(147, 58);
            this.pSelectedValue.Name = "pSelectedValue";
            this.pSelectedValue.ReadOnly = true;
            this.pSelectedValue.Size = new System.Drawing.Size(100, 20);
            this.pSelectedValue.TabIndex = 17;
            // 
            // projectSelectedValue
            // 
            this.projectSelectedValue.AutoSize = true;
            this.projectSelectedValue.Location = new System.Drawing.Point(28, 61);
            this.projectSelectedValue.Name = "projectSelectedValue";
            this.projectSelectedValue.Size = new System.Drawing.Size(77, 13);
            this.projectSelectedValue.TabIndex = 16;
            this.projectSelectedValue.Text = "Project Name :";
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(227)))));
            this.addUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(227)))));
            this.addUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addUser.Location = new System.Drawing.Point(31, 124);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(216, 23);
            this.addUser.TabIndex = 15;
            this.addUser.Text = "Add User to Project";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Add User";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape5,
            this.lineShape6});
            this.shapeContainer1.Size = new System.Drawing.Size(353, 215);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape4.Name = "lineShape3";
            this.lineShape4.X1 = 15;
            this.lineShape4.X2 = 311;
            this.lineShape4.Y1 = 91;
            this.lineShape4.Y2 = 91;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape5.Name = "lineShape2";
            this.lineShape5.X1 = 14;
            this.lineShape5.X2 = 310;
            this.lineShape5.Y1 = 64;
            this.lineShape5.Y2 = 64;
            // 
            // lineShape6
            // 
            this.lineShape6.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape6.Name = "lineShape1";
            this.lineShape6.X1 = 14;
            this.lineShape6.X2 = 310;
            this.lineShape6.Y1 = 38;
            this.lineShape6.Y2 = 38;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.titlePanel.Controls.Add(this.pictureBox1);
            this.titlePanel.Controls.Add(this.userTitle);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1195, 56);
            this.titlePanel.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 51);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // userTitle
            // 
            this.userTitle.AutoSize = true;
            this.userTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTitle.ForeColor = System.Drawing.Color.White;
            this.userTitle.Location = new System.Drawing.Point(70, 4);
            this.userTitle.Name = "userTitle";
            this.userTitle.Padding = new System.Windows.Forms.Padding(10);
            this.userTitle.Size = new System.Drawing.Size(406, 45);
            this.userTitle.TabIndex = 0;
            this.userTitle.Text = "Bug Tracker - Projects/Repositories";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(353, 215);
            this.shapeContainer2.TabIndex = 14;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 15;
            this.lineShape3.X2 = 311;
            this.lineShape3.Y1 = 91;
            this.lineShape3.Y2 = 91;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 14;
            this.lineShape2.X2 = 310;
            this.lineShape2.Y1 = 64;
            this.lineShape2.Y2 = 64;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 14;
            this.lineShape1.X2 = 310;
            this.lineShape1.Y1 = 38;
            this.lineShape1.Y2 = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Create Project";
            // 
            // projectDesc
            // 
            this.projectDesc.AutoSize = true;
            this.projectDesc.Location = new System.Drawing.Point(28, 87);
            this.projectDesc.Name = "projectDesc";
            this.projectDesc.Size = new System.Drawing.Size(102, 13);
            this.projectDesc.TabIndex = 11;
            this.projectDesc.Text = "Project Description :";
            // 
            // projectDescValue
            // 
            this.projectDescValue.Location = new System.Drawing.Point(147, 84);
            this.projectDescValue.Name = "projectDescValue";
            this.projectDescValue.Size = new System.Drawing.Size(100, 20);
            this.projectDescValue.TabIndex = 1;
            // 
            // projectNameValue
            // 
            this.projectNameValue.Location = new System.Drawing.Point(147, 58);
            this.projectNameValue.Name = "projectNameValue";
            this.projectNameValue.Size = new System.Drawing.Size(100, 20);
            this.projectNameValue.TabIndex = 0;
            // 
            // createProject
            // 
            this.createProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(227)))));
            this.createProject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(227)))));
            this.createProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createProject.Location = new System.Drawing.Point(31, 123);
            this.createProject.Name = "createProject";
            this.createProject.Size = new System.Drawing.Size(216, 23);
            this.createProject.TabIndex = 15;
            this.createProject.Text = "Create New Project";
            this.createProject.UseVisualStyleBackColor = false;
            this.createProject.Click += new System.EventHandler(this.createProject_Click);
            // 
            // projectName
            // 
            this.projectName.AutoSize = true;
            this.projectName.Location = new System.Drawing.Point(28, 61);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(77, 13);
            this.projectName.TabIndex = 10;
            this.projectName.Text = "Project Name :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(721, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 799);
            this.panel3.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.projectName);
            this.groupBox1.Controls.Add(this.createProject);
            this.groupBox1.Controls.Add(this.projectNameValue);
            this.groupBox1.Controls.Add(this.projectDescValue);
            this.groupBox1.Controls.Add(this.projectDesc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.shapeContainer2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 234);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new project form";
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1195, 861);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titlePanel);
            this.Name = "Projects";
            this.Text = "Projects";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox pSelectedUserValue;
        private System.Windows.Forms.Label pSelectedUser;
        private System.Windows.Forms.TextBox pSelectedValue;
        private System.Windows.Forms.Label projectSelectedValue;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label userTitle;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label projectDesc;
        private System.Windows.Forms.TextBox projectDescValue;
        private System.Windows.Forms.TextBox projectNameValue;
        private System.Windows.Forms.Button createProject;
        private System.Windows.Forms.Label projectName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}