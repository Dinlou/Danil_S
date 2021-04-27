using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;

namespace Project_22042021
{
    public partial class Export : Form
    {
        public Export()
        {         
            InitializeComponent();
        }
        public void sokrash()
        {
            DB db = new DB();
            System.Data.DataTable table = new System.Data.DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter();
            MySqlCommand prekol = new MySqlCommand(uwu.com, db.getConnection());
            ad.SelectCommand = prekol;
            ad.Fill(table);
            dataGridView1.DataSource = table;

        }
        public DataGridView hhh;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            sokrash();          
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
           {
               for (int j = 0; j < dataGridView1.ColumnCount; j++)
               {
                   ExcelApp.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
               }
           }
            MessageBox.Show(Convert.ToString(dataGridView1.Rows.Count)+"-СТРОКИ");
            MessageBox.Show(Convert.ToString(dataGridView1.ColumnCount)+"-СТОЛБЦЫ");
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
