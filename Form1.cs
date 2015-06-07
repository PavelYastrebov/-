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
using System.Drawing.Drawing2D;
using System.Drawing.Printing;

namespace PC
{
    public partial class Form1 : Form
    {
        string ID1, name1, type1, category1, brend1, kharacteristic1, cost1, nalichie1, garantiya1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|курсач.accdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter("select * from Комплектующие", sqlconn);
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|курсач.accdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter("select * from Комплектующие where категория='процессор'", sqlconn);
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
                OleDbDataAdapter oda = new OleDbDataAdapter("select * from Комплектующие where категория='жёсткий диск'", sqlconn);
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|курсач.accdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter("select * from Комплектующие where категория='звуковая карта'", sqlconn);
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|курсач.accdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter("select * from Комплектующие where категория='видеокарта'", sqlconn);
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|курсач.accdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter("select * from Комплектующие where категория='оперативная память'", sqlconn);
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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|курсач.accdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter("select * from Комплектующие where категория='устройство охлаждения'", sqlconn);
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

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|курсач.accdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter("select * from Комплектующие where категория='материнская плата'", sqlconn);
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
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|курсач.accdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter("select * from Комплектующие", sqlconn);
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string picture1 = "";
                string picture2 = "";
                picture1 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                picture2 = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                FillRight(picture1, picture2);
            }
            catch { }
        }
        void FillRight(string Pname, string Sname)
        {
            if (Pname == "") this.pictureBox1.Image.Dispose();
            if (Sname == "") this.pictureBox2.Image.Dispose();
            string file1 = "Image//" + Pname + ".jpg";
            string file2 = "Image//" + Sname + ".png";
            Image image1 = Image.FromFile(file1);
            Image image2 = Image.FromFile(file2);
            this.pictureBox1.Image = image1;
            this.pictureBox2.Image = image2;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[3, i].Value.ToString().ToLower().Contains(textBox1.Text.ToLower()))
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++) dataGridView1.Rows[j].Selected = false;
                    dataGridView1.Rows[i].Selected = true;
                    if (i > 5) dataGridView1.FirstDisplayedCell = dataGridView1[0, i - 5];
                    return;
                }
            }
        }

        private void свободныйЗапросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Query();
            form.ShowDialog();
        }

        private void добавлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new EditForm(); f.ShowDialog();
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|курсач.accdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter("select * from Комплектующие", sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            курсачDataSet1.AcceptChanges();
        }

        private void редактирование2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new UPDATE(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString(),
                dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString(),
                dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString(),
                dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString(),
                dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString(),
                dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString(),
                dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString(),
                dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString(),
                dataGridView1[8, dataGridView1.CurrentRow.Index].Value.ToString());
            f.ShowDialog();
            курсачDataSet1.AcceptChanges();
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|курсач.accdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter("select * from Комплектующие", sqlconn);
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

        private void удалениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Данная строка будет удалена , вы уверенны?", "Удаление", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                комплектующиеTableAdapter1.DeleteQuery(int.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()));
                MessageBox.Show("Товар был удален");
                try
                {
                    OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|курсач.accdb");
                    sqlconn.Open();
                    OleDbDataAdapter oda = new OleDbDataAdapter("select * from Комплектующие", sqlconn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlconn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
                курсачDataSet1.AcceptChanges();
            }
            if (dr == DialogResult.No)
            {
                return;
            }
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Statistica();
            form.ShowDialog();
        }

        private void отчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ID1 = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
               name1 =  dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
               type1 =  dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
               category1 =  dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
               brend1 = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
               kharacteristic1 =  dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
               cost1 =  dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
               garantiya1 =  dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
               nalichie1 =  dataGridView1[8, dataGridView1.CurrentRow.Index].Value.ToString();
            var PD = new System.Drawing.Printing.PrintDocument();
            PD.PrintPage += PD_PrintPage;
            var t = new PrintPreviewDialog();
            t.Document = PD;
            t.ShowDialog();


        }
        private void PD_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font PrintFont1 = new Font("Times New Roman", 14, FontStyle.Italic, GraphicsUnit.Millimeter);
            Font PrintFont2 = new Font("Times New Roman", 11, FontStyle.Italic, GraphicsUnit.Millimeter);
            e.Graphics.DrawImage(ResizeImg(Image.FromFile("Image//" + ID1.ToString() + ".jpg"), 400, 400), 350, 100);
            e.Graphics.DrawString(name1, PrintFont1, Brushes.Black, new PointF(10, 0));
            e.Graphics.DrawString(category1, PrintFont2, Brushes.Black, new PointF(10, 100));
            e.Graphics.DrawString("Цена:" + cost1, PrintFont2, Brushes.Black, new PointF(10, 150));
            e.Graphics.DrawString("Кол-во:" + garantiya1, PrintFont2, Brushes.Black, new PointF(10, 200));
            e.Graphics.DrawString(kharacteristic1, PrintFont2, Brushes.Black, new Rectangle(10, 520, 800, 800));
            e.Graphics.DrawString(brend1, PrintFont2, Brushes.Black, new PointF(10, 850));
            e.Graphics.DrawImage(ResizeImg(Image.FromFile("Image//" + brend1.ToString() + ".png"), 300, 300), 450, 850);
        }
        public Image ResizeImg(Image b, int nWidth, int nHeight)
        {
            Image result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)result))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(b, 0, 0, nWidth, nHeight);
                g.Dispose();
            }
            return result;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var form = new information(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString(),
                dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString(),
                dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString(),
                dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString(),
                dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString(),
                dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString(),
                dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString(),
                dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString());
            form.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == String.Empty || textBox3.Text == String.Empty)
            {
                MessageBox.Show("Поля цен должны быть заполнены");
                textBox2.Text = "0";
                textBox3.Text = "10000";
                return;
            }
            if (true)
            {
                try
                {
                    OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\курсач.accdb");
                    sqlconn.Open();
                    OleDbDataAdapter oda = new
                    OleDbDataAdapter("select * from Комплектующие where Цена between " + Convert.ToInt32(textBox2.Text) + " AND " + Convert.ToInt32(textBox3.Text) + ";", sqlconn);
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

        private void товарОтПроизводителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Supplier();
            form.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int month = rnd.Next(100000, 999999);
                        Random rnd1 = new Random();
            int month1 = rnd.Next(1, 100);
            покупкаTableAdapter1.Insert(month,1,
                int.Parse(dataGridView1[0,dataGridView1.CurrentRow.Index].Value.ToString()),12,1,DateTime.Now,int.Parse(dataGridView1[6,dataGridView1.CurrentRow.Index].Value.ToString()));
            курсачDataSet1.AcceptChanges();
            MessageBox.Show("Товар добавлен в корзину");
        }

        private void купитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Buy();
            form.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection sqlconn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|курсач.accdb");
                sqlconn.Open();
                OleDbDataAdapter oda = new OleDbDataAdapter("select * from Комплектующие order by Категория, Цена", sqlconn);
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

        private void укомплектоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Complect();
            f.ShowDialog();
        }
    }
}