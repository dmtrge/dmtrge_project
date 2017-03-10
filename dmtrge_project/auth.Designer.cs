namespace dmtrge_project
{
    partial class auth
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
            this.Login = new System.Windows.Forms.Label();
            this.logintbox = new System.Windows.Forms.TextBox();
            this.passwdbox = new System.Windows.Forms.TextBox();
            this.passwd = new System.Windows.Forms.Label();
            this.regbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(12, 39);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(29, 13);
            this.Login.TabIndex = 0;
            this.Login.Text = "login";
            // 
            // logintbox
            // 
            this.logintbox.Location = new System.Drawing.Point(81, 36);
            this.logintbox.Name = "logintbox";
            this.logintbox.Size = new System.Drawing.Size(100, 20);
            this.logintbox.TabIndex = 1;
            // 
            // passwdbox
            // 
            this.passwdbox.Location = new System.Drawing.Point(81, 79);
            this.passwdbox.Name = "passwdbox";
            this.passwdbox.Size = new System.Drawing.Size(100, 20);
            this.passwdbox.TabIndex = 2;
            // 
            // passwd
            // 
            this.passwd.AutoSize = true;
            this.passwd.Location = new System.Drawing.Point(12, 79);
            this.passwd.Name = "passwd";
            this.passwd.Size = new System.Drawing.Size(53, 13);
            this.passwd.TabIndex = 3;
            this.passwd.Text = "Password";
            // 
            // regbutton
            // 
            this.regbutton.Location = new System.Drawing.Point(164, 105);
            this.regbutton.Name = "regbutton";
            this.regbutton.Size = new System.Drawing.Size(85, 23);
            this.regbutton.TabIndex = 4;
            this.regbutton.Text = "Регистрация";
            this.regbutton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Авторизация";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(261, 160);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.regbutton);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.passwdbox);
            this.Controls.Add(this.logintbox);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "auth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox logintbox;
        private System.Windows.Forms.TextBox passwdbox;
        private System.Windows.Forms.Label passwd;
        private System.Windows.Forms.Button regbutton;
        private System.Windows.Forms.Button button1;
    }
}