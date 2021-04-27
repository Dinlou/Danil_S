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
    public partial class Login_From : Form
    {
        public Login_From()
        {
            InitializeComponent();
        }
        MainMenu kik = new MainMenu();
        AdminCheck kk = new AdminCheck();
        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("Select * FROM  `users` WHERE  `Login` =" + "'" + LoginBox.Text + "'" + "AND" + " `Password` =" + "'" + PasBox.Text + "'"+"AND"+"`Status`= 'admin'", db.getConnection());           
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                AdminCheck.master = true;
                this.Hide();
                MessageBox.Show("Welcome ADMIN");
                kik.ShowDialog();
            }
            else
            {
                MySqlCommand funny = new MySqlCommand ("Select * FROM  `users` WHERE  `Login` =" + "'" + LoginBox.Text + "'" + "AND" + " `Password` =" + "'" + PasBox.Text + "'", db.getConnection());
                adapter.SelectCommand = funny;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    MessageBox.Show("Yes!");
                    kik.ShowDialog();
                }
                else
                    MessageBox.Show("No!");
            }


        }
    }
}
