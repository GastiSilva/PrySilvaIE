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
            String Juzg = cmbJuzg.Text;
            String Jurisd = cmbJurisd.Text;
            String Direccion = txtDireccion.Text;
            String Liquidador = cmbLiquidador.Text;

            StreamWriter sw = new StreamWriter("../../Bases/Listadodeaseguradores.csv", true);
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
            txtDireccion.Clear();
        }
  
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarProvedores();
        }
    }
}
