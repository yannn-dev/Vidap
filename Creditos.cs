using System;
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
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
            Arranjo_BtnMaxEMin();
        }

        private void Arranjo_BtnMaxEMin()
        {


            if (this.WindowState == FormWindowState.Maximized)
            {
                btnRestaurar.Visible = true;
                btnMaximizar.Visible = false;
            }

            else if (this.WindowState == FormWindowState.Normal)
            {
                btnRestaurar.Visible = false;
                btnMaximizar.Visible = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Vidap form1 = new Vidap();
            form1.WindowState = this.WindowState;
            form1.Show();
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Vidap form1 = new Vidap();
            form1.WindowState = this.WindowState;
            form1.Show();
            this.Close();
        }
    }
}
