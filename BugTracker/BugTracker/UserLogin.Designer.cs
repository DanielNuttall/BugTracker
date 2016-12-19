namespace BugTracker
{
    partial class UserLogin
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
            this.Pass_Text = new System.Windows.Forms.TextBox();
            this.User_Text = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pass_Text
            // 
            this.Pass_Text.Location = new System.Drawing.Point(193, 60);
            this.Pass_Text.Name = "Pass_Text";
            this.Pass_Text.Size = new System.Drawing.Size(168, 20);
            this.Pass_Text.TabIndex = 0;
            // 
            // User_Text
            // 
            this.User_Text.Location = new System.Drawing.Point(193, 34);
            this.User_Text.Name = "User_Text";
            this.User_Text.Size = new System.Drawing.Size(168, 20);
            this.User_Text.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(129, 96);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(264, 96);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(126, 34);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(61, 13);
            this.Username.TabIndex = 4;
            this.Username.Text = "Username :";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(126, 60);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(62, 13);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password : ";
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 184);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.User_Text);
            this.Controls.Add(this.Pass_Text);
            this.Name = "UserLogin";
            this.Text = "User Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pass_Text;
        private System.Windows.Forms.TextBox User_Text;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
    }
}

