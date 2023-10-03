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

        private int IntentosFallidos = 0;
        private const int maxIntentosFallidos = 3;
        private bool UsuarioBloqueado = false;
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (UsuarioBloqueado)
            {
                MessageBox.Show("Usuario bloqueado. Contacta al administrador.");
                return;
            }

            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Consulta las credenciales (consulta la base de datos o estructura de datos)
            if (ValidarCredenciales(nombreUsuario, contraseña))
            {
                IntentosFallidos = 0;
                MessageBox.Show("Inicio de sesión exitoso.");
                // abrir forms de carga
            }
            else
            {
                IntentosFallidos++;
                if (IntentosFallidos >= maxIntentosFallidos)
                {
                    UsuarioBloqueado = true;
                    MessageBox.Show("Usuario bloqueado después de 3 intentos fallidos.");
                    BloquearUsuario();
                }
                else
                {
                    MessageBox.Show($"Nombre de usuario o contraseña incorrectos. Intentos fallidos: {IntentosFallidos}");
                }
            }

        }

        private void BloquearUsuario()
        {
            btnIniciarSesion.Enabled = false;
        }
        
        private bool ValidarCredenciales(string nombreUsuario, string contraseña)
        {
            return nombreUsuario == "usuario" && contraseña == "contraseña";
        }
           
        }
}
