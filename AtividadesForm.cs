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
                    AtividadesDoDia.Add(new Atividade("\tAtividades de Segunda"));
                    AtividadesDoDia.Add(new Atividade("\tDica: Faça uma caminhada"));
                    break;
                case DayOfWeek.Tuesday:
                    AtividadesDoDia.Add(new Atividade("\tAtividades de Terça"));
                    AtividadesDoDia.Add(new Atividade("\tDica: Cuide de suas plantas"));
                    break;
                case DayOfWeek.Wednesday:
                    AtividadesDoDia.Add(new Atividade("\tAtividades de Quarta"));
                    AtividadesDoDia.Add(new Atividade("Dica: Leia, algum livro de seu interesse"));
                    break;
                case DayOfWeek.Thursday:
                    AtividadesDoDia.Add(new Atividade("\tAtividades de Quinta"));
                    AtividadesDoDia.Add(new Atividade("Dica: Bata um papo com as pessoas que conhece"));
                    break;
                case DayOfWeek.Friday:
                    AtividadesDoDia.Add(new Atividade("\tAtividades de Sexta"));
                    AtividadesDoDia.Add(new Atividade("\tDica: Relaxe"));                    
                    break;
                case DayOfWeek.Saturday:
                    AtividadesDoDia.Add(new Atividade("\tAtividades de Sábado"));
                    AtividadesDoDia.Add(new Atividade("\tDica: Cuide de suas plantas"));
                    AtividadesDoDia.Add(new Atividade("\tDica: Relaxe"));
                    break;
                case DayOfWeek.Sunday:
                    AtividadesDoDia.Add(new Atividade("\tAtividades de Domingo"));
                    AtividadesDoDia.Add(new Atividade("\tDica: Se divirta!"));
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
                        TelaAjudaSeg telaAjudaSeg = new TelaAjudaSeg();
                        telaAjudaSeg.Show();
                        break;
                    case DayOfWeek.Tuesday:
                        TelaAjudaTer telaAjudaTer = new TelaAjudaTer();
                        telaAjudaTer.Show();
                        break;
                    case DayOfWeek.Wednesday:
                        TelaAjudaQua telaAjudaQua = new TelaAjudaQua();
                        telaAjudaQua.Show();
                        break;
                    case DayOfWeek.Thursday:
                        TelaAjudaQui telaAjudaQui = new TelaAjudaQui();
                        telaAjudaQui.Show();
                        break;
                    case DayOfWeek.Friday:
                        TelaAjudaSex telaAjudaSex = new TelaAjudaSex();
                        telaAjudaSex.Show();
                        break;
                    case DayOfWeek.Saturday:
                        TelaAjudaSab telaAjudaSab = new TelaAjudaSab();
                        telaAjudaSab.Show();
                        break;
                    case DayOfWeek.Sunday:
                        TelaAjudaDom telaAjudaDom = new TelaAjudaDom();
                        telaAjudaDom.Show();
                        break;
                }
            }
            else
            {
                TelaAjudaPadrao telaAjudaPadrao = new TelaAjudaPadrao();
                telaAjudaPadrao.Show();
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
                SeVerNada telaSeNVer = new SeVerNada();
                telaSeNVer.Show();
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
                SeDesNada telaSeNDes = new SeDesNada();
                telaSeNDes.Show();
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
            btnMaximizar.Visible = false;
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

        private void btnAtividades_Click(object sender, EventArgs e)
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
    }
}
