namespace dmtrge_project
{
    partial class genform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переавтризацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.cityRB = new System.Windows.Forms.RadioButton();
            this.specRB = new System.Windows.Forms.RadioButton();
            this.salRB = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gentableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new dmtrge_project.DatabaseDataSet();
            this.gentableTableAdapter = new dmtrge_project.DatabaseDataSetTableAdapters.gentableTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отрасльDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специальностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.требованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.опытРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зПDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.графикРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоположениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.обратнаяСвязьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоПросмотровDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchbtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gentableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(547, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 20);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1151, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переавтризацияToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // переавтризацияToolStripMenuItem
            // 
            this.переавтризацияToolStripMenuItem.Name = "переавтризацияToolStripMenuItem";
            this.переавтризацияToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.переавтризацияToolStripMenuItem.Text = "Переавторизация";
            this.переавтризацияToolStripMenuItem.Click += new System.EventHandler(this.переавтризацияToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.cityRB);
            this.groupBox1.Controls.Add(this.specRB);
            this.groupBox1.Controls.Add(this.salRB);
            this.groupBox1.Location = new System.Drawing.Point(48, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 83);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // cityRB
            // 
            this.cityRB.AutoSize = true;
            this.cityRB.Location = new System.Drawing.Point(6, 60);
            this.cityRB.Name = "cityRB";
            this.cityRB.Size = new System.Drawing.Size(55, 17);
            this.cityRB.TabIndex = 2;
            this.cityRB.TabStop = true;
            this.cityRB.Text = "Город";
            this.cityRB.UseVisualStyleBackColor = true;
            // 
            // specRB
            // 
            this.specRB.AutoSize = true;
            this.specRB.Location = new System.Drawing.Point(6, 37);
            this.specRB.Name = "specRB";
            this.specRB.Size = new System.Drawing.Size(103, 17);
            this.specRB.TabIndex = 1;
            this.specRB.TabStop = true;
            this.specRB.Text = "Специальность";
            this.specRB.UseVisualStyleBackColor = true;
            // 
            // salRB
            // 
            this.salRB.AutoSize = true;
            this.salRB.Location = new System.Drawing.Point(6, 17);
            this.salRB.Name = "salRB";
            this.salRB.Size = new System.Drawing.Size(73, 17);
            this.salRB.TabIndex = 0;
            this.salRB.TabStop = true;
            this.salRB.Text = "Зарплата";
            this.salRB.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(567, 96);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(572, 335);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.отрасльDataGridViewTextBoxColumn,
            this.специальностьDataGridViewTextBoxColumn,
            this.требованияDataGridViewTextBoxColumn,
            this.опытРаботыDataGridViewTextBoxColumn,
            this.зПDataGridViewTextBoxColumn,
            this.графикРаботыDataGridViewTextBoxColumn,
            this.местоположениеDataGridViewTextBoxColumn,
            this.обратнаяСвязьDataGridViewTextBoxColumn,
            this.колвоПросмотровDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gentableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 584);
            this.dataGridView1.TabIndex = 4;
            // 
            // gentableBindingSource
            // 
            this.gentableBindingSource.DataMember = "gentable";
            this.gentableBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gentableTableAdapter
            // 
            this.gentableTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // отрасльDataGridViewTextBoxColumn
            // 
            this.отрасльDataGridViewTextBoxColumn.DataPropertyName = "Отрасль";
            this.отрасльDataGridViewTextBoxColumn.HeaderText = "Отрасль";
            this.отрасльDataGridViewTextBoxColumn.Name = "отрасльDataGridViewTextBoxColumn";
            // 
            // специальностьDataGridViewTextBoxColumn
            // 
            this.специальностьDataGridViewTextBoxColumn.DataPropertyName = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.Name = "специальностьDataGridViewTextBoxColumn";
            // 
            // требованияDataGridViewTextBoxColumn
            // 
            this.требованияDataGridViewTextBoxColumn.DataPropertyName = "Требования";
            this.требованияDataGridViewTextBoxColumn.HeaderText = "Требования";
            this.требованияDataGridViewTextBoxColumn.Name = "требованияDataGridViewTextBoxColumn";
            this.требованияDataGridViewTextBoxColumn.Visible = false;
            // 
            // опытРаботыDataGridViewTextBoxColumn
            // 
            this.опытРаботыDataGridViewTextBoxColumn.DataPropertyName = "Опыт работы";
            this.опытРаботыDataGridViewTextBoxColumn.HeaderText = "Опыт работы";
            this.опытРаботыDataGridViewTextBoxColumn.Name = "опытРаботыDataGridViewTextBoxColumn";
            this.опытРаботыDataGridViewTextBoxColumn.Visible = false;
            // 
            // зПDataGridViewTextBoxColumn
            // 
            this.зПDataGridViewTextBoxColumn.DataPropertyName = "ЗП";
            this.зПDataGridViewTextBoxColumn.HeaderText = "ЗП";
            this.зПDataGridViewTextBoxColumn.Name = "зПDataGridViewTextBoxColumn";
            // 
            // графикРаботыDataGridViewTextBoxColumn
            // 
            this.графикРаботыDataGridViewTextBoxColumn.DataPropertyName = "График работы";
            this.графикРаботыDataGridViewTextBoxColumn.HeaderText = "График работы";
            this.графикРаботыDataGridViewTextBoxColumn.Name = "графикРаботыDataGridViewTextBoxColumn";
            this.графикРаботыDataGridViewTextBoxColumn.Visible = false;
            // 
            // местоположениеDataGridViewTextBoxColumn
            // 
            this.местоположениеDataGridViewTextBoxColumn.DataPropertyName = "Местоположение";
            this.местоположениеDataGridViewTextBoxColumn.HeaderText = "Местоположение";
            this.местоположениеDataGridViewTextBoxColumn.Name = "местоположениеDataGridViewTextBoxColumn";
            // 
            // обратнаяСвязьDataGridViewTextBoxColumn
            // 
            this.обратнаяСвязьDataGridViewTextBoxColumn.DataPropertyName = "Обратная связь";
            this.обратнаяСвязьDataGridViewTextBoxColumn.HeaderText = "Обратная связь";
            this.обратнаяСвязьDataGridViewTextBoxColumn.Name = "обратнаяСвязьDataGridViewTextBoxColumn";
            this.обратнаяСвязьDataGridViewTextBoxColumn.Visible = false;
            // 
            // колвоПросмотровDataGridViewTextBoxColumn
            // 
            this.колвоПросмотровDataGridViewTextBoxColumn.DataPropertyName = "Кол-во просмотров";
            this.колвоПросмотровDataGridViewTextBoxColumn.HeaderText = "Кол-во просмотров";
            this.колвоПросмотровDataGridViewTextBoxColumn.Name = "колвоПросмотровDataGridViewTextBoxColumn";
            this.колвоПросмотровDataGridViewTextBoxColumn.Visible = false;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(885, 44);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 5;
            this.searchbtn.Text = "Поиск";
            this.searchbtn.UseVisualStyleBackColor = true;
            // 
            // genform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 728);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "genform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "genform";
            this.Load += new System.EventHandler(this.genform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gentableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переавтризацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton cityRB;
        private System.Windows.Forms.RadioButton specRB;
        private System.Windows.Forms.RadioButton salRB;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource gentableBindingSource;
        private DatabaseDataSetTableAdapters.gentableTableAdapter gentableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отрасльDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn специальностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn требованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn опытРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зПDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn графикРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоположениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обратнаяСвязьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоПросмотровDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button searchbtn;
    }
}

