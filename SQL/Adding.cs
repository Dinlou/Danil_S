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
    public partial class Adding : Form
    {
        public Adding()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "product")
            {
                textBox4.Visible = false;
                textBox4.Enabled = false;
                label4.Visible = false;
                label1.Text = "Name";
                label2.Text = "Qty";
                label3.Text = "Value";
            }
            else
            {
                textBox4.Visible = true;
                textBox4.Enabled = true;
                label4.Visible = true;
                label1.Text = "Login";
                label2.Text = "Password";
                label3.Text = "FName";
                label4.Text = "LName";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            if (comboBox1.Text == "users")
            {
                MySqlCommand command = new MySqlCommand("Insert into" + "`" + comboBox1.Text + "`" + "(Login,Password,FName,LName) values(" + "'" +textBox1.Text + "'" + "," + "'" + textBox2.Text + "'" + "," + "'" + textBox3.Text + "'" + "," + "'" + textBox4.Text + "'" + ")", db.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                }
            }
            else
            {
                MySqlCommand command = new MySqlCommand("Insert into" + "`" + comboBox1.Text + "`" + "(Name,Qty,Value) values(" + "'" + textBox1.Text + "'" + "," + "'" + textBox2.Text + "'" + "," + "'" + textBox3.Text + "'" + ")", db.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                }
            }

        }
    }
}
