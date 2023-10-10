using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace PrySilvaIE
{
    internal class clsBasedeDatos
    {
        OleDbConnection conexionBD;
        OleDbCommand comandarBD;
        OleDbDataReader BDDataReader;
        DirectoryInfo rutaProyecto = new DirectoryInfo(@"../..");

        string cadenaConexion;
        public string resultadoDatos;
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

        public void ValidarUsuarios(String Usuario, String Contraseña)
        {
            using (conexionBD = new OleDbConnection(cadenaConexion))
            {
                try
                {
                    conexionBD.Open();
                    string consulta = "SELECT * FROM Usuarios WHERE NombreUsuario = @Usuario AND Contraseña = @Contraseña";

                    using (OleDbCommand cmd = new OleDbCommand(consulta, conexionBD))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", Usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", Contraseña);
                        OleDbDataReader reader = cmd.ExecuteReader();
                    }
                }


            }

        }
}
