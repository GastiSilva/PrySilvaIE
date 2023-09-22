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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace PrySilvaIE
{
    public partial class frmCarpetaDeProvedores : Form
    {
        public frmCarpetaDeProvedores()
        {
            InitializeComponent();
        }

        private void frmCarpetaDeProvedores_Load(object sender, EventArgs e)
        {

            DirectoryInfo info = new DirectoryInfo(@"C:\Users\gasti\source\repos\PrySilvaIE\PrySilvaIE\Proveedores");
            CargarTreeView(info.FullName, info.Name);

   
            //string rutaInicio = @"C:\Users\gasti\source\repos\PrySilvaIE\PrySilvaIE\Proveedores";

            // TreeNode NodoRaiz = new TreeNode(rutaInicio);
            //twCarpetasProvedores.Nodes.Add(NodoRaiz);

            //TraerCarpetasYArchivos(NodoRaiz, rutaInicio);
        }

        private void TraerCarpetasYArchivos(TreeNode NodoPadre, string ruta)
        {
            try
            {
                string[] carpetas = Directory.GetDirectories(ruta);
                string[] archivos = Directory.GetFiles(ruta);

                foreach (string carpeta in carpetas)
                {
                    TreeNode NodoDeCarpeta = new TreeNode(Path.GetFileName(carpeta));
                    NodoPadre.Nodes.Add(NodoDeCarpeta);
                    TraerCarpetasYArchivos(NodoDeCarpeta, carpeta);
                }

                foreach (string archivo in archivos)
                {
                    TreeNode NodoDeArchivo = new TreeNode(Path.GetFileName(archivo));
                    NodoPadre.Nodes.Add(NodoDeArchivo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar carpetas y archivos: " + ex.Message);
            }
        }

        private void CargarTreeView(string rutaCarpetaRaiz, string NombreCarpeta)
        {
            twCarpetasProvedores.Nodes.Clear();

            if (Directory.Exists(rutaCarpetaRaiz))
            {
                TreeNode NodoRaiz = new TreeNode(NombreCarpeta);
                twCarpetasProvedores.Nodes.Add(NodoRaiz);
                TraerCarpetasYArchivos(NodoRaiz, rutaCarpetaRaiz);
            }
        }

        private void twCarpetasProvedores_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            lblDatos.Text = "";
            try
            {
                DirectoryInfo info = new DirectoryInfo(@"C:\Users\gasti\source\repos\PrySilvaIE\PrySilvaIE\Proveedores");

                string rutaArchivo = info.Name + e.Node.Text;

                StreamReader lectorArchivos = new StreamReader(rutaArchivo);

                if (lectorArchivos != null)
                {
                    while (!lectorArchivos.EndOfStream)
                    {
                        lblDatos.Text += lectorArchivos.ReadLine();
                    }
                }

                lectorArchivos.Close();
            }
            catch (Exception)
            {

            }

        }

        private void twCarpetasProvedores_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Mostrar información sobre el elemento seleccionado en el Label
            lblDatos.Text = e.Node.FullPath;
        }

    }
}
