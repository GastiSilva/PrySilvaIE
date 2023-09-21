﻿using System;
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
    public partial class frmListadoDeProvedores : Form
    {
        public frmListadoDeProvedores()
        {
            InitializeComponent();
        }

        private void CargarGrilla()
        {
            DataGridView dgvProvedores = new DataGridView();
            dgvProvedores.Location = new Point(20, 55);

            StreamReader sr = new StreamReader("Listadodeaseguradores.csv");
            string readline;
            string[] divlines;

            bool flag = false;
            dgvProvedores.Width = dgvProvedores.Width + 500;
            dgvProvedores.Height = dgvProvedores.Height + 125;
            while (!sr.EndOfStream)
            {
                readline = sr.ReadLine();
                divlines = readline.Split(';');
                if (flag == false)
                {
                    for (int i = 0; i < divlines.Length; i++)
                    {
                        dgvProvedores.Columns.Add(divlines[i], divlines[i]);
                    }
                    flag = true;
                }
                else
                {
                    dgvProvedores.Rows.Add(divlines);
                }
            }
            sr.Close();
            Controls.Add(dgvProvedores);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}