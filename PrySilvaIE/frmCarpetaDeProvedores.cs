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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PrySilvaIE
{
    public partial class frmCarpetaDeProvedores : Form
    {
        public frmCarpetaDeProvedores()
        {
            InitializeComponent();
        }
        // version original
        private void frmCarpetaDeProvedores_Load(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(@"../../");
            string ruta = info.FullName + "Datos";
            CargarTreeView(ruta, info.Name);
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
    

        private void CargarTreeView(string RutaCarpetaRaiz, string NombreCarpeta)
        {
            twCarpetasProvedores.Nodes.Clear();

            if (Directory.Exists(RutaCarpetaRaiz))
            {
                TreeNode NodoRaiz = new TreeNode(NombreCarpeta);
                twCarpetasProvedores.Nodes.Add(NodoRaiz);
                TraerCarpetasYArchivos(NodoRaiz, RutaCarpetaRaiz);
            }
        }

        private void twCarpetasProvedores_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            lblDatos.Text = "";
            try
            {
                DirectoryInfo info = new DirectoryInfo(@"../../");
                string RutaArchivo = Path.Combine(info.FullName, e.Node.FullPath);
                StreamReader LectorArchivos = new StreamReader(RutaArchivo);
                if (LectorArchivos != null)
                {
                    while (!LectorArchivos.EndOfStream)
                    {
                        lblDatos.Text += LectorArchivos.ReadLine();
                    }
                }
                LectorArchivos.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo encontrar texto");
            }
        }
    }
}
