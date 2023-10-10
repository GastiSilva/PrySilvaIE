using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrySilvaIE
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        clsBasedeDatos objAcceso = new clsBasedeDatos();

        private int IntentosFallidos = 0;
        private const int maxIntentosFallidos = 3;
        private bool UsuarioBloqueado = false;

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            objAcceso.ConectarBaseDatos();
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            objAcceso.ValidarUsuarios(txtNombreUsuario.Text, txtContraseña.Text);
        }
        
    }
}
