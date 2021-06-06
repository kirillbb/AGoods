namespace WindowsFormsApp2
{
    partial class login
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
            this.button_goLogin = new System.Windows.Forms.Button();
            this.UserLoginTextBox = new System.Windows.Forms.TextBox();
            this.UserPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_goLogin
            // 
            this.button_goLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_goLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_goLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_goLogin.Location = new System.Drawing.Point(14, 146);
            this.button_goLogin.Name = "button_goLogin";
            this.button_goLogin.Size = new System.Drawing.Size(197, 23);
            this.button_goLogin.TabIndex = 2;
            this.button_goLogin.Text = "LogIn";
            this.button_goLogin.UseVisualStyleBackColor = false;
            this.button_goLogin.Click += new System.EventHandler(this.login_Click);
            // 
            // UserLoginTextBox
            // 
            this.UserLoginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserLoginTextBox.Location = new System.Drawing.Point(14, 33);
            this.UserLoginTextBox.MaxLength = 30;
            this.UserLoginTextBox.Name = "UserLoginTextBox";
            this.UserLoginTextBox.Size = new System.Drawing.Size(197, 20);
            this.UserLoginTextBox.TabIndex = 0;
            this.UserLoginTextBox.WordWrap = false;
            this.UserLoginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox);
            this.UserLoginTextBox.Enter += new System.EventHandler(this.LoginTextBox);
            // 
            // UserPasswordTextBox
            // 
            this.UserPasswordTextBox.AcceptsReturn = true;
            this.UserPasswordTextBox.Location = new System.Drawing.Point(14, 93);
            this.UserPasswordTextBox.MaxLength = 30;
            this.UserPasswordTextBox.Name = "UserPasswordTextBox";
            this.UserPasswordTextBox.Size = new System.Drawing.Size(197, 20);
            this.UserPasswordTextBox.TabIndex = 1;
            this.UserPasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox);
            this.UserPasswordTextBox.Enter += new System.EventHandler(this.PasswordTextBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 183);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserPasswordTextBox);
            this.Controls.Add(this.UserLoginTextBox);
            this.Controls.Add(this.button_goLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.Enter += new System.EventHandler(this.login_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_goLogin;
        private System.Windows.Forms.TextBox UserLoginTextBox;
        private System.Windows.Forms.TextBox UserPasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}