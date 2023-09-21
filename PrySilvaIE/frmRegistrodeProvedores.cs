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

namespace PrySilvaIE
{
    public partial class frmRegistrodeProvedores : Form
    {
        public frmRegistrodeProvedores()
        {
            InitializeComponent();
        }

        private void RegistrarProvedores()
        {
            Int32 Nro = Convert.ToInt32(txtNro.Text);
            String Entidad = txtEntidad.Text;
            Int32 Apertura = Convert.ToInt32(txtApertura.Text);
            Int32 NroExpediente = Convert.ToInt32(txtNroExpediente.Text);
            String Juzg = txtJuzg.Text;
            String Jurisd = txtJurisd.Text;
            String Direccion = txtDireccion.Text;
            String Liquidador = txtLiquidador.Text;

            StreamWriter sw = new StreamWriter("Listadodeaseguradores.csv", true);
            try
            {
                sw.WriteLine($"{Nro}; {Entidad}; {Apertura}; {NroExpediente}; {Juzg}; {Jurisd}; {Direccion}; {Liquidador}");
                MessageBox.Show("Provedor agregado correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sw.Close();
            txtNro.Clear();
            txtEntidad.Clear();
            txtApertura.Clear();
            txtNroExpediente.Clear();
            txtJuzg.Clear();
            txtJurisd.Clear();
            txtDireccion.Clear();
            txtLiquidador.Clear();
        }
  
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarProvedores();
        }
    }
}
