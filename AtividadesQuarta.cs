﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auxílio_de_qualidade_de_vida_para_o_idoso
{
    public partial class AtividadesQuarta : Form
    {
        public AtividadesQuarta()
        {
            InitializeComponent();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            AtividadesForm frm = new AtividadesForm();
            frm.WindowState = this.WindowState;
            frm.Show();
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            AtividadesForm form = new AtividadesForm();
            form.WindowState = this.WindowState;
            form.Show();
            this.Hide();
        }
    }
}
