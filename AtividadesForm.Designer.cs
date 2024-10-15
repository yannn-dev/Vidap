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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.listBoxAtividades = new System.Windows.Forms.ListBox();
            this.btnMarcarComoFeita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAtividades
            // 
            this.listBoxAtividades.FormattingEnabled = true;
            this.listBoxAtividades.Location = new System.Drawing.Point(144, 63);
            this.listBoxAtividades.Name = "listBoxAtividades";
            this.listBoxAtividades.Size = new System.Drawing.Size(517, 251);
            this.listBoxAtividades.TabIndex = 0;
            // 
            // btnMarcarComoFeita
            // 
            this.btnMarcarComoFeita.Location = new System.Drawing.Point(376, 378);
            this.btnMarcarComoFeita.Name = "btnMarcarComoFeita";
            this.btnMarcarComoFeita.Size = new System.Drawing.Size(75, 23);
            this.btnMarcarComoFeita.TabIndex = 1;
            this.btnMarcarComoFeita.Text = "button1";
            this.btnMarcarComoFeita.UseVisualStyleBackColor = true;
            this.btnMarcarComoFeita.Click += new System.EventHandler(this.btnMarcarComoFeita_Click);
            // 
            // AtividadesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMarcarComoFeita);
            this.Controls.Add(this.listBoxAtividades);
            this.Name = "AtividadesForm";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ListBox listBoxAtividades;
        private System.Windows.Forms.Button btnMarcarComoFeita;
    }
}