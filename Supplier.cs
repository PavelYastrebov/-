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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\курсач.accdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new
                OleDbDataAdapter("select * from Поставщик;", sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\курсач.accdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new
                OleDbDataAdapter("select * from Комплектующие where Поставщик = 'Intel';", sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView2.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\курсач.accdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new
                OleDbDataAdapter("select * from Комплектующие where Поставщик = '"+dataGridView1[0,dataGridView1.CurrentRow.Index].Value.ToString()+"';", sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView2.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
