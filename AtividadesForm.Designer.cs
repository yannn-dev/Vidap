namespace Auxílio_de_qualidade_de_vida_para_o_idoso
{
    partial class AtividadesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtividadesForm));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.listBoxAtividades = new System.Windows.Forms.ListBox();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblExplicacao = new System.Windows.Forms.Label();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnMarcarComoFeita = new System.Windows.Forms.Button();
            this.panelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxAtividades
            // 
            this.listBoxAtividades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBoxAtividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(173)))));
            this.listBoxAtividades.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAtividades.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxAtividades.FormattingEnabled = true;
            this.listBoxAtividades.ItemHeight = 23;
            this.listBoxAtividades.Location = new System.Drawing.Point(269, 63);
            this.listBoxAtividades.Name = "listBoxAtividades";
            this.listBoxAtividades.Size = new System.Drawing.Size(517, 257);
            this.listBoxAtividades.TabIndex = 0;
            this.listBoxAtividades.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxAtividades_MouseDoubleClick);
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(110)))), ((int)(((byte)(56)))));
            this.panelCabecalho.Controls.Add(this.btnRestaurar);
            this.panelCabecalho.Controls.Add(this.btnMaximizar);
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(1050, 56);
            this.panelCabecalho.TabIndex = 3;
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackgroundImage = global::Auxílio_de_qualidade_de_vida_para_o_idoso.Properties.Resources.maximizar;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRestaurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Location = new System.Drawing.Point(924, 9);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(40, 30);
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = global::Auxílio_de_qualidade_de_vida_para_o_idoso.Properties.Resources.maximizar1;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(964, 7);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(41, 34);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackgroundImage = global::Auxílio_de_qualidade_de_vida_para_o_idoso.Properties.Resources.fechar;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1011, 10);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(27, 27);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblExplicacao
            // 
            this.lblExplicacao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblExplicacao.AutoSize = true;
            this.lblExplicacao.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao.Location = new System.Drawing.Point(204, 323);
            this.lblExplicacao.Name = "lblExplicacao";
            this.lblExplicacao.Size = new System.Drawing.Size(646, 35);
            this.lblExplicacao.TabIndex = 4;
            this.lblExplicacao.Text = "Dê dois cliques nas atividades para mais detalhes";
            this.lblExplicacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDesmarcar.BackgroundImage = global::Auxílio_de_qualidade_de_vida_para_o_idoso.Properties.Resources.Desmarcar;
            this.btnDesmarcar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDesmarcar.FlatAppearance.BorderSize = 0;
            this.btnDesmarcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesmarcar.Location = new System.Drawing.Point(621, 418);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(76, 75);
            this.btnDesmarcar.TabIndex = 5;
            this.btnDesmarcar.UseVisualStyleBackColor = true;
            this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRetornar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetornar.BackgroundImage")));
            this.btnRetornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetornar.FlatAppearance.BorderSize = 0;
            this.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornar.Location = new System.Drawing.Point(37, 440);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(170, 53);
            this.btnRetornar.TabIndex = 2;
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnMarcarComoFeita
            // 
            this.btnMarcarComoFeita.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMarcarComoFeita.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMarcarComoFeita.BackgroundImage")));
            this.btnMarcarComoFeita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarcarComoFeita.FlatAppearance.BorderSize = 0;
            this.btnMarcarComoFeita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarComoFeita.Location = new System.Drawing.Point(383, 411);
            this.btnMarcarComoFeita.Name = "btnMarcarComoFeita";
            this.btnMarcarComoFeita.Size = new System.Drawing.Size(102, 89);
            this.btnMarcarComoFeita.TabIndex = 1;
            this.btnMarcarComoFeita.UseVisualStyleBackColor = true;
            this.btnMarcarComoFeita.Click += new System.EventHandler(this.btnMarcarComoFeita_Click);
            // 
            // AtividadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1050, 563);
            this.Controls.Add(this.btnDesmarcar);
            this.Controls.Add(this.lblExplicacao);
            this.Controls.Add(this.panelCabecalho);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnMarcarComoFeita);
            this.Controls.Add(this.listBoxAtividades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AtividadesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AtividadesForm_FormClosing);
            this.Load += new System.EventHandler(this.AtividadesForm_Load);
            this.panelCabecalho.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ListBox listBoxAtividades;
        private System.Windows.Forms.Button btnMarcarComoFeita;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblExplicacao;
        private System.Windows.Forms.Button btnDesmarcar;
    }
}