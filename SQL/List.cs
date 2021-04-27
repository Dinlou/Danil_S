using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("Select * from `users`", db.getConnection());
            dataGridView1.DataSource = command;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                dataGridView1.DataSource = table;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("Select * from"+"`"+comboBox1.Text+"`", db.getConnection());
            dataGridView1.DataSource = command;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                dataGridView1.DataSource = table;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Change ad = new Change();
            ad.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Adding add = new Adding();
            add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("Delete from" + "`" + comboBox1.Text + "`"+"where id="+ textBox1.Text, db.getConnection());
            dataGridView1.DataSource = command;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                dataGridView1.DataSource = table;
            }
        }
    }
}
