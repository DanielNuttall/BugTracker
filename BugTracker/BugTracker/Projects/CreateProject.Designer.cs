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
            this.CreateProjectsTitle = new System.Windows.Forms.Label();
            this.projectName = new System.Windows.Forms.Label();
            this.projectNameValue = new System.Windows.Forms.TextBox();
            this.projectDesc = new System.Windows.Forms.Label();
            this.gitURLValue = new System.Windows.Forms.TextBox();
            this.gitURL = new System.Windows.Forms.Label();
            this.projectDescValue = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.createProjectGroup = new System.Windows.Forms.GroupBox();
            this.createProjectGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateProjectsTitle
            // 
            this.CreateProjectsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateProjectsTitle.AutoSize = true;
            this.CreateProjectsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateProjectsTitle.Location = new System.Drawing.Point(80, 11);
            this.CreateProjectsTitle.Name = "CreateProjectsTitle";
            this.CreateProjectsTitle.Size = new System.Drawing.Size(149, 25);
            this.CreateProjectsTitle.TabIndex = 2;
            this.CreateProjectsTitle.Text = "Create Project";
            this.CreateProjectsTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // projectNameValue
            // 
            this.projectNameValue.Location = new System.Drawing.Point(159, 50);
            this.projectNameValue.Name = "projectNameValue";
            this.projectNameValue.Size = new System.Drawing.Size(100, 20);
            this.projectNameValue.TabIndex = 4;
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
            // gitURLValue
            // 
            this.gitURLValue.Location = new System.Drawing.Point(159, 101);
            this.gitURLValue.Name = "gitURLValue";
            this.gitURLValue.Size = new System.Drawing.Size(100, 20);
            this.gitURLValue.TabIndex = 10;
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
            // projectDescValue
            // 
            this.projectDescValue.Location = new System.Drawing.Point(159, 75);
            this.projectDescValue.Name = "projectDescValue";
            this.projectDescValue.Size = new System.Drawing.Size(100, 20);
            this.projectDescValue.TabIndex = 8;
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
            this.createProjectGroup.Location = new System.Drawing.Point(108, 45);
            this.createProjectGroup.MaximumSize = new System.Drawing.Size(500, 500);
            this.createProjectGroup.Name = "createProjectGroup";
            this.createProjectGroup.Size = new System.Drawing.Size(500, 500);
            this.createProjectGroup.TabIndex = 18;
            this.createProjectGroup.TabStop = false;
            // 
            // CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 627);
            this.Controls.Add(this.createProjectGroup);
            this.Name = "CreateProject";
            this.Text = "CreateProject";
            this.createProjectGroup.ResumeLayout(false);
            this.createProjectGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CreateProjectsTitle;
        private System.Windows.Forms.Label projectName;
        private System.Windows.Forms.TextBox projectNameValue;
        private System.Windows.Forms.Label projectDesc;
        private System.Windows.Forms.TextBox gitURLValue;
        private System.Windows.Forms.Label gitURL;
        private System.Windows.Forms.TextBox projectDescValue;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.GroupBox createProjectGroup;
    }
}