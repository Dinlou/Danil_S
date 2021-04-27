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
    public partial class MainF : Form
    {
        public MainF()
        {
            InitializeComponent();




        }
        private void MainF_Load(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void периферияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uwu.com = "SELECT p.id_peri, pt.name, c.condname, p.qty, p.model FROM `peri` p, `peritypes` pt, `cond` c WHERE p.id_peritype = pt.id_peritype AND p.id_cond = c.id_cond";

            sokrash();
        }

        private void pCToolStripMenuItem_Click(object sender, EventArgs e)//Таблица ПК
        {
            uwu.com = "SELECT p.id_pc, c.condname , d.deptname, s.softname FROM `pc acc` p, `cond` c, `dept` d, `software` s WHERE p.id_cond = c.id_cond AND p.id_dept = d.id_dept AND p.id_soft = s.id_soft ORDER BY `id_pc`";
            
            sokrash();
        }

        private void пОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uwu.com = "SELECT* FROM software";

            sokrash();

            dataGridView1.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";

            dataGridView1.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login logf = new Login();

            this.Close();

            logf.Show();

        }

        private void комплектующиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uwu.com = "SELECT h.id_hardware, hd.name, c.condname, h.qty, h.model FROM `hardware` h, `hardtypes` hd, `cond` c WHERE h.id_hardtype = hd.id_hardtype AND h.id_cond = c.id_cond";

            sokrash();

        }

        private void sokrash()
        {                    
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter();
            MySqlCommand prekol = new MySqlCommand(uwu.com,db.getConnection());
            ad.SelectCommand = prekol;

            ad.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void название1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uwu.com = "SELECT d.id_dept, d.deptname, d.office, p.id_pc, c.condname, s.softname FROM dept d, `pc acc` p, cond c, software s WHERE d.deptname = " + "'" + название1ToolStripMenuItem + "'" + " AND p.id_dept = d.id_dept AND p.id_cond = c.id_cond AND p.id_soft = s.id_soft";

            sokrash();
        }

        private void название2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uwu.com = "SELECT d.id_dept, d.deptname, d.office, p.id_pc, c.condname, s.softname FROM dept d, `pc acc` p, cond c, software s WHERE d.deptname = " + "'" + название2ToolStripMenuItem + "'" + " AND p.id_dept = d.id_dept AND p.id_cond = c.id_cond AND p.id_soft = s.id_soft";
            sokrash();
        }

        private void redgraveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uwu.com = "SELECT d.id_dept, d.deptname, d.office, p.id_pc, c.condname, s.softname FROM dept d, `pc acc` p, cond c, software s WHERE d.deptname = " + "'" + redgraveToolStripMenuItem + "'" + " AND p.id_dept = d.id_dept AND p.id_cond = c.id_cond AND p.id_soft = s.id_soft";
            sokrash();
        }

        private void ukraineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uwu.com = "SELECT d.id_dept, d.deptname, d.office, p.id_pc, c.condname, s.softname FROM dept d, `pc acc` p, cond c, software s WHERE d.deptname = " + "'" + ukraineToolStripMenuItem + "'" + " AND p.id_dept = d.id_dept AND p.id_cond = c.id_cond AND p.id_soft = s.id_soft";
            sokrash();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Export exp = new Export();

            exp.Show();
        }
    }
}