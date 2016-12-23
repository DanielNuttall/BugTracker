namespace BugTracker.Bugs
{
    partial class Bugs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.issueDesc = new System.Windows.Forms.Label();
            this.issueDescValue = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addComment = new System.Windows.Forms.Button();
            this.newCommentValue = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.repoFiles = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.issueInfoTab = new System.Windows.Forms.TabPage();
            this.createIssueTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.repoFiles2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newIssueValue = new System.Windows.Forms.RichTextBox();
            this.issueTitleValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uIssueTitleValue = new System.Windows.Forms.TextBox();
            this.repoFiles3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uIssueValue = new System.Windows.Forms.RichTextBox();
            this.updateIssue = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.issueInfoTab.SuspendLayout();
            this.createIssueTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 646);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(712, 589);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1259, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 646);
            this.panel2.TabIndex = 3;
            // 
            // cBox
            // 
            this.cBox.FormattingEnabled = true;
            this.cBox.HorizontalScrollbar = true;
            this.cBox.Location = new System.Drawing.Point(6, 147);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(465, 160);
            this.cBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.repoFiles);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.newCommentValue);
            this.groupBox1.Controls.Add(this.addComment);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.issueDescValue);
            this.groupBox1.Controls.Add(this.issueDesc);
            this.groupBox1.Controls.Add(this.cBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 497);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Issue";
            // 
            // issueDesc
            // 
            this.issueDesc.AutoSize = true;
            this.issueDesc.Location = new System.Drawing.Point(6, 16);
            this.issueDesc.Name = "issueDesc";
            this.issueDesc.Size = new System.Drawing.Size(188, 13);
            this.issueDesc.TabIndex = 8;
            this.issueDesc.Text = "Description - Select a Issue to see info";
            // 
            // issueDescValue
            // 
            this.issueDescValue.Location = new System.Drawing.Point(6, 32);
            this.issueDescValue.Name = "issueDescValue";
            this.issueDescValue.ReadOnly = true;
            this.issueDescValue.Size = new System.Drawing.Size(465, 96);
            this.issueDescValue.TabIndex = 9;
            this.issueDescValue.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Comments";
            // 
            // addComment
            // 
            this.addComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(227)))));
            this.addComment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addComment.Location = new System.Drawing.Point(330, 468);
            this.addComment.Name = "addComment";
            this.addComment.Size = new System.Drawing.Size(141, 23);
            this.addComment.TabIndex = 11;
            this.addComment.Text = "Add Comment";
            this.addComment.UseVisualStyleBackColor = false;
            this.addComment.Click += new System.EventHandler(this.addComment_Click);
            // 
            // newCommentValue
            // 
            this.newCommentValue.Location = new System.Drawing.Point(6, 358);
            this.newCommentValue.Name = "newCommentValue";
            this.newCommentValue.Size = new System.Drawing.Size(465, 104);
            this.newCommentValue.TabIndex = 12;
            this.newCommentValue.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "New Comment Text";
            // 
            // repoFiles
            // 
            this.repoFiles.FormattingEnabled = true;
            this.repoFiles.Location = new System.Drawing.Point(9, 470);
            this.repoFiles.Name = "repoFiles";
            this.repoFiles.Size = new System.Drawing.Size(301, 21);
            this.repoFiles.TabIndex = 14;
            this.repoFiles.SelectedIndexChanged += new System.EventHandler(this.repoFiles_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.issueInfoTab);
            this.tabControl1.Controls.Add(this.createIssueTab);
            this.tabControl1.Location = new System.Drawing.Point(722, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(525, 589);
            this.tabControl1.TabIndex = 8;
            // 
            // issueInfoTab
            // 
            this.issueInfoTab.Controls.Add(this.groupBox1);
            this.issueInfoTab.Location = new System.Drawing.Point(4, 22);
            this.issueInfoTab.Name = "issueInfoTab";
            this.issueInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.issueInfoTab.Size = new System.Drawing.Size(517, 563);
            this.issueInfoTab.TabIndex = 0;
            this.issueInfoTab.Text = "Issue Info";
            this.issueInfoTab.UseVisualStyleBackColor = true;
            // 
            // createIssueTab
            // 
            this.createIssueTab.Controls.Add(this.groupBox3);
            this.createIssueTab.Controls.Add(this.groupBox2);
            this.createIssueTab.Location = new System.Drawing.Point(4, 22);
            this.createIssueTab.Name = "createIssueTab";
            this.createIssueTab.Padding = new System.Windows.Forms.Padding(3);
            this.createIssueTab.Size = new System.Drawing.Size(517, 563);
            this.createIssueTab.TabIndex = 1;
            this.createIssueTab.Text = "Create Issue";
            this.createIssueTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(227)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(329, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Issue";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.issueTitleValue);
            this.groupBox2.Controls.Add(this.repoFiles2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.newIssueValue);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Issue";
            // 
            // repoFiles2
            // 
            this.repoFiles2.FormattingEnabled = true;
            this.repoFiles2.Location = new System.Drawing.Point(8, 190);
            this.repoFiles2.Name = "repoFiles2";
            this.repoFiles2.Size = new System.Drawing.Size(301, 21);
            this.repoFiles2.TabIndex = 17;
            this.repoFiles2.SelectedIndexChanged += new System.EventHandler(this.repoFiles2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "New Issue Text";
            // 
            // newIssueValue
            // 
            this.newIssueValue.Location = new System.Drawing.Point(5, 78);
            this.newIssueValue.Name = "newIssueValue";
            this.newIssueValue.Size = new System.Drawing.Size(465, 104);
            this.newIssueValue.TabIndex = 15;
            this.newIssueValue.Text = "";
            // 
            // issueTitleValue
            // 
            this.issueTitleValue.Location = new System.Drawing.Point(6, 39);
            this.issueTitleValue.Name = "issueTitleValue";
            this.issueTitleValue.Size = new System.Drawing.Size(464, 20);
            this.issueTitleValue.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Issue Title";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.uIssueTitleValue);
            this.groupBox3.Controls.Add(this.repoFiles3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.uIssueValue);
            this.groupBox3.Controls.Add(this.updateIssue);
            this.groupBox3.Location = new System.Drawing.Point(6, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 222);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Issue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Issue Title";
            // 
            // uIssueTitleValue
            // 
            this.uIssueTitleValue.Location = new System.Drawing.Point(6, 39);
            this.uIssueTitleValue.Name = "uIssueTitleValue";
            this.uIssueTitleValue.ReadOnly = true;
            this.uIssueTitleValue.Size = new System.Drawing.Size(464, 20);
            this.uIssueTitleValue.TabIndex = 18;
            // 
            // repoFiles3
            // 
            this.repoFiles3.FormattingEnabled = true;
            this.repoFiles3.Location = new System.Drawing.Point(8, 190);
            this.repoFiles3.Name = "repoFiles3";
            this.repoFiles3.Size = new System.Drawing.Size(301, 21);
            this.repoFiles3.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "New Issue Text";
            // 
            // uIssueValue
            // 
            this.uIssueValue.Location = new System.Drawing.Point(5, 78);
            this.uIssueValue.Name = "uIssueValue";
            this.uIssueValue.Size = new System.Drawing.Size(465, 104);
            this.uIssueValue.TabIndex = 15;
            this.uIssueValue.Text = "";
            // 
            // updateIssue
            // 
            this.updateIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(227)))));
            this.updateIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateIssue.Location = new System.Drawing.Point(329, 187);
            this.updateIssue.Name = "updateIssue";
            this.updateIssue.Size = new System.Drawing.Size(141, 23);
            this.updateIssue.TabIndex = 0;
            this.updateIssue.Text = "Update Issue";
            this.updateIssue.UseVisualStyleBackColor = false;
            this.updateIssue.Click += new System.EventHandler(this.updateIssue_Click);
            // 
            // Bugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1259, 646);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Bugs";
            this.Text = "Bugs";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.issueInfoTab.ResumeLayout(false);
            this.createIssueTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox cBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label issueDesc;
        private System.Windows.Forms.RichTextBox issueDescValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox newCommentValue;
        private System.Windows.Forms.ComboBox repoFiles;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage issueInfoTab;
        private System.Windows.Forms.TabPage createIssueTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox repoFiles2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox newIssueValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox issueTitleValue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uIssueTitleValue;
        private System.Windows.Forms.ComboBox repoFiles3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox uIssueValue;
        private System.Windows.Forms.Button updateIssue;
    }
}