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
    public partial class Statistica : Form
    {
        public Statistica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|курсач.accdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter("select поставщик, count(ID_товара) as Количество_товаров from Комплектующие group by поставщик", sqlconn);
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

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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
    }
}
