﻿using LetsBloob_2.Banco_de_Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsBloob_2
{
    public partial class frm_Consultas : Form
    {
        public frm_Consultas()
        {
            InitializeComponent();
        }

        private void frm_Consultas_Load(object sender, EventArgs e)
        {
            CarregarDataGridView();
        }

        private void CarregarDataGridView()
        {
            Class1 contatoDao = new Class1();
            DataSet ds = contatoDao.GetDoadores();
            dataGridView1.DataSource = ds.Tables["doador"];
            dataGridView1.Refresh();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}