using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            комплектующиеTableAdapter.InsertQuery(int.Parse(textBox_ID_товара.Text), textBox_Наименование.Text, comboBox_Тип.Text, textBox_Категория.Text, comboBox_Поставщик.Text, textBox_Характеристики.Text, int.Parse(textBox_Цена.Text), textBox_Наличие.Text, textBox_Гарантия.Text);
            MessageBox.Show("Товар добавлен");
            курсачDataSet1.AcceptChanges();

            Close();
        }
    }
}
