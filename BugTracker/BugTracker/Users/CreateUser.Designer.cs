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
            this.userLabel = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.userNameValue = new System.Windows.Forms.TextBox();
            this.passwordValue = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.userTypeValue = new System.Windows.Forms.TextBox();
            this.userType = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(108, 45);
            this.groupBox1.MaximumSize = new System.Drawing.Size(500, 500);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // userLabel
            // 
            this.userLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.userLabel.Location = new System.Drawing.Point(80, 11);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(127, 25);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Create User";
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
            // userNameValue
            // 
            this.userNameValue.Location = new System.Drawing.Point(159, 50);
            this.userNameValue.Name = "userNameValue";
            this.userNameValue.Size = new System.Drawing.Size(100, 20);
            this.userNameValue.TabIndex = 2;
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
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 627);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}