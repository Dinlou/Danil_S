﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_22042021
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string connectionString = "server=localhost;port=3306;username=root;password=root;database=project";
            MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            connection.Open();

            String loginUser = textBox1.Text;
            String passUser = textBox2.Text;

            DB bd = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("Select * FROM `users` WHERE `login`= @uL AND `pass` = @uP", connection);

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;

            adapter.Fill(table);
            
            var name = new MySqlCommand($"Select p.postname FROM post p, users u WHERE u.login = @uk AND u.id_post = p.id_post", connection);
            
            name.Parameters.Add("@uk", MySqlDbType.VarChar).Value = loginUser;

            var rol = name.ExecuteScalar();

            var fio = new MySqlCommand("Select fname, lname, thname FROM users WHERE login = @ugh", connection);

            fio.Parameters.Add("@ugh", MySqlDbType.VarChar).Value = loginUser;

            MySqlDataReader reader = fio.ExecuteReader();

            if (table.Rows.Count > 0)
            {
                MainF mainr = new MainF();

                mainr.label2.Text = Convert.ToString(rol);
                while (reader.Read())
                {
                    mainr.label1.Text = reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2);
                }
                MessageBox.Show("Добро пожаловать, " + Convert.ToString(rol));

                mainr.Show();

                this.Hide();
            }
            else
                MessageBox.Show("No!");

            connection.Close();*/

            MainF mainr = new MainF();
            mainr.Show();

            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
