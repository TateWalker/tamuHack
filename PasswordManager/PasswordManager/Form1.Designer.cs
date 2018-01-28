namespace PasswordManager
{
    partial class frmPasswordMgr
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewWebsite = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gboxNewPassword = new System.Windows.Forms.GroupBox();
            this.grpboxRetrievePassword = new System.Windows.Forms.GroupBox();
            this.btnRetrievePassword = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtWebPassword = new System.Windows.Forms.TextBox();
            this.gboxNewPassword.SuspendLayout();
            this.grpboxRetrievePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Word:";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(195, 174);
            this.txtWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(132, 23);
            this.txtWord.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(65, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Website:";
            // 
            // txtNewWebsite
            // 
            this.txtNewWebsite.Location = new System.Drawing.Point(195, 81);
            this.txtNewWebsite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewWebsite.Name = "txtNewWebsite";
            this.txtNewWebsite.Size = new System.Drawing.Size(220, 23);
            this.txtNewWebsite.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Silver;
            this.btnGenerate.ForeColor = System.Drawing.Color.Black;
            this.btnGenerate.Location = new System.Drawing.Point(71, 198);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(116, 39);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(284, 198);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 39);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "E&xit";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // cboColor
            // 
            this.cboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(195, 127);
            this.cboColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(167, 24);
            this.cboColor.TabIndex = 2;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(173, 71);
            this.txtWebsite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(184, 23);
            this.txtWebsite.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Website:";
            // 
            // gboxNewPassword
            // 
            this.gboxNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gboxNewPassword.Controls.Add(this.btnGenerate);
            this.gboxNewPassword.Controls.Add(this.btnClose);
            this.gboxNewPassword.ForeColor = System.Drawing.Color.White;
            this.gboxNewPassword.Location = new System.Drawing.Point(16, 28);
            this.gboxNewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxNewPassword.Name = "gboxNewPassword";
            this.gboxNewPassword.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxNewPassword.Size = new System.Drawing.Size(451, 274);
            this.gboxNewPassword.TabIndex = 8;
            this.gboxNewPassword.TabStop = false;
            this.gboxNewPassword.Text = "Create New Password";
            // 
            // grpboxRetrievePassword
            // 
            this.grpboxRetrievePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpboxRetrievePassword.Controls.Add(this.btnRetrievePassword);
            this.grpboxRetrievePassword.Controls.Add(this.label4);
            this.grpboxRetrievePassword.Controls.Add(this.txtWebsite);
            this.grpboxRetrievePassword.ForeColor = System.Drawing.Color.White;
            this.grpboxRetrievePassword.Location = new System.Drawing.Point(497, 28);
            this.grpboxRetrievePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpboxRetrievePassword.Name = "grpboxRetrievePassword";
            this.grpboxRetrievePassword.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpboxRetrievePassword.Size = new System.Drawing.Size(417, 274);
            this.grpboxRetrievePassword.TabIndex = 9;
            this.grpboxRetrievePassword.TabStop = false;
            this.grpboxRetrievePassword.Text = "Retrieve Password";
            // 
            // btnRetrievePassword
            // 
            this.btnRetrievePassword.BackColor = System.Drawing.Color.Silver;
            this.btnRetrievePassword.ForeColor = System.Drawing.Color.Black;
            this.btnRetrievePassword.Location = new System.Drawing.Point(157, 166);
            this.btnRetrievePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRetrievePassword.Name = "btnRetrievePassword";
            this.btnRetrievePassword.Size = new System.Drawing.Size(136, 53);
            this.btnRetrievePassword.TabIndex = 8;
            this.btnRetrievePassword.Text = "Retrieve Password";
            this.btnRetrievePassword.UseVisualStyleBackColor = false;
            this.btnRetrievePassword.Click += new System.EventHandler(this.btnRetrievePassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(411, 311);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(312, 23);
            this.txtPassword.TabIndex = 6;
            // 
            // txtWebPassword
            // 
            this.txtWebPassword.Location = new System.Drawing.Point(253, 311);
            this.txtWebPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWebPassword.Name = "txtWebPassword";
            this.txtWebPassword.ReadOnly = true;
            this.txtWebPassword.Size = new System.Drawing.Size(148, 23);
            this.txtWebPassword.TabIndex = 10;
            // 
            // frmPasswordMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(931, 351);
            this.Controls.Add(this.txtWebPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.txtNewWebsite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gboxNewPassword);
            this.Controls.Add(this.grpboxRetrievePassword);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPasswordMgr";
            this.Text = "Password Manager";
            this.Load += new System.EventHandler(this.frmPasswordMgr_Load);
            this.gboxNewPassword.ResumeLayout(false);
            this.grpboxRetrievePassword.ResumeLayout(false);
            this.grpboxRetrievePassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewWebsite;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gboxNewPassword;
        private System.Windows.Forms.GroupBox grpboxRetrievePassword;
        private System.Windows.Forms.Button btnRetrievePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtWebPassword;
    }
}

