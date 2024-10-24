﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Auxílio_de_qualidade_de_vida_para_o_idoso
{
    public partial class Vidap : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Vidap()
        {
            InitializeComponent();
            Esconder();
        }

        private void Esconder()
        {
            btnRestaurar.Visible = false;
            lblCreditos.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            Dock = DockStyle.Fill;

        }

        private void Introducao_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreditos_Click_1(object sender, EventArgs e)
        {
            lblIntroducao.Text = string.Empty;
            lblCreditos.Visible = true;
            lblInstrucao.Text = "\nEquipe de Desenvolvimento:\n" +
                "Filipe Pereira Ferraz\n" +
                "Kaique Rabesco Valverde\n" +
                "Matheus Eduardo Nunhez\n" +
                "Rafaela Sanchez\n\n" +
                "Colaboradores:\n" +
                "Elisa Pereira Ferraz\n\n" +
                "Professor Orientador:\n" +
                "Elvio Gilberto da Silva\n" +
                "\nObrigado por utilizar o Vidap!";
        }

        private void comoFunciona_Click(object sender, EventArgs e)
        {
            comoFunciona ComoFunciona = new comoFunciona();
            ComoFunciona.WindowState = this.WindowState;
            ComoFunciona.Show();
            this.Hide();
        }

        private void btnAtividades_Click_Click(object sender, EventArgs e)
        {
            AtividadesForm atividadesForm = new AtividadesForm();
            atividadesForm.WindowState = this.WindowState;  
            atividadesForm.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
