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
  
        Int32 IntentosFallidos = 0;
        
        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            objAcceso.ConectarBaseDatos();
            txtContraseña.PasswordChar = '*';
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (objAcceso.ValidarUsuarios(txtNombreUsuario.Text, txtContraseña.Text) == true)
            {
                frmBienvenida fb = new frmBienvenida();
                fb.ShowDialog();
                frmInicioSesion fin = new frmInicioSesion();
                fin.Close();
                IntentosFallidos = 0;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                txtNombreUsuario.Text = "";
                txtContraseña.Text = "";
                IntentosFallidos++;
                if(IntentosFallidos >= 3)
                {
                    btnIniciarSesion.Enabled = false;
                    MessageBox.Show("Alcanzo los intentos maximos de incio de sesion");
                }
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmRegistrarse fr = new frmRegistrarse();
            fr.ShowDialog();
        }
    }
}
