	
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.CSharp;

namespace PC
{
    class Excel
    {
        public static void WriteToExcelFile(DataGridView dataGridView, string path, string title, string sum)
{
Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
Worksheet worksheet = workbook.Sheets[1];

char c = (char)(64 + dataGridView.Columns.Count-1);
worksheet.get_Range("A1", c + "1").Merge(false);
worksheet.Cells[1, 1].Value = title;
worksheet.Cells[1, 1].HorizontalAlignment = XlVAlign.xlVAlignCenter;
worksheet.Cells[1, 1].Interior.ColorIndex = 34;
worksheet.Cells[1, 1].Font.Size = 14;

for (int j = 0; j < dataGridView.Columns.Count-1; j++)
{
worksheet.Cells[2, j + 1].Value = dataGridView.Columns[j].HeaderText;
worksheet.Cells[2, j + 1].HorizontalAlignment = XlVAlign.xlVAlignCenter;
worksheet.Cells[2, j + 1].Interior.ColorIndex = 37;

for (int i = 0; i < dataGridView.Rows.Count; i++)
{
object value = dataGridView.Rows[i].Cells[j].Value;
if (value != null)
{
worksheet.Cells[i + 3, j + 1].Value = value.ToString();
}
}
}
worksheet.Cells[dataGridView.Rows.Count + 4, 1].Value = "Дата";
worksheet.Cells[dataGridView.Rows.Count + 4, 2].Value = DateTime.Now.Date.ToString();

worksheet.Cells[dataGridView.Rows.Count + 6, 4].Value = "Подпись";

worksheet.Cells[dataGridView.Rows.Count +4, 4].Value = "Общая сумма";
worksheet.Cells[dataGridView.Rows.Count +4, 5].Value = sum;

worksheet.Columns.AutoFit();
workbook.SaveAs(path);

workbook.Close();
excel.Quit();
}
public static void WriteToExcelFile(DataGridView dataGridView, string path, string title)
{
Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
Worksheet worksheet = workbook.Sheets[1];

char c = (char)(64 + dataGridView.Columns.Count - 1);
worksheet.get_Range("A1", c + "1").Merge(false);
worksheet.Cells[1, 1].Value = title;
worksheet.Cells[1, 1].HorizontalAlignment = XlVAlign.xlVAlignCenter;
worksheet.Cells[1, 1].Interior.ColorIndex = 34;
worksheet.Cells[1, 1].Font.Size = 14;

for (int j = 0; j < dataGridView.Columns.Count; j++)
{
worksheet.Cells[2, j + 1].Value = dataGridView.Columns[j].HeaderText;
worksheet.Cells[2, j + 1].HorizontalAlignment = XlVAlign.xlVAlignCenter;
worksheet.Cells[2, j + 1].Interior.ColorIndex = 37;

for (int i = 0; i < dataGridView.Rows.Count; i++)
{
object value = dataGridView.Rows[i].Cells[j].Value;
if (value != null)
{
worksheet.Cells[i + 3, j + 1].Value = value.ToString();
}
}
}


worksheet.Columns.AutoFit();
workbook.SaveAs(path);

workbook.Close();
excel.Quit();
}


}
    }

