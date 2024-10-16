using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auxílio_de_qualidade_de_vida_para_o_idoso
{
    public partial class AtividadesForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public class Atividade
        {
            public string Nome { get; set; }
            public bool Concluida { get; set; }

            public Atividade(string nome)
            {
                Nome = nome;
                Concluida = false;
            }
        }

        public List<Atividade> AtividadesDoDia { get; set; }

        public AtividadesForm()
        {
            InitializeComponent();
            CarregarAtividades();
            AtualizarListBox();
            Esconder();
        }

        private void Esconder()
        {
            btnRestaurar.Visible = false;
        }

        private void CarregarAtividades()
        {
            AtividadesDoDia = new List<Atividade>();

            DayOfWeek diaDaSemana = DateTime.Now.DayOfWeek;

            switch (diaDaSemana)
            {
                case DayOfWeek.Monday:
                    AtividadesDoDia.Add(new Atividade("Caminhada"));
                    AtividadesDoDia.Add(new Atividade("Leitura"));
                    break;
                case DayOfWeek.Tuesday:
                    AtividadesDoDia.Add(new Atividade("Exercícios de alongamento"));
                    AtividadesDoDia.Add(new Atividade("Jardinagem"));
                    break;
                case DayOfWeek.Wednesday:
                    AtividadesDoDia.Add(new Atividade("Caminhada"));
                    AtividadesDoDia.Add(new Atividade("Jogos de tabuleiro"));
                    break;
                // Adicione casos para os outros dias da semana
                default:
                    AtividadesDoDia.Add(new Atividade("Relaxar e meditar"));
                    break;
            }
        }

        private void AtualizarListBox()
        {
            listBoxAtividades.Items.Clear();
            foreach (var atividade in AtividadesDoDia)
            {
                listBoxAtividades.Items.Add($"{atividade.Nome} - {(atividade.Concluida ? "Feita" : "Pendente")}");
            }
        }

        private void btnMarcarComoFeita_Click(object sender, EventArgs e)
        {
            if (listBoxAtividades.SelectedIndex != -1)
            {
                AtividadesDoDia[listBoxAtividades.SelectedIndex].Concluida = true;
                AtualizarListBox();
            }
            else
            {
                MessageBox.Show("Selecione uma atividade para marcar como feita.");
            }
        }

        private void AtividadesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
            Vidap form1 = new Vidap();
            form1.Show();
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
            Vidap form1 = new Vidap();
            form1.Show();
        }

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
