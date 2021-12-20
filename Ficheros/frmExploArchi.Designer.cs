
namespace Ficheros
{
    partial class frmExploArchi
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
            this.txtCarpetas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.listCarpeta = new System.Windows.Forms.ListBox();
            this.listArchivos = new System.Windows.Forms.ListBox();
            this.listTextos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtCarpetas
            // 
            this.txtCarpetas.Location = new System.Drawing.Point(298, 89);
            this.txtCarpetas.Name = "txtCarpetas";
            this.txtCarpetas.Size = new System.Drawing.Size(275, 22);
            this.txtCarpetas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ABRIR CARPETAS";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(661, 89);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(165, 45);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "CARGAR ARCHIVOS";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // listCarpeta
            // 
            this.listCarpeta.FormattingEnabled = true;
            this.listCarpeta.ItemHeight = 16;
            this.listCarpeta.Location = new System.Drawing.Point(93, 198);
            this.listCarpeta.Name = "listCarpeta";
            this.listCarpeta.Size = new System.Drawing.Size(220, 180);
            this.listCarpeta.TabIndex = 3;
            this.listCarpeta.SelectedIndexChanged += new System.EventHandler(this.listCarpeta_SelectedIndexChanged);
            // 
            // listArchivos
            // 
            this.listArchivos.FormattingEnabled = true;
            this.listArchivos.ItemHeight = 16;
            this.listArchivos.Location = new System.Drawing.Point(386, 198);
            this.listArchivos.Name = "listArchivos";
            this.listArchivos.Size = new System.Drawing.Size(229, 180);
            this.listArchivos.TabIndex = 4;
            this.listArchivos.SelectedIndexChanged += new System.EventHandler(this.listArchivos_SelectedIndexChanged);
            // 
            // listTextos
            // 
            this.listTextos.FormattingEnabled = true;
            this.listTextos.ItemHeight = 16;
            this.listTextos.Location = new System.Drawing.Point(696, 198);
            this.listTextos.Name = "listTextos";
            this.listTextos.Size = new System.Drawing.Size(217, 180);
            this.listTextos.TabIndex = 5;
            this.listTextos.SelectedIndexChanged += new System.EventHandler(this.listTextos_SelectedIndexChanged);
            // 
            // frmExploArchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 550);
            this.Controls.Add(this.listTextos);
            this.Controls.Add(this.listArchivos);
            this.Controls.Add(this.listCarpeta);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCarpetas);
            this.Name = "frmExploArchi";
            this.Text = "frmExploArchi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCarpetas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListBox listCarpeta;
        private System.Windows.Forms.ListBox listArchivos;
        private System.Windows.Forms.ListBox listTextos;
    }
}