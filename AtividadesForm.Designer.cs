﻿namespace Auxílio_de_qualidade_de_vida_para_o_idoso
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
            this.lblAjuda = new System.Windows.Forms.Label();
            this.btnAtividades = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnDesmarcar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
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
            this.listBoxAtividades.Location = new System.Drawing.Point(429, 63);
            this.listBoxAtividades.Name = "listBoxAtividades";
            this.listBoxAtividades.Size = new System.Drawing.Size(517, 441);
            this.listBoxAtividades.TabIndex = 0;
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
            this.panelCabecalho.Size = new System.Drawing.Size(1370, 56);
            this.panelCabecalho.TabIndex = 3;
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            // 
            // lblAjuda
            // 
            this.lblAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAjuda.AutoSize = true;
            this.lblAjuda.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjuda.Location = new System.Drawing.Point(1141, 91);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(87, 35);
            this.lblAjuda.TabIndex = 7;
            this.lblAjuda.Text = "Ajuda";
            // 
            // btnAtividades
            // 
            this.btnAtividades.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAtividades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtividades.BackgroundImage")));
            this.btnAtividades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtividades.FlatAppearance.BorderSize = 0;
            this.btnAtividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtividades.Location = new System.Drawing.Point(418, 523);
            this.btnAtividades.Name = "btnAtividades";
            this.btnAtividades.Size = new System.Drawing.Size(543, 75);
            this.btnAtividades.TabIndex = 8;
            this.btnAtividades.UseVisualStyleBackColor = true;
            this.btnAtividades.Click += new System.EventHandler(this.btnAtividades_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjuda.BackgroundImage = global::Auxílio_de_qualidade_de_vida_para_o_idoso.Properties.Resources.ajuda;
            this.btnAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Location = new System.Drawing.Point(1112, 129);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(145, 136);
            this.btnAjuda.TabIndex = 6;
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDesmarcar.BackgroundImage = global::Auxílio_de_qualidade_de_vida_para_o_idoso.Properties.Resources.Desmarcar;
            this.btnDesmarcar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDesmarcar.FlatAppearance.BorderSize = 0;
            this.btnDesmarcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesmarcar.Location = new System.Drawing.Point(769, 625);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Size = new System.Drawing.Size(76, 75);
            this.btnDesmarcar.TabIndex = 5;
            this.btnDesmarcar.UseVisualStyleBackColor = true;
            this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
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
            this.btnRestaurar.Location = new System.Drawing.Point(1279, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(46, 44);
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
            this.btnMaximizar.Location = new System.Drawing.Point(1284, 7);
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
            this.btnFechar.Location = new System.Drawing.Point(1331, 10);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(27, 27);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRetornar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetornar.BackgroundImage")));
            this.btnRetornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetornar.FlatAppearance.BorderSize = 0;
            this.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetornar.Location = new System.Drawing.Point(37, 625);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(199, 75);
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
            this.btnMarcarComoFeita.Location = new System.Drawing.Point(528, 618);
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
            this.ClientSize = new System.Drawing.Size(1370, 748);
            this.Controls.Add(this.btnAtividades);
            this.Controls.Add(this.lblAjuda);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.btnDesmarcar);
            this.Controls.Add(this.panelCabecalho);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.btnMarcarComoFeita);
            this.Controls.Add(this.listBoxAtividades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AtividadesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atividades";
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
        private System.Windows.Forms.Button btnDesmarcar;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.Button btnAtividades;
    }
}