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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrodeProvedores rdp2 = new frmRegistrodeProvedores();
            rdp2.ShowDialog();
        }

        private void provedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistrodeProvedores rdp = new frmRegistrodeProvedores();
            rdp.ShowDialog();
        }

        private void listadoDeProvedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoDeProvedores lp = new frmListadoDeProvedores();
            lp.ShowDialog();
        }
    }
}
