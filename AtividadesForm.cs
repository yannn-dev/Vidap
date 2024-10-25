using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private DateTime ultimaDataVerificada;

        public AtividadesForm()
        {
            InitializeComponent();
            CarregarUltimaData();
            Esconder();
        }

        private void CarregarUltimaData()
        {
            if (File.Exists("ultimaData.txt"))
            {
                string dataStr = File.ReadAllText("ultimaData.txt");
                ultimaDataVerificada = DateTime.Parse(dataStr);
            } 
            else
            {
                ultimaDataVerificada = DateTime.Now;
            }
        }

        private void SalvarUltimaData()
        {
            File.WriteAllText("ultimaData.txt", DateTime.Now.ToString());
        }

        private void VerificarTrocaDeDia()
        {
            if (DateTime.Now.Date != ultimaDataVerificada.Date)
            {
                foreach (var atividade in AtividadesDoDia)
                {
                    atividade.Concluida = false;
                }

                ultimaDataVerificada = DateTime.Now;

                AtualizarListBox();

            }
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
                    AtividadesDoDia.Add(new Atividade("\tAtividades de segunda"));
                    AtividadesDoDia.Add(new Atividade("\tCaminhada"));
                    break;
                case DayOfWeek.Tuesday:
                    AtividadesDoDia.Add(new Atividade("\tAtividades de terça"));
                    AtividadesDoDia.Add(new Atividade("\tCuide de suas plantas (caso não tiver, desconsidere)."));
                    break;
                case DayOfWeek.Wednesday:
                    AtividadesDoDia.Add(new Atividade("\tAtividades de quarta"));
                    AtividadesDoDia.Add(new Atividade("\tLeitura"));
                    break;
                case DayOfWeek.Thursday:
                    AtividadesDoDia.Add(new Atividade("\tAtividades de quinta"));
                    AtividadesDoDia.Add(new Atividade("\tSocializar"));
                    break;
                case DayOfWeek.Friday:
                    AtividadesDoDia.Add(new Atividade("\tAtividades de sexta"));
                    AtividadesDoDia.Add(new Atividade("\tRelaxamento e lazer"));
                    break;
                case DayOfWeek.Saturday:
                    AtividadesDoDia.Add(new Atividade("\tAtividades de sábado"));
                    AtividadesDoDia.Add(new Atividade("\tCuide de suas plantas (caso não tiver, desconsidere)"));
                    AtividadesDoDia.Add(new Atividade("\tRelaxamento e lazer"));
                    break;
                case DayOfWeek.Sunday:
                    AtividadesDoDia.Add(new Atividade("\tAtividades de domingo"));
                    AtividadesDoDia.Add(new Atividade("\tDia livre"));
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

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            if (listBoxAtividades.SelectedIndex != -1)
            {
                DayOfWeek diaDaSemana = DateTime.Now.DayOfWeek;

                switch (diaDaSemana) 
                {
                    case DayOfWeek.Monday:
                        MessageBox.Show("Faça as atividades propostas do dia (clique duas vezes no quadrado grande para exibir).\n" +
                            "Faça uma caminhada ao livre pelo tempo que desejar.");
                        break;
                    case DayOfWeek.Tuesday:
                        MessageBox.Show("Faça as atividades propostas do dia (clique duas vezes no quadrado grande para exibir).\n" +
                            "Separe um tempo do dia para cuidar de suas plantas.");
                        break;
                    case DayOfWeek.Wednesday:
                        MessageBox.Show("Faça as atividades propostas do dia (clique duas vezes no quadrado grande para exibir).\n" +
                            "Leia algumas páginas de qualquer livro que te agrade.");
                        break;
                    case DayOfWeek.Thursday:
                        MessageBox.Show("Faça as atividades propostas do dia (clique duas vezes no quadrado grande para exibir).\n" +
                            "Converse com alguem, vá à clubes do livro, grupos de oração, o que mais te agradar.");
                        break;
                    case DayOfWeek.Friday:
                        MessageBox.Show("Faça as atividades propostas do dia (clique duas vezes no quadrado grande para exibir).\n" +
                            "Relaxe e faça alguma coisa que te traga conforto, como assistir televisão, cozinhar etc.");
                        break;
                    case DayOfWeek.Saturday:
                        MessageBox.Show("Faça as atividades propostas do dia (clique duas vezes no quadrado grande para exibir).\n" +
                            "Separe um tempo do dia para cuidar de suas plantas.\n" +
                            "Relaxe e faça alguma coisa que te traga conforto, como assistir televisão, cozinhar etc.");
                        break;
                    case DayOfWeek.Sunday:
                        MessageBox.Show("Faça as atividades propostas do dia (clique duas vezes no quadrado grande para exibir).\n" +
                            "Dia livre.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Clique na atividade que deseja receber ajuda.");
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
        private void AtividadesForm_Load(object sender, EventArgs e)
        {
            CarregarAtividades();
            CarregarAtividadesConcluidas();
            VerificarTrocaDeDia();
            AtualizarListBox();
        }

        private void CarregarAtividadesConcluidas()
        {
            if (File.Exists("concluidos.txt"))
            {
                var itensConcluidos = File.ReadAllLines("concluidos.txt");
                foreach (var item in itensConcluidos)
                {

                    var atividade = AtividadesDoDia.FirstOrDefault(a => a.Nome == item);
                    if (atividade != null)
                    {
                        atividade.Concluida = true;
                    }
                }
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
            Vidap form1 = new Vidap();
            form1.WindowState = this.WindowState;
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
            form1.WindowState = this.WindowState;
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
                    atvSegunda.WindowState = this.WindowState;
                    atvSegunda.Show();
                    this.Close();
                    break;

                case DayOfWeek.Tuesday:
                    atividadesTerca atvTerca = new atividadesTerca();
                    atvTerca.WindowState = this.WindowState;
                    atvTerca.Show();
                    this.Close();
                    break;

                case DayOfWeek.Wednesday:
                    AtividadesQuarta atvQuarta = new AtividadesQuarta();
                    atvQuarta.WindowState = this.WindowState;
                    atvQuarta.Show();
                    this.Close();
                    break;

                case DayOfWeek.Thursday:
                    AtividadesQuinta atvQuinta = new AtividadesQuinta();
                    atvQuinta.WindowState = this.WindowState;
                    atvQuinta.Show();
                    this.Close();
                    break;
                
                case DayOfWeek.Friday:
                    AtividadesSexta atvSexta = new AtividadesSexta();
                    atvSexta.WindowState = this.WindowState;
                    atvSexta.Show();
                    this.Close();
                    break;

                case DayOfWeek.Saturday:
                    AtividadesSabado atvSabado = new AtividadesSabado();
                    atvSabado.WindowState = this.WindowState;
                    atvSabado.Show();
                    this.Close();
                    break;

                case DayOfWeek.Sunday:
                    AtividadesDomingo atvDomingo = new AtividadesDomingo();
                    atvDomingo.WindowState = this.WindowState;
                    atvDomingo.Show();
                    this.Close();
                    break;
            
            }       
        }

        private void AtividadesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SalvarAtividadesConcluidas();
            SalvarUltimaData();
        }

        private void SalvarAtividadesConcluidas()
        {
            var atividadesConcluidas = AtividadesDoDia
                .Where(a => a.Concluida)
                .Select(a => a.Nome)
                .ToList();

            File.WriteAllLines("concluidos.txt", atividadesConcluidas);
        }
    }
}
