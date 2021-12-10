
namespace PasswordManager
{
    partial class MainForm
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
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.ColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateLastViewed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWelcomeMessage = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.trackBarPasswordLength = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.checkBoxUppercase = new System.Windows.Forms.CheckBox();
            this.checkBoxLowercase = new System.Windows.Forms.CheckBox();
            this.checkBoxSpecialKeys = new System.Windows.Forms.CheckBox();
            this.checkBoxNumbers = new System.Windows.Forms.CheckBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.labelViewingUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPasswordLength)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTitle,
            this.ColumnUsername,
            this.ColumnPassword,
            this.ColumnDateCreated,
            this.ColumnDateLastViewed,
            this.ColumnNote});
            this.dataGridViewInfo.Location = new System.Drawing.Point(12, 264);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.ReadOnly = true;
            this.dataGridViewInfo.RowHeadersVisible = false;
            this.dataGridViewInfo.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewInfo.TabIndex = 0;
            // 
            // ColumnTitle
            // 
            this.ColumnTitle.HeaderText = "Title";
            this.ColumnTitle.Name = "ColumnTitle";
            this.ColumnTitle.ReadOnly = true;
            // 
            // ColumnUsername
            // 
            this.ColumnUsername.HeaderText = "Username";
            this.ColumnUsername.Name = "ColumnUsername";
            this.ColumnUsername.ReadOnly = true;
            // 
            // ColumnPassword
            // 
            this.ColumnPassword.HeaderText = "Password";
            this.ColumnPassword.Name = "ColumnPassword";
            this.ColumnPassword.ReadOnly = true;
            // 
            // ColumnDateCreated
            // 
            this.ColumnDateCreated.HeaderText = "Date Created";
            this.ColumnDateCreated.Name = "ColumnDateCreated";
            this.ColumnDateCreated.ReadOnly = true;
            // 
            // ColumnDateLastViewed
            // 
            this.ColumnDateLastViewed.HeaderText = "Date Last Viewed";
            this.ColumnDateLastViewed.Name = "ColumnDateLastViewed";
            this.ColumnDateLastViewed.ReadOnly = true;
            // 
            // ColumnNote
            // 
            this.ColumnNote.HeaderText = "Note";
            this.ColumnNote.Name = "ColumnNote";
            this.ColumnNote.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.labelWelcomeMessage);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 56);
            this.panel1.TabIndex = 11;
            // 
            // labelWelcomeMessage
            // 
            this.labelWelcomeMessage.AutoSize = true;
            this.labelWelcomeMessage.Font = new System.Drawing.Font("Consolas", 29F, System.Drawing.FontStyle.Bold);
            this.labelWelcomeMessage.Location = new System.Drawing.Point(227, 4);
            this.labelWelcomeMessage.Name = "labelWelcomeMessage";
            this.labelWelcomeMessage.Size = new System.Drawing.Size(356, 46);
            this.labelWelcomeMessage.TabIndex = 0;
            this.labelWelcomeMessage.Text = "Password Manager";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.textBoxPassword.Location = new System.Drawing.Point(91, 228);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(505, 25);
            this.textBoxPassword.TabIndex = 12;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.textBoxTitle.Location = new System.Drawing.Point(90, 89);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(184, 25);
            this.textBoxTitle.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(11, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Title";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.textBoxUsername.Location = new System.Drawing.Point(91, 134);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(184, 25);
            this.textBoxUsername.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(13, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.buttonSubmit.Location = new System.Drawing.Point(602, 227);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(185, 27);
            this.buttonSubmit.TabIndex = 18;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // trackBarPasswordLength
            // 
            this.trackBarPasswordLength.Location = new System.Drawing.Point(36, 35);
            this.trackBarPasswordLength.Maximum = 1000;
            this.trackBarPasswordLength.Minimum = 1;
            this.trackBarPasswordLength.Name = "trackBarPasswordLength";
            this.trackBarPasswordLength.Size = new System.Drawing.Size(104, 45);
            this.trackBarPasswordLength.TabIndex = 19;
            this.trackBarPasswordLength.Value = 1;
            this.trackBarPasswordLength.Scroll += new System.EventHandler(this.trackBarPasswordLength_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGenerate);
            this.groupBox1.Controls.Add(this.checkBoxUppercase);
            this.groupBox1.Controls.Add(this.checkBoxLowercase);
            this.groupBox1.Controls.Add(this.checkBoxSpecialKeys);
            this.groupBox1.Controls.Add(this.checkBoxNumbers);
            this.groupBox1.Controls.Add(this.textBoxLength);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trackBarPasswordLength);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.groupBox1.Location = new System.Drawing.Point(291, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 136);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(311, 103);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(180, 27);
            this.buttonGenerate.TabIndex = 21;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // checkBoxUppercase
            // 
            this.checkBoxUppercase.AutoSize = true;
            this.checkBoxUppercase.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.checkBoxUppercase.Location = new System.Drawing.Point(344, 72);
            this.checkBoxUppercase.Name = "checkBoxUppercase";
            this.checkBoxUppercase.Size = new System.Drawing.Size(147, 22);
            this.checkBoxUppercase.TabIndex = 25;
            this.checkBoxUppercase.Text = "Uppercase (A-Z)";
            this.checkBoxUppercase.UseVisualStyleBackColor = true;
            // 
            // checkBoxLowercase
            // 
            this.checkBoxLowercase.AutoSize = true;
            this.checkBoxLowercase.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.checkBoxLowercase.Location = new System.Drawing.Point(344, 35);
            this.checkBoxLowercase.Name = "checkBoxLowercase";
            this.checkBoxLowercase.Size = new System.Drawing.Size(147, 22);
            this.checkBoxLowercase.TabIndex = 24;
            this.checkBoxLowercase.Text = "Lowercase (a-z)";
            this.checkBoxLowercase.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpecialKeys
            // 
            this.checkBoxSpecialKeys.AutoSize = true;
            this.checkBoxSpecialKeys.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.checkBoxSpecialKeys.Location = new System.Drawing.Point(147, 35);
            this.checkBoxSpecialKeys.Name = "checkBoxSpecialKeys";
            this.checkBoxSpecialKeys.Size = new System.Drawing.Size(195, 22);
            this.checkBoxSpecialKeys.TabIndex = 23;
            this.checkBoxSpecialKeys.Text = "Special Keys (!*~...)";
            this.checkBoxSpecialKeys.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumbers
            // 
            this.checkBoxNumbers.AutoSize = true;
            this.checkBoxNumbers.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.checkBoxNumbers.Location = new System.Drawing.Point(174, 71);
            this.checkBoxNumbers.Name = "checkBoxNumbers";
            this.checkBoxNumbers.Size = new System.Drawing.Size(131, 22);
            this.checkBoxNumbers.TabIndex = 22;
            this.checkBoxNumbers.Text = "Numbers (0-9)";
            this.checkBoxNumbers.UseVisualStyleBackColor = true;
            // 
            // textBoxLength
            // 
            this.textBoxLength.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.textBoxLength.Location = new System.Drawing.Point(69, 72);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(71, 25);
            this.textBoxLength.TabIndex = 21;
            this.textBoxLength.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(7, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(13, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Note?";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic);
            this.textBoxNote.Location = new System.Drawing.Point(91, 183);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(184, 25);
            this.textBoxNote.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(14, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 8);
            this.label6.TabIndex = 23;
            this.label6.Text = "Optional";
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Chocolate;
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLogout.Location = new System.Drawing.Point(12, 421);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 24;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Viewing:";
            // 
            // labelViewingUser
            // 
            this.labelViewingUser.AutoSize = true;
            this.labelViewingUser.Location = new System.Drawing.Point(146, 426);
            this.labelViewingUser.Name = "labelViewingUser";
            this.labelViewingUser.Size = new System.Drawing.Size(0, 13);
            this.labelViewingUser.TabIndex = 26;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.labelViewingUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPasswordLength)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelWelcomeMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateLastViewed;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TrackBar trackBarPasswordLength;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxUppercase;
        private System.Windows.Forms.CheckBox checkBoxLowercase;
        private System.Windows.Forms.CheckBox checkBoxSpecialKeys;
        private System.Windows.Forms.CheckBox checkBoxNumbers;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelViewingUser;
    }
}