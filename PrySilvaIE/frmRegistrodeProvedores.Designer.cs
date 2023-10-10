namespace PrySilvaIE
{
    partial class frmRegistrodeProvedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrodeProvedores));
            this.lblNro = new System.Windows.Forms.Label();
            this.gbRegistroDeProvedores = new System.Windows.Forms.GroupBox();
            this.lblJurisid = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNroExpediente = new System.Windows.Forms.TextBox();
            this.txtApertura = new System.Windows.Forms.TextBox();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.lnlLiqudadorResponsable = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblJuzg = new System.Windows.Forms.Label();
            this.lblNroExpediente = new System.Windows.Forms.Label();
            this.lblApertura = new System.Windows.Forms.Label();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cmbJuzg = new System.Windows.Forms.ComboBox();
            this.cmbJurisd = new System.Windows.Forms.ComboBox();
            this.cmbLiquidador = new System.Windows.Forms.ComboBox();
            this.gbRegistroDeProvedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Location = new System.Drawing.Point(4, 28);
            this.lblNro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(22, 13);
            this.lblNro.TabIndex = 0;
            this.lblNro.Text = "N°:";
            this.lblNro.UseWaitCursor = true;
            // 
            // gbRegistroDeProvedores
            // 
            this.gbRegistroDeProvedores.Controls.Add(this.cmbLiquidador);
            this.gbRegistroDeProvedores.Controls.Add(this.cmbJurisd);
            this.gbRegistroDeProvedores.Controls.Add(this.cmbJuzg);
            this.gbRegistroDeProvedores.Controls.Add(this.lblJurisid);
            this.gbRegistroDeProvedores.Controls.Add(this.txtDireccion);
            this.gbRegistroDeProvedores.Controls.Add(this.txtNroExpediente);
            this.gbRegistroDeProvedores.Controls.Add(this.txtApertura);
            this.gbRegistroDeProvedores.Controls.Add(this.txtEntidad);
            this.gbRegistroDeProvedores.Controls.Add(this.txtNro);
            this.gbRegistroDeProvedores.Controls.Add(this.lnlLiqudadorResponsable);
            this.gbRegistroDeProvedores.Controls.Add(this.lblDireccion);
            this.gbRegistroDeProvedores.Controls.Add(this.lblJuzg);
            this.gbRegistroDeProvedores.Controls.Add(this.lblNroExpediente);
            this.gbRegistroDeProvedores.Controls.Add(this.lblApertura);
            this.gbRegistroDeProvedores.Controls.Add(this.lblEntidad);
            this.gbRegistroDeProvedores.Controls.Add(this.lblNro);
            this.gbRegistroDeProvedores.Location = new System.Drawing.Point(10, 11);
            this.gbRegistroDeProvedores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRegistroDeProvedores.Name = "gbRegistroDeProvedores";
            this.gbRegistroDeProvedores.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRegistroDeProvedores.Size = new System.Drawing.Size(384, 250);
            this.gbRegistroDeProvedores.TabIndex = 1;
            this.gbRegistroDeProvedores.TabStop = false;
            this.gbRegistroDeProvedores.Text = "Registro de provedores";
            this.gbRegistroDeProvedores.UseWaitCursor = true;
            // 
            // lblJurisid
            // 
            this.lblJurisid.AutoSize = true;
            this.lblJurisid.Location = new System.Drawing.Point(7, 161);
            this.lblJurisid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJurisid.Name = "lblJurisid";
            this.lblJurisid.Size = new System.Drawing.Size(37, 13);
            this.lblJurisid.TabIndex = 14;
            this.lblJurisid.Text = "Jurisd:";
            this.lblJurisid.UseWaitCursor = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(130, 193);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(106, 20);
            this.txtDireccion.TabIndex = 12;
            this.txtDireccion.UseWaitCursor = true;
            // 
            // txtNroExpediente
            // 
            this.txtNroExpediente.Location = new System.Drawing.Point(130, 105);
            this.txtNroExpediente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNroExpediente.Name = "txtNroExpediente";
            this.txtNroExpediente.Size = new System.Drawing.Size(85, 20);
            this.txtNroExpediente.TabIndex = 10;
            this.txtNroExpediente.UseWaitCursor = true;
            // 
            // txtApertura
            // 
            this.txtApertura.Location = new System.Drawing.Point(130, 76);
            this.txtApertura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.Size = new System.Drawing.Size(80, 20);
            this.txtApertura.TabIndex = 9;
            this.txtApertura.UseWaitCursor = true;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(130, 48);
            this.txtEntidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(86, 20);
            this.txtEntidad.TabIndex = 8;
            this.txtEntidad.UseWaitCursor = true;
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(130, 25);
            this.txtNro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(102, 20);
            this.txtNro.TabIndex = 7;
            this.txtNro.UseWaitCursor = true;
            // 
            // lnlLiqudadorResponsable
            // 
            this.lnlLiqudadorResponsable.AutoSize = true;
            this.lnlLiqudadorResponsable.Location = new System.Drawing.Point(7, 222);
            this.lnlLiqudadorResponsable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnlLiqudadorResponsable.Name = "lnlLiqudadorResponsable";
            this.lnlLiqudadorResponsable.Size = new System.Drawing.Size(124, 13);
            this.lnlLiqudadorResponsable.TabIndex = 6;
            this.lnlLiqudadorResponsable.Text = "Liquidador Responsable:";
            this.lnlLiqudadorResponsable.UseWaitCursor = true;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(7, 193);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección:";
            this.lblDireccion.UseWaitCursor = true;
            // 
            // lblJuzg
            // 
            this.lblJuzg.AutoSize = true;
            this.lblJuzg.Location = new System.Drawing.Point(7, 132);
            this.lblJuzg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJuzg.Name = "lblJuzg";
            this.lblJuzg.Size = new System.Drawing.Size(32, 13);
            this.lblJuzg.TabIndex = 4;
            this.lblJuzg.Text = "Juzg:";
            this.lblJuzg.UseWaitCursor = true;
            // 
            // lblNroExpediente
            // 
            this.lblNroExpediente.AutoSize = true;
            this.lblNroExpediente.Location = new System.Drawing.Point(7, 107);
            this.lblNroExpediente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroExpediente.Name = "lblNroExpediente";
            this.lblNroExpediente.Size = new System.Drawing.Size(78, 13);
            this.lblNroExpediente.TabIndex = 3;
            this.lblNroExpediente.Text = "N° Expediente:";
            this.lblNroExpediente.UseWaitCursor = true;
            // 
            // lblApertura
            // 
            this.lblApertura.AutoSize = true;
            this.lblApertura.Location = new System.Drawing.Point(7, 76);
            this.lblApertura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(50, 13);
            this.lblApertura.TabIndex = 2;
            this.lblApertura.Text = "Apertura:";
            this.lblApertura.UseWaitCursor = true;
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.Location = new System.Drawing.Point(4, 50);
            this.lblEntidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(46, 13);
            this.lblEntidad.TabIndex = 1;
            this.lblEntidad.Text = "Entidad:";
            this.lblEntidad.UseWaitCursor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrar.Location = new System.Drawing.Point(267, 266);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(127, 31);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.UseWaitCursor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cmbJuzg
            // 
            this.cmbJuzg.FormattingEnabled = true;
            this.cmbJuzg.Items.AddRange(new object[] {
            "Comercial N° 2, Secretaría N° 3",
            "Civil y Comercial, 6ta. Nominación",
            "Comercial N° 19, Secretaría N° 38",
            "Comercial N° 16, Secretaría N° 31",
            "Comercial N° 24, Secretaría N° 47",
            "Comercial N° 3, Secretaría N° 5",
            "Comercial N° 8, Secretaría N° 15",
            "Comercial N° 15, Secretaría N° 30",
            "Comercial N° 5, Secretaría N° 9",
            "Civil y Comercial N° 9, sec. N° 8",
            "Comercial N° 26, Secretaría 52",
            "Comercial N° 24, Secretaría N° 48",
            "Comercial N° 1, Secretaría N° 1",
            "Comercial N° 25, Secretaría N° 50",
            "Comercial N° 5, Secretaría N° 10",
            "Comercial N° 9, Secretaría N° 18",
            "Comercial N° 4, Secretaría N° 8",
            "Comercial N° 12, Secretaría N° 24",
            "Comercial Nº 14, Secretaría N° 28",
            "Comercial Nº 26 Secretaría N° 51",
            "Comercial Nº 5, Secretaría N° 10",
            "Comercial Nº 1, Secretaría N° 2",
            "Civil Y Comercial de la 2da. Nom.",
            "Comercial N° 14, Secretaría N° 28",
            "Comercial N° 13, Secretaría N° 25",
            "Comercial N° 1, Secretaría N° 2",
            "Juzg.1° Inst. Civil y Comercial 4, Distrito Judicial Centro",
            "Civil y Comercial N° 5, Sec. N° 2",
            "Comercial N° 6, Secretaría N° 12",
            "Comercial N° 7, Secretaría N° 13",
            "Civil y Comercial N° 26, Sec. N° 52",
            "Civil y Comercial N° 5",
            "Comercial N° 8, Secretaría N° 16",
            "Civil y Comercial 9na. Nominación",
            "Comercial N° 17, Secretaría N° 33",
            "Civil y Comercial N° 1",
            "Civil y Comercial 7ma nominación",
            "Civil y Comercial N° 2, Sec. N° 3",
            "Comercial N° 13, Secretaría N° 26",
            "Comercial N° 21, Secretaría 41",
            "Civil y Comerial de la 2a nom., Secretaría Nº 3",
            "Comercial N° 25, Secretaría N° 49",
            "Comercial N° 23, Secretaría N° 45",
            "Civil y Comercial N° 2, Sec. Unica",
            "Civil y Comercial N° 7",
            "Comercial N° 9, Secretaría N° 17",
            "Comercial N° 13, Secretaría 25",
            "Comercial N° 23, Secretaría N° 46",
            "Comercial N° 10, Secretaría N° 20",
            "Juzg. de distrito de la 8a nominación",
            "Comercial N° 26, Secretaría 51",
            "Civil y Comercial 13 nominacion",
            "Civil Y Comercial de la 10° Nom.",
            "Comercial N° 2, Secretaría N° 4",
            "Comercial N° 22, Secretaría N° 43",
            "Comercial N° 3, Secretaría N° 6",
            "Comercial N° 19, Secretaría 38",
            "Civil y Com 7ma nom., Sec.N° 4",
            "Comercial N° 16, Secretaría N° 32",
            "Comercial N° 6, Secretaría N° 11",
            "Concursos y Registro N° 2",
            "Comercial Nº 8, Secretaría Nº 16",
            "Juzg. de la 1° Inst.de 26 Nominación en lo Civil y Comercial de Concursos y Socie" +
                "dades N° 2",
            "Civil y Comercial 4ta nominación",
            "Comercial N° 4, Secretaría N° 7",
            "Comercial N° 9, Secretaría 18",
            "Comercial N° 7, Secretaría N° 14",
            "1ª Inst.Civily Com.Dist.15ª Nom.",
            "Civil y Comercial 10ma. Nominación",
            "Comercial N° 19, Secretaría 37",
            "N° 2 de Concursos",
            "Comercial Nº 13, Secretaría N° 25",
            "Comercial N° 10, Secretaría N° 19",
            "Civil y Comercial N° 1, Sec. N° 2",
            "Civil y Comercial 6ta Nominación",
            "Civil y Comercial N° 6, Secretaría 4",
            "Comercial N° 22, Sec. N° 44",
            "Comercial N° 22, Secretaría N° 44",
            "Comercial N° 18, Secretaría N° 35",
            "Comercial N° 15, Secretaría N° 29",
            "Civil y Comercial N° 3",
            "Civil, Comercial y Especial N° 1",
            "Comercial N° 26, Secretaría N° 52",
            "Civil y Comercial 2 Nominación",
            "Civil y Com. 7 Nom., N° 4, Sec. 13",
            "Civil y Comercial 8va. nominación",
            "Comercial N° 20, Secretaría N° 39",
            "Civil y Comercial 3ra. nominación",
            "Civil y Comercial de la 2a Nominación",
            "Civil y Comercial 13 Nominación",
            "Civil y Comercial N° 4",
            "Comercial 23, Secretaría 45",
            "Comercial 16, Secretaría 32",
            "Comercial 13, Secretaría 26",
            "Comercial 18, Secretaría 35",
            "Comercial Nº 9, Secretaría 18",
            "Comercial 17, Secretaría 33",
            "Juzg. 1º Dist. De la 4ª Nom.",
            "Comercial 8, Secretaría 16",
            "Comercial 14, Secretaria 27",
            "Comercial 31, Secretaría 61"});
            this.cmbJuzg.Location = new System.Drawing.Point(130, 132);
            this.cmbJuzg.Name = "cmbJuzg";
            this.cmbJuzg.Size = new System.Drawing.Size(121, 21);
            this.cmbJuzg.TabIndex = 16;
            // 
            // cmbJurisd
            // 
            this.cmbJurisd.FormattingEnabled = true;
            this.cmbJurisd.Items.AddRange(new object[] {
            "CABA",
            "Resistencia-Chaco",
            "CABA",
            "Mercedes- Pcia. de Bs. As.",
            "Río Cuarto-Córdoba",
            "Salta",
            "Bahía Blanca-Pcia. de Bs. As.",
            "Córdoba",
            "Lomas de Zamora-Pcia. de Bs. As.",
            "Rosario-Santa Fe",
            "Chaco",
            "Villa María - Córdoba",
            "Tandil-Pcia. de Bs. As.",
            "Tucumán",
            "Mendoza",
            "La Plata",
            "Tres Arroyos-Bs.As.",
            "T. Lauquen-Bs. As.",
            "Pergamino-Bs. As.",
            "San Juan",
            "Venado Tuerto-Santa Fe",
            "La Matanza - Pcia. de Bs.As.",
            "Rafaela - Santa Fe",
            "Juzgado es Montevideo 546, piso 7º",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "CABA",
            "Resistencia-Chaco",
            "CABA",
            "Mercedes- Pcia. de Bs. As.",
            "Río Cuarto-Córdoba",
            "Salta",
            "Bahía Blanca-Pcia. de Bs. As.",
            "Córdoba",
            "Lomas de Zamora-Pcia. de Bs. As.",
            "Rosario-Santa Fe",
            "Chaco",
            "Villa María - Córdoba",
            "Tandil-Pcia. de Bs. As.",
            "Tucumán",
            "Mendoza",
            "La Plata",
            "Tres Arroyos-Bs.As.",
            "T. Lauquen-Bs. As.",
            "Pergamino-Bs. As.",
            "San Juan",
            "Venado Tuerto-Santa Fe",
            "La Matanza - Pcia. de Bs.As.",
            "Rafaela - Santa Fe",
            "Juzgado es Montevideo 546, piso 28"});
            this.cmbJurisd.Location = new System.Drawing.Point(130, 159);
            this.cmbJurisd.Name = "cmbJurisd";
            this.cmbJurisd.Size = new System.Drawing.Size(121, 21);
            this.cmbJurisd.TabIndex = 17;
            // 
            // cmbLiquidador
            // 
            this.cmbLiquidador.FormattingEnabled = true;
            this.cmbLiquidador.Items.AddRange(new object[] {
            "Dra. María Cristina Ubbriaco",
            "Sr. Ricardo Crosetto",
            "Dra. María Alejandra Spagnolo",
            "Cont. Orlando Marcelo Suarez",
            "Dr. Carlos Eduardo Sercovich",
            "Dr. Martín Riera ",
            "Dra. Alicia Nilda Sturla",
            "Cont. Edgardo Gustavo Silva",
            "Dr. Oscar Guillermo Carreras",
            "Dra. Claudia Marcela Pariente",
            "Cont. Héctor Jorge García",
            "Dra. Verónica Ortíz Auger",
            "Dra. Andrea Susana Rojas ",
            "Dra. Gabriela Inés Trapaglia",
            "Dr. Domingo Gómez Bisgarra",
            "Dr. Martín Riera",
            "Dr. Luis Petrate Arguello",
            "Dr. Ezequiel Cará",
            "Cont. Roberto Falvo",
            "Dra. María Mendía",
            "Dres. María Mendía y Martín Riera",
            "Dras. Andrea Rojas y Claudia Pariente"});
            this.cmbLiquidador.Location = new System.Drawing.Point(130, 219);
            this.cmbLiquidador.Name = "cmbLiquidador";
            this.cmbLiquidador.Size = new System.Drawing.Size(121, 21);
            this.cmbLiquidador.TabIndex = 18;
            // 
            // frmRegistrodeProvedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(416, 301);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gbRegistroDeProvedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrodeProvedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de provedores";
            this.UseWaitCursor = true;
            this.gbRegistroDeProvedores.ResumeLayout(false);
            this.gbRegistroDeProvedores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.GroupBox gbRegistroDeProvedores;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNroExpediente;
        private System.Windows.Forms.TextBox txtApertura;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.Label lnlLiqudadorResponsable;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblJuzg;
        private System.Windows.Forms.Label lblNroExpediente;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblJurisid;
        private System.Windows.Forms.ComboBox cmbLiquidador;
        private System.Windows.Forms.ComboBox cmbJurisd;
        private System.Windows.Forms.ComboBox cmbJuzg;
    }
}