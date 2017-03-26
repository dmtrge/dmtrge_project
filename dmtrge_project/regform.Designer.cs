namespace dmtrge_project
{
    partial class regform
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
            this.regnamelabel = new System.Windows.Forms.Label();
            this.passwdlabel = new System.Windows.Forms.Label();
            this.loginBoxreg = new System.Windows.Forms.TextBox();
            this.passwdBoxreg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // regnamelabel
            // 
            this.regnamelabel.AutoSize = true;
            this.regnamelabel.Location = new System.Drawing.Point(13, 48);
            this.regnamelabel.Name = "regnamelabel";
            this.regnamelabel.Size = new System.Drawing.Size(74, 13);
            this.regnamelabel.TabIndex = 0;
            this.regnamelabel.Text = "Введите login";
            // 
            // passwdlabel
            // 
            this.passwdlabel.AutoSize = true;
            this.passwdlabel.Location = new System.Drawing.Point(16, 85);
            this.passwdlabel.Name = "passwdlabel";
            this.passwdlabel.Size = new System.Drawing.Size(88, 13);
            this.passwdlabel.TabIndex = 1;
            this.passwdlabel.Text = "Введите пароль";
            // 
            // loginBoxreg
            // 
            this.loginBoxreg.Location = new System.Drawing.Point(151, 40);
            this.loginBoxreg.Name = "loginBoxreg";
            this.loginBoxreg.Size = new System.Drawing.Size(100, 20);
            this.loginBoxreg.TabIndex = 2;
            // 
            // passwdBoxreg
            // 
            this.passwdBoxreg.Location = new System.Drawing.Point(151, 85);
            this.passwdBoxreg.Name = "passwdBoxreg";
            this.passwdBoxreg.Size = new System.Drawing.Size(100, 20);
            this.passwdBoxreg.TabIndex = 3;
            // 
            // regform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.passwdBoxreg);
            this.Controls.Add(this.loginBoxreg);
            this.Controls.Add(this.passwdlabel);
            this.Controls.Add(this.regnamelabel);
            this.Name = "regform";
            this.Text = "regform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label regnamelabel;
        private System.Windows.Forms.Label passwdlabel;
        private System.Windows.Forms.TextBox loginBoxreg;
        private System.Windows.Forms.TextBox passwdBoxreg;
    }
}