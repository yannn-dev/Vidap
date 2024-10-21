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
using System.Xml.Linq;

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

        private DayOfWeek ultimoDia;

        public AtividadesForm()
        {
            ultimoDia = DateTime.Now.DayOfWeek;
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

            DayOfWeek diaAtual = DateTime.Now.DayOfWeek;

            if (diaAtual != ultimoDia)
            {
                foreach (var atividade in AtividadesDoDia)
                {
                    atividade.Concluida = false;
                }

                ultimoDia = diaAtual;
            }

            AtividadesDoDia = new List<Atividade>();

            DayOfWeek diaDaSemana = DateTime.Now.DayOfWeek;

            switch (diaDaSemana)
            {
                case DayOfWeek.Monday:
                    AtividadesDoDia.Add(new Atividade("\tAtividades de hoje"));
                    break;
                case DayOfWeek.Tuesday:
                    AtividadesDoDia.Add(new Atividade("\tAtividades de hoje"));
                    break;
                case DayOfWeek.Wednesday:
                    AtividadesDoDia.Add(new Atividade("\tAtividades de hoje"));
                    break;
                case DayOfWeek.Thursday:
                    AtividadesDoDia.Add(new Atividade("\tAtividades de hoje"));
                    break;
                case DayOfWeek.Friday:
                    AtividadesDoDia.Add(new Atividade("\tAtividades de hoje"));
                    break;
                case DayOfWeek.Saturday:
                    AtividadesDoDia.Add(new Atividade("\tAtividades de hoje"));
                    break;
                case DayOfWeek.Sunday:
                    AtividadesDoDia.Add(new Atividade("\tAtiv idades de hoje"));
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
            CarregarAtividades();
            if (System.IO.File.Exists("concluidos.txt"))
            {
                var itensConcluidos = System.IO.File.ReadAllLines("concluidos.txt");
                foreach(var item in itensConcluidos)
                {

                    var atividade = AtividadesDoDia.FirstOrDefault(a => a.Nome == item);
                    if (atividade != null)
                    {
                        atividade.Concluida = true;
                    }
                }
            }

            AtualizarListBox();

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Vidap form1 = new Vidap();
            form1.WindowState = this.WindowState;
            form1.Show();
            this.Close();
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

        private void listBoxAtividades_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DayOfWeek diaDaSemana = DateTime.Now.DayOfWeek;
            
            switch (diaDaSemana)
            {
                case DayOfWeek.Monday:
                    atividadesSegunda atvSegunda = new atividadesSegunda();
                    atvSegunda.Show();
                    this.Close();
                    break;

                case DayOfWeek.Tuesday:
                    atividadesTerca atvTerca = new atividadesTerca();
                    atvTerca.Show();
                    this.Close();
                    break;

                case DayOfWeek.Wednesday:
                    AtividadesQuarta atvQuarta = new AtividadesQuarta();
                    atvQuarta.Show();
                    this.Close();
                    break;

                case DayOfWeek.Thursday:
                    AtividadesQuinta atvQuinta = new AtividadesQuinta();
                    atvQuinta.Show();
                    this.Close();
                    break;
                
                case DayOfWeek.Friday:
                    AtividadesSexta atvSexta = new AtividadesSexta();
                    atvSexta.Show();
                    this.Close();
                    break;

                case DayOfWeek.Saturday:
                    AtividadesSabado atvSabado = new AtividadesSabado();
                    atvSabado.Show();
                    this.Close();
                    break;

                case DayOfWeek.Sunday:
                    AtividadesDomingo atvDomingo = new AtividadesDomingo();
                    atvDomingo.Show();
                    this.Close();
                    break;
            
            }       
        }

        private void AtividadesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SalvarAtividadesConcluidas();
        }

        private void SalvarAtividadesConcluidas()
        {
            var atividadesConcluidas = AtividadesDoDia
                .Where(a => a.Concluida)
                .Select(a => a.Nome)
                .ToList();

            System.IO.File.WriteAllLines("concluidos.txt", atividadesConcluidas);
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            if (listBoxAtividades.SelectedIndex != -1)
            {
                AtividadesDoDia[listBoxAtividades.SelectedIndex].Concluida = false;
                AtualizarListBox();
            }
            else
            {
                MessageBox.Show("Selecione uma atividade para desmarcar como feita.");
            }
        }
    }
}
