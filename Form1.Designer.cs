namespace Auxílio_de_qualidade_de_vida_para_o_idoso
{
    partial class Vidap
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vidap));
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.iconeTelas = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCreditos = new System.Windows.Forms.Button();
            this.comoFunciona = new System.Windows.Forms.Button();
            this.btnAtividades_Click = new System.Windows.Forms.Button();
            this.lblIntroducao = new System.Windows.Forms.Label();
            this.lblInstrucao = new System.Windows.Forms.Label();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeTelas)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(110)))), ((int)(((byte)(56)))));
            this.panelCabecalho.Controls.Add(this.iconeTelas);
            this.panelCabecalho.Controls.Add(this.btnRestaurar);
            this.panelCabecalho.Controls.Add(this.btnMaximizar);
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(1131, 56);
            this.panelCabecalho.TabIndex = 0;
            this.panelCabecalho.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // iconeTelas
            // 
            this.iconeTelas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconeTelas.BackgroundImage")));
            this.iconeTelas.Location = new System.Drawing.Point(-3, 0);
            this.iconeTelas.Name = "iconeTelas";
            this.iconeTelas.Size = new System.Drawing.Size(262, 80);
            this.iconeTelas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconeTelas.TabIndex = 3;
            this.iconeTelas.TabStop = false;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = global::Auxílio_de_qualidade_de_vida_para_o_idoso.Properties.Resources.maximizar;
            this.btnRestaurar.Location = new System.Drawing.Point(1005, 9);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(40, 30);
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::Auxílio_de_qualidade_de_vida_para_o_idoso.Properties.Resources.maximizar1;
            this.btnMaximizar.Location = new System.Drawing.Point(1045, 7);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(41, 34);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::Auxílio_de_qualidade_de_vida_para_o_idoso.Properties.Resources.fechar;
            this.btnFechar.Location = new System.Drawing.Point(1092, 10);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(27, 27);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.panelMenu.Controls.Add(this.btnCreditos);
            this.panelMenu.Controls.Add(this.comoFunciona);
            this.panelMenu.Controls.Add(this.btnAtividades_Click);
            this.panelMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 56);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(259, 651);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnCreditos
            // 
            this.btnCreditos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCreditos.FlatAppearance.BorderSize = 0;
            this.btnCreditos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(173)))));
            this.btnCreditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditos.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnCreditos.ForeColor = System.Drawing.Color.Black;
            this.btnCreditos.Image = ((System.Drawing.Image)(resources.GetObject("btnCreditos.Image")));
            this.btnCreditos.Location = new System.Drawing.Point(14, 444);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(215, 80);
            this.btnCreditos.TabIndex = 4;
            this.btnCreditos.UseVisualStyleBackColor = true;
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click_1);
            // 
            // comoFunciona
            // 
            this.comoFunciona.AutoSize = true;
            this.comoFunciona.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.comoFunciona.FlatAppearance.BorderSize = 0;
            this.comoFunciona.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(173)))));
            this.comoFunciona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comoFunciona.Font = new System.Drawing.Font("Tahoma", 18F);
            this.comoFunciona.ForeColor = System.Drawing.Color.Black;
            this.comoFunciona.Image = ((System.Drawing.Image)(resources.GetObject("comoFunciona.Image")));
            this.comoFunciona.Location = new System.Drawing.Point(14, 116);
            this.comoFunciona.Name = "comoFunciona";
            this.comoFunciona.Size = new System.Drawing.Size(215, 80);
            this.comoFunciona.TabIndex = 3;
            this.comoFunciona.UseVisualStyleBackColor = true;
            this.comoFunciona.Click += new System.EventHandler(this.comoFunciona_Click);
            // 
            // btnAtividades_Click
            // 
            this.btnAtividades_Click.AutoSize = true;
            this.btnAtividades_Click.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAtividades_Click.FlatAppearance.BorderSize = 0;
            this.btnAtividades_Click.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(173)))));
            this.btnAtividades_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtividades_Click.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btnAtividades_Click.ForeColor = System.Drawing.Color.Black;
            this.btnAtividades_Click.Image = ((System.Drawing.Image)(resources.GetObject("btnAtividades_Click.Image")));
            this.btnAtividades_Click.Location = new System.Drawing.Point(14, 274);
            this.btnAtividades_Click.Name = "btnAtividades_Click";
            this.btnAtividades_Click.Size = new System.Drawing.Size(215, 80);
            this.btnAtividades_Click.TabIndex = 1;
            this.btnAtividades_Click.UseVisualStyleBackColor = true;
            this.btnAtividades_Click.Click += new System.EventHandler(this.btnAtividades_Click_Click);
            // 
            // lblIntroducao
            // 
            this.lblIntroducao.AutoSize = true;
            this.lblIntroducao.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroducao.Location = new System.Drawing.Point(530, 59);
            this.lblIntroducao.Name = "lblIntroducao";
            this.lblIntroducao.Size = new System.Drawing.Size(343, 35);
            this.lblIntroducao.TabIndex = 2;
            this.lblIntroducao.Text = "Seja bem-vindo ao Vidap!";
            // 
            // lblInstrucao
            // 
            this.lblInstrucao.AutoSize = true;
            this.lblInstrucao.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucao.Location = new System.Drawing.Point(348, 193);
            this.lblInstrucao.Name = "lblInstrucao";
            this.lblInstrucao.Size = new System.Drawing.Size(718, 175);
            this.lblInstrucao.TabIndex = 3;
            this.lblInstrucao.Text = "Nosso objetivo é te ajudar a manter uma vida saudável\r\ne ativa com atividades e t" +
    "arefas diárias.\r\n\r\nSe nunca utilizou nossa aplicação, por favor clique no\r\nbotão" +
    " escrito \"Como Funciona\".\r\n";
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditos.Location = new System.Drawing.Point(633, 158);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(119, 35);
            this.lblCreditos.TabIndex = 4;
            this.lblCreditos.Text = "Créditos";
            // 
            // Vidap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1131, 707);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.lblInstrucao);
            this.Controls.Add(this.lblIntroducao);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vidap";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qualidade de vida ao idoso";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCabecalho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconeTelas)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.PictureBox iconeTelas;
        private System.Windows.Forms.Button btnAtividades_Click;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCreditos;
        private System.Windows.Forms.Button comoFunciona;
        private System.Windows.Forms.Label lblIntroducao;
        private System.Windows.Forms.Label lblInstrucao;
        private System.Windows.Forms.Label lblCreditos;
    }
}

