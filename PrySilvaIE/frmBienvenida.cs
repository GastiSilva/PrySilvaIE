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
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmMain fm = new frmMain();
            fm.ShowDialog();
        }
        private void frmBienvenida_Load(object sender, EventArgs e)
        {
            Reloj.Enabled = true;
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            if (pbBarradeCargar.Value == 100)
            {
                Reloj.Enabled = false;
                this.Hide();
                frmBienvenida window = new frmBienvenida();
                window.ShowDialog();

            }
            else
            {
                pbBarradeCargar.Value += 5;
            }
        }
    }
}
