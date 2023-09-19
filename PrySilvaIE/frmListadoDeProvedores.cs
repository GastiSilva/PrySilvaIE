using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PrySilvaIE
{
    public partial class frmListadoDeProvedores : Form
    {
        public frmListadoDeProvedores()
        {
            InitializeComponent();
        }

        string LeerLinea;
        string[] SepararTexto;

        private void ProcedimientoCargarGrilla()
        {
            dgvProvedores.Rows.Clear();

            StreamReader leerArchivoGrilla = new StreamReader("baseproveedores.csv");

            while (!leerArchivoGrilla.EndOfStream)
            {
                LeerLinea = leerArchivoGrilla.ReadLine();
                SepararTexto = LeerLinea.Split(';');

                dgvProvedores.Rows.Add(SepararTexto);

            }

            leerArchivoGrilla.Close();
        }
        private void btnListar_Click(object sender, EventArgs e)
        {

        }
    }
}
