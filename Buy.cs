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
    public partial class Buy : Form
    {
        public Buy()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            покупкаTableAdapter1.DeleteQuery(int.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()));
            курсачDataSet1.AcceptChanges();
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\курсач.accdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new
                OleDbDataAdapter("select * from Покупка;", sqlconn);
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

        private void Buy_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\курсач.accdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new
                OleDbDataAdapter("select * from Покупка;", sqlconn);
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
            покупкаTableAdapter1.DeleteQuery1();
            курсачDataSet1.AcceptChanges();
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\курсач.accdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new
                OleDbDataAdapter("select * from Покупка;", sqlconn);
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Нужно ли сохранять отчет о заказе?", "Отчет", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int cost = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
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
    }
}
