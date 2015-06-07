using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PC
{
    public partial class Complect : Form
    {
        public Complect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 2)
            {
                try
                {
                    OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|курсач.accdb");
                    sqlconn.Open();
                    OleDbDataAdapter oda = new OleDbDataAdapter("select * from Комплектующие where Цена=(Select Max(Цена) from Комплектующие where Категория='Процессор') UNION select * from Комплектующие where Цена=(Select Max(Цена) from Комплектующие where Категория='Жёсткий диск')UNION select * from Комплектующие where Цена=(Select Max(Цена) from Комплектующие where Категория='Видеокарта') UNION select * from Комплектующие where Цена=(Select Max(Цена) from Комплектующие where Категория='Звуковая карта') UNION select * from Комплектующие where Цена=(Select Max(Цена) from Комплектующие where Категория='Оперативная память') UNION select * from Комплектующие where Цена=(Select Max(Цена) from Комплектующие where Категория='Устройство охлаждения') UNION select * from Комплектующие where Цена=(Select Max(Цена) from Комплектующие where Категория='Материнская плата')", sqlconn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlconn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                try
                {
                    OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|курсач.accdb");
                    sqlconn.Open();
                    OleDbDataAdapter oda = new OleDbDataAdapter("select * from Комплектующие where Цена=679 and Категория='Процессор' UNION select * from Комплектующие where Цена=1007 and Категория='Жёсткий диск' UNION select * from Комплектующие where Цена=771 and Категория='Видеокарта' UNION select * from Комплектующие where Цена=1346 and Категория='Звуковая карта' UNION select * from Комплектующие where Цена=673 and Категория='Оперативная память' UNION select * from Комплектующие where Цена=201 and Категория='Устройство охлаждения' UNION select * from Комплектующие where Цена=558 and Категория='Материнская плата'", sqlconn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlconn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            if (comboBox1.SelectedIndex == 0)
            {
                try
                {
                    OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|курсач.accdb");
                    sqlconn.Open();
                    OleDbDataAdapter oda = new OleDbDataAdapter("select * from Комплектующие where Цена=(Select Min(Цена) from Комплектующие where Категория='Процессор') UNION select * from Комплектующие where Цена=(Select Min(Цена) from Комплектующие where Категория='Жёсткий диск')UNION select * from Комплектующие where Цена=(Select Min(Цена) from Комплектующие where Категория='Видеокарта') UNION select * from Комплектующие where Цена=(Select Min(Цена) from Комплектующие where Категория='Звуковая карта') UNION select * from Комплектующие where Цена=(Select Min(Цена) from Комплектующие where Категория='Оперативная память') UNION select * from Комплектующие where Цена=(Select Min(Цена) from Комплектующие where Категория='Устройство охлаждения') UNION select * from Комплектующие where Цена=(Select Min(Цена) from Комплектующие where Категория='Материнская плата')", sqlconn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlconn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            int cost = 0;
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                cost += int.Parse(dataGridView1[6, i].Value.ToString());
            }
            label2.Text = cost.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Нужно ли сохранять отчет о заказе?", "Отчет", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int cost = 0;
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    cost += int.Parse(dataGridView1[6, i].Value.ToString());
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Файлы Microsoft Office Excel | *.xls";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Excel.WriteToExcelFile(dataGridView1, saveFileDialog.FileName, "Заказ", cost.ToString());
                }
                MessageBox.Show("Файл сохранен");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
