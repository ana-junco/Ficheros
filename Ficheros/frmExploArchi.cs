using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficheros
{
    public partial class frmExploArchi : Form
    {
        public frmExploArchi()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string Carpeta = this.txtCarpetas.Text;
            DirectoryInfo di = new DirectoryInfo(Carpeta);

            //recorre la lista y almacena en lisbox
            this.listCarpeta.Items.Clear();
            foreach (var archivo in di.GetDirectories())
            {
                this.listCarpeta.Items.Add(archivo);
            }
        
        }
        private void listCarpeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Carpeta1 = this.txtCarpetas.Text + listCarpeta.SelectedItem.ToString();
            DirectoryInfo di = new DirectoryInfo(Carpeta1);
            this.listArchivos.Items.Clear();
            foreach (var archivo in di.GetFiles())
            {
                this.listArchivos.Items.Add(archivo);
            }

        }

        private void listArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string file = this.txtCarpetas.Text + listCarpeta.SelectedItem.ToString() + listArchivos.SelectedItem.ToString();
                FileStream archivo = new FileStream(file, FileMode.Open);
                StreamReader sr = new StreamReader(archivo);
                string cad, aux = "";
                cad = sr.ReadLine();
                while (cad != null)
                {
                    aux += cad + Environment.NewLine;
                    cad = sr.ReadLine();
                }
                this.listTextos.Text = aux;
                sr.Close();

            }
            catch (IOException e1)
            {
                MessageBox.Show(e1.Message.ToString());
            }

        }

        private void listTextos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
