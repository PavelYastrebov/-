namespace PC
{
    partial class UPDATE
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Тип = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Наличие = new System.Windows.Forms.TextBox();
            this.textBox_Гарантия = new System.Windows.Forms.TextBox();
            this.textBox_Цена = new System.Windows.Forms.TextBox();
            this.textBox_Характеристики = new System.Windows.Forms.TextBox();
            this.textBox_Категория = new System.Windows.Forms.TextBox();
            this.textBox_Наименование = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.комплектующиеTableAdapter1 = new PC.курсачDataSetTableAdapters.КомплектующиеTableAdapter();
            this.comboBox_Поставщик = new System.Windows.Forms.ComboBox();
            this.курсачDataSet1 = new PC.курсачDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.курсачDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Гарантия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Наличие";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Характеристики";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Поставщик";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Тип";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Наименование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID_товара";
            // 
            // comboBox_Тип
            // 
            this.comboBox_Тип.FormattingEnabled = true;
            this.comboBox_Тип.Items.AddRange(new object[] {
            "внешняя",
            "внутренняя"});
            this.comboBox_Тип.Location = new System.Drawing.Point(210, 73);
            this.comboBox_Тип.Name = "comboBox_Тип";
            this.comboBox_Тип.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Тип.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "ОК ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Наличие
            // 
            this.textBox_Наличие.Location = new System.Drawing.Point(210, 203);
            this.textBox_Наличие.Name = "textBox_Наличие";
            this.textBox_Наличие.Size = new System.Drawing.Size(121, 20);
            this.textBox_Наличие.TabIndex = 28;
            // 
            // textBox_Гарантия
            // 
            this.textBox_Гарантия.Location = new System.Drawing.Point(210, 229);
            this.textBox_Гарантия.Name = "textBox_Гарантия";
            this.textBox_Гарантия.Size = new System.Drawing.Size(121, 20);
            this.textBox_Гарантия.TabIndex = 27;
            // 
            // textBox_Цена
            // 
            this.textBox_Цена.Location = new System.Drawing.Point(210, 177);
            this.textBox_Цена.Name = "textBox_Цена";
            this.textBox_Цена.Size = new System.Drawing.Size(121, 20);
            this.textBox_Цена.TabIndex = 26;
            // 
            // textBox_Характеристики
            // 
            this.textBox_Характеристики.Location = new System.Drawing.Point(210, 151);
            this.textBox_Характеристики.Name = "textBox_Характеристики";
            this.textBox_Характеристики.Size = new System.Drawing.Size(121, 20);
            this.textBox_Характеристики.TabIndex = 25;
            // 
            // textBox_Категория
            // 
            this.textBox_Категория.Location = new System.Drawing.Point(210, 99);
            this.textBox_Категория.Name = "textBox_Категория";
            this.textBox_Категория.Size = new System.Drawing.Size(121, 20);
            this.textBox_Категория.TabIndex = 23;
            // 
            // textBox_Наименование
            // 
            this.textBox_Наименование.Location = new System.Drawing.Point(210, 47);
            this.textBox_Наименование.Name = "textBox_Наименование";
            this.textBox_Наименование.Size = new System.Drawing.Size(121, 20);
            this.textBox_Наименование.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "label10";
            // 
            // комплектующиеTableAdapter1
            // 
            this.комплектующиеTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox_Поставщик
            // 
            this.comboBox_Поставщик.FormattingEnabled = true;
            this.comboBox_Поставщик.Items.AddRange(new object[] {
            "Western",
            "AMD",
            "Asus",
            "Biostar",
            "DIMM",
            "Gigabyte",
            "Intel",
            "Kingstone",
            "MSI",
            "Spire",
            ""});
            this.comboBox_Поставщик.Location = new System.Drawing.Point(210, 125);
            this.comboBox_Поставщик.Name = "comboBox_Поставщик";
            this.comboBox_Поставщик.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Поставщик.TabIndex = 42;
            // 
            // курсачDataSet1
            // 
            this.курсачDataSet1.DataSetName = "курсачDataSet";
            this.курсачDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UPDATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 321);
            this.Controls.Add(this.comboBox_Поставщик);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Тип);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Наличие);
            this.Controls.Add(this.textBox_Гарантия);
            this.Controls.Add(this.textBox_Цена);
            this.Controls.Add(this.textBox_Характеристики);
            this.Controls.Add(this.textBox_Категория);
            this.Controls.Add(this.textBox_Наименование);
            this.Name = "UPDATE";
            this.Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)(this.курсачDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Тип;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Наличие;
        private System.Windows.Forms.TextBox textBox_Гарантия;
        private System.Windows.Forms.TextBox textBox_Цена;
        private System.Windows.Forms.TextBox textBox_Характеристики;
        private System.Windows.Forms.TextBox textBox_Категория;
        private System.Windows.Forms.TextBox textBox_Наименование;
        private System.Windows.Forms.Label label10;
        private курсачDataSetTableAdapters.КомплектующиеTableAdapter комплектующиеTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox_Поставщик;
        private курсачDataSet курсачDataSet1;
    }
}