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
    public partial class UPDATE : Form
    {
        string ID1, name1, type1, category1, brend1, kharacteristic1, cost1, nalichie1, garantiya1; 
        public UPDATE(string ID, string name, string type, string category, string brend, string kharacteristic, string cost, string nalichie, string garantiya  )
        {
            InitializeComponent();
            ID1 = ID; name1 = name; type1 = type; category1 = category; brend1 = brend; kharacteristic1 = kharacteristic; cost1 = cost; nalichie1 = nalichie; garantiya1 = garantiya;
            label10.Text = ID;
            textBox_Наименование.Text = name;
            comboBox_Тип.Text = type;
            textBox_Категория.Text = category;
            comboBox_Поставщик.Text = brend;
            textBox_Характеристики.Text = kharacteristic;
            textBox_Цена.Text = cost;
            textBox_Наличие.Text = nalichie;
            textBox_Гарантия.Text = garantiya;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            комплектующиеTableAdapter1.UpdateQuery(int.Parse(label10.Text), textBox_Наименование.Text,
                comboBox_Тип.Text, textBox_Категория.Text, comboBox_Поставщик.Text, textBox_Характеристики.Text,
                int.Parse(textBox_Цена.Text), textBox_Наличие.Text, textBox_Гарантия.Text, int.Parse(ID1));
            MessageBox.Show("Изменения внесены");
            Close();
            курсачDataSet1.AcceptChanges();
        }

    }
}
