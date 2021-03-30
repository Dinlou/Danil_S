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
        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = LoginBox.Text;
            String passUser = PasBox.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("Select * FROM  `users` WHERE  `Login`= @uL AND `Password`= @uP ", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
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
