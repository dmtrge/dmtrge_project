namespace dmtrge_project
{
    partial class addvacantion
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
            this.genvectorCB = new System.Windows.Forms.ComboBox();
            this.backvectorCB = new System.Windows.Forms.ComboBox();
            this.addvacBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.recTextb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите основное направление";
            // 
            // genvectorCB
            // 
            this.genvectorCB.FormattingEnabled = true;
            this.genvectorCB.Location = new System.Drawing.Point(195, 53);
            this.genvectorCB.Name = "genvectorCB";
            this.genvectorCB.Size = new System.Drawing.Size(121, 21);
            this.genvectorCB.TabIndex = 1;
            // 
            // backvectorCB
            // 
            this.backvectorCB.FormattingEnabled = true;
            this.backvectorCB.Location = new System.Drawing.Point(195, 26);
            this.backvectorCB.Name = "backvectorCB";
            this.backvectorCB.Size = new System.Drawing.Size(121, 21);
            this.backvectorCB.TabIndex = 2;
            // 
            // addvacBtn
            // 
            this.addvacBtn.Location = new System.Drawing.Point(170, 339);
            this.addvacBtn.Name = "addvacBtn";
            this.addvacBtn.Size = new System.Drawing.Size(121, 23);
            this.addvacBtn.TabIndex = 3;
            this.addvacBtn.Text = "Создать вакансию";
            this.addvacBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(297, 339);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // recTextb
            // 
            this.recTextb.Location = new System.Drawing.Point(131, 80);
            this.recTextb.Multiline = true;
            this.recTextb.Name = "recTextb";
            this.recTextb.Size = new System.Drawing.Size(185, 186);
            this.recTextb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Специальность";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 290);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Location = new System.Drawing.Point(13, 296);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(85, 13);
            this.timelabel.TabIndex = 8;
            this.timelabel.Text = "График работы";
            // 
            // addvacantion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 374);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recTextb);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addvacBtn);
            this.Controls.Add(this.backvectorCB);
            this.Controls.Add(this.genvectorCB);
            this.Controls.Add(this.label1);
            this.Name = "addvacantion";
            this.Text = "addvacantion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox genvectorCB;
        private System.Windows.Forms.ComboBox backvectorCB;
        private System.Windows.Forms.Button addvacBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox recTextb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label timelabel;
    }
}