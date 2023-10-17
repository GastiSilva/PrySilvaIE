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
  
        Int32 IntententosFallidos = 0;
        
        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            objAcceso.ConectarBaseDatos();
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (objAcceso.ValidarUsuarios(txtNombreUsuario.Text, txtContraseña.Text) == true)
            {
                frmMain fm = new frmMain();
                fm.ShowDialog();
                frmInicioSesion fin = new frmInicioSesion();
                fin.Close();
                IntententosFallidos = 0;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                txtNombreUsuario.Text = "";
                txtContraseña.Text = "";
                IntententosFallidos++;
                if(IntententosFallidos >= 3)
                {
                    btnIniciarSesion.Enabled = false;
                    MessageBox.Show("Alcanzo los intentos maximos de incio de sesion");
                }
            }
        }
        
    }
}
