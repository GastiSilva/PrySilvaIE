using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace PrySilvaIE
{
    //original
    internal class clsBasedeDatos
    {
        OleDbConnection conexionBD;
        DirectoryInfo rutaProyecto = new DirectoryInfo(@"../..");
        string cadenaConexion;
        public bool estadoConexion;
        public clsBasedeDatos()
        {
            estadoConexion = false;
            cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=" + rutaProyecto.FullName + "\\basedeusuarios.accdb";
        }

        public void ConectarBaseDatos()
        {
            conexionBD = new OleDbConnection(cadenaConexion);
            conexionBD.Open();
            estadoConexion = true;
        }

        public bool ValidarUsuarios(String Usuario, String Contraseña)
        {
            bool usuarioValido = false;
            try
            {
                string consulta = "SELECT * FROM Users WHERE Nombre = @Usuario AND Contraseña = @Contraseña";

                using (OleDbCommand cmd = new OleDbCommand(consulta, conexionBD))
                {
                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    cmd.Parameters.AddWithValue("@Contraseña", Contraseña);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuarioValido = true;
                        }
                    }
                }
            }
            catch
            {

            }
            return usuarioValido;
        }
    }
}
