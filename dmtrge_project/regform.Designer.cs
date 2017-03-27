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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rabRb = new System.Windows.Forms.RadioButton();
            this.searchRb = new System.Windows.Forms.RadioButton();
            this.FIO = new System.Windows.Forms.TextBox();
            this.FIOLabel = new System.Windows.Forms.Label();
            this.addaccountBtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.passwdlabel.Location = new System.Drawing.Point(13, 85);
            this.passwdlabel.Name = "passwdlabel";
            this.passwdlabel.Size = new System.Drawing.Size(88, 13);
            this.passwdlabel.TabIndex = 1;
            this.passwdlabel.Text = "Введите пароль";
            // 
            // loginBoxreg
            // 
            this.loginBoxreg.Location = new System.Drawing.Point(151, 40);
            this.loginBoxreg.Name = "loginBoxreg";
            this.loginBoxreg.Size = new System.Drawing.Size(242, 20);
            this.loginBoxreg.TabIndex = 2;
            // 
            // passwdBoxreg
            // 
            this.passwdBoxreg.Location = new System.Drawing.Point(151, 85);
            this.passwdBoxreg.Name = "passwdBoxreg";
            this.passwdBoxreg.Size = new System.Drawing.Size(242, 20);
            this.passwdBoxreg.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rabRb);
            this.groupBox1.Controls.Add(this.searchRb);
            this.groupBox1.Location = new System.Drawing.Point(151, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rabRb
            // 
            this.rabRb.AutoSize = true;
            this.rabRb.Location = new System.Drawing.Point(109, 45);
            this.rabRb.Name = "rabRb";
            this.rabRb.Size = new System.Drawing.Size(74, 17);
            this.rabRb.TabIndex = 1;
            this.rabRb.TabStop = true;
            this.rabRb.Text = "Ищу раба";
            this.rabRb.UseVisualStyleBackColor = true;
            // 
            // searchRb
            // 
            this.searchRb.AutoSize = true;
            this.searchRb.Location = new System.Drawing.Point(7, 45);
            this.searchRb.Name = "searchRb";
            this.searchRb.Size = new System.Drawing.Size(84, 17);
            this.searchRb.TabIndex = 0;
            this.searchRb.TabStop = true;
            this.searchRb.Text = "Ищу работу";
            this.searchRb.UseVisualStyleBackColor = true;
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(151, 122);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(242, 20);
            this.FIO.TabIndex = 5;
            // 
            // FIOLabel
            // 
            this.FIOLabel.AutoSize = true;
            this.FIOLabel.Location = new System.Drawing.Point(16, 128);
            this.FIOLabel.Name = "FIOLabel";
            this.FIOLabel.Size = new System.Drawing.Size(79, 13);
            this.FIOLabel.TabIndex = 6;
            this.FIOLabel.Text = "Введите ФИО";
            // 
            // addaccountBtn
            // 
            this.addaccountBtn.Location = new System.Drawing.Point(301, 294);
            this.addaccountBtn.Name = "addaccountBtn";
            this.addaccountBtn.Size = new System.Drawing.Size(128, 23);
            this.addaccountBtn.TabIndex = 7;
            this.addaccountBtn.Text = "Зарегистрироваться";
            this.addaccountBtn.UseVisualStyleBackColor = true;
            this.addaccountBtn.Click += new System.EventHandler(this.addaccountBtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(449, 293);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(98, 23);
            this.cancelbtn.TabIndex = 8;
            this.cancelbtn.Text = "Не хочу работу";
            this.cancelbtn.UseVisualStyleBackColor = true;
            // 
            // regform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 354);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.addaccountBtn);
            this.Controls.Add(this.FIOLabel);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.passwdBoxreg);
            this.Controls.Add(this.loginBoxreg);
            this.Controls.Add(this.passwdlabel);
            this.Controls.Add(this.regnamelabel);
            this.Name = "regform";
            this.Text = "regform";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label regnamelabel;
        private System.Windows.Forms.Label passwdlabel;
        private System.Windows.Forms.TextBox loginBoxreg;
        private System.Windows.Forms.TextBox passwdBoxreg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rabRb;
        private System.Windows.Forms.RadioButton searchRb;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.Label FIOLabel;
        private System.Windows.Forms.Button addaccountBtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}