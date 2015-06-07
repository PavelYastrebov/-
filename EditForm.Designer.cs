namespace PC
{
    partial class EditForm
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
            this.textBox_ID_товара = new System.Windows.Forms.TextBox();
            this.textBox_Наименование = new System.Windows.Forms.TextBox();
            this.textBox_Категория = new System.Windows.Forms.TextBox();
            this.textBox_Характеристики = new System.Windows.Forms.TextBox();
            this.textBox_Цена = new System.Windows.Forms.TextBox();
            this.textBox_Гарантия = new System.Windows.Forms.TextBox();
            this.textBox_Наличие = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox_Тип = new System.Windows.Forms.ComboBox();
            this.комплектующиеTableAdapter = new PC.курсачDataSetTableAdapters.КомплектующиеTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.курсачDataSet1 = new PC.курсачDataSet();
            this.comboBox_Поставщик = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.курсачDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_ID_товара
            // 
            this.textBox_ID_товара.Location = new System.Drawing.Point(206, 36);
            this.textBox_ID_товара.Name = "textBox_ID_товара";
            this.textBox_ID_товара.Size = new System.Drawing.Size(121, 20);
            this.textBox_ID_товара.TabIndex = 0;
            // 
            // textBox_Наименование
            // 
            this.textBox_Наименование.Location = new System.Drawing.Point(206, 62);
            this.textBox_Наименование.Name = "textBox_Наименование";
            this.textBox_Наименование.Size = new System.Drawing.Size(121, 20);
            this.textBox_Наименование.TabIndex = 1;
            // 
            // textBox_Категория
            // 
            this.textBox_Категория.Location = new System.Drawing.Point(206, 114);
            this.textBox_Категория.Name = "textBox_Категория";
            this.textBox_Категория.Size = new System.Drawing.Size(121, 20);
            this.textBox_Категория.TabIndex = 3;
            // 
            // textBox_Характеристики
            // 
            this.textBox_Характеристики.Location = new System.Drawing.Point(206, 166);
            this.textBox_Характеристики.Name = "textBox_Характеристики";
            this.textBox_Характеристики.Size = new System.Drawing.Size(121, 20);
            this.textBox_Характеристики.TabIndex = 5;
            // 
            // textBox_Цена
            // 
            this.textBox_Цена.Location = new System.Drawing.Point(206, 192);
            this.textBox_Цена.Name = "textBox_Цена";
            this.textBox_Цена.Size = new System.Drawing.Size(121, 20);
            this.textBox_Цена.TabIndex = 6;
            // 
            // textBox_Гарантия
            // 
            this.textBox_Гарантия.Location = new System.Drawing.Point(206, 244);
            this.textBox_Гарантия.Name = "textBox_Гарантия";
            this.textBox_Гарантия.Size = new System.Drawing.Size(121, 20);
            this.textBox_Гарантия.TabIndex = 7;
            // 
            // textBox_Наличие
            // 
            this.textBox_Наличие.Location = new System.Drawing.Point(206, 218);
            this.textBox_Наличие.Name = "textBox_Наличие";
            this.textBox_Наличие.Size = new System.Drawing.Size(121, 20);
            this.textBox_Наличие.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "ОК ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox_Тип
            // 
            this.comboBox_Тип.FormattingEnabled = true;
            this.comboBox_Тип.Items.AddRange(new object[] {
            "внешняя",
            "внутренняя"});
            this.comboBox_Тип.Location = new System.Drawing.Point(206, 88);
            this.comboBox_Тип.Name = "comboBox_Тип";
            this.comboBox_Тип.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Тип.TabIndex = 11;
            // 
            // комплектующиеTableAdapter
            // 
            this.комплектующиеTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Гарантия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Наличие";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Характеристики";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Поставщик";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Тип";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Наименование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "ID_товара";
            // 
            // курсачDataSet1
            // 
            this.курсачDataSet1.DataSetName = "курсачDataSet";
            this.курсачDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            "",
            ""});
            this.comboBox_Поставщик.Location = new System.Drawing.Point(206, 139);
            this.comboBox_Поставщик.Name = "comboBox_Поставщик";
            this.comboBox_Поставщик.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Поставщик.TabIndex = 50;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 335);
            this.Controls.Add(this.comboBox_Поставщик);
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
            this.Controls.Add(this.textBox_ID_товара);
            this.Name = "EditForm";
            this.Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)(this.курсачDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ID_товара;
        private System.Windows.Forms.TextBox textBox_Наименование;
        private System.Windows.Forms.TextBox textBox_Категория;
        private System.Windows.Forms.TextBox textBox_Характеристики;
        private System.Windows.Forms.TextBox textBox_Цена;
        private System.Windows.Forms.TextBox textBox_Гарантия;
        private System.Windows.Forms.TextBox textBox_Наличие;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox_Тип;
        private курсачDataSetTableAdapters.КомплектующиеTableAdapter комплектующиеTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private курсачDataSet курсачDataSet1;
        private System.Windows.Forms.ComboBox comboBox_Поставщик;
    }
}