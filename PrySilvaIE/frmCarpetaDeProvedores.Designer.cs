namespace PrySilvaIE
{
    partial class frmCarpetaDeProvedores
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
            this.btnCarpetas = new System.Windows.Forms.Button();
            this.twCarpetasProvedores = new System.Windows.Forms.TreeView();
            this.lblDatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCarpetas
            // 
            this.btnCarpetas.Location = new System.Drawing.Point(153, 12);
            this.btnCarpetas.Name = "btnCarpetas";
            this.btnCarpetas.Size = new System.Drawing.Size(121, 32);
            this.btnCarpetas.TabIndex = 0;
            this.btnCarpetas.Text = "Ver carpetas";
            this.btnCarpetas.UseVisualStyleBackColor = true;
            // 
            // twCarpetasProvedores
            // 
            this.twCarpetasProvedores.Location = new System.Drawing.Point(22, 60);
            this.twCarpetasProvedores.Name = "twCarpetasProvedores";
            this.twCarpetasProvedores.Size = new System.Drawing.Size(242, 215);
            this.twCarpetasProvedores.TabIndex = 1;
            // 
            // lblDatos
            // 
            this.lblDatos.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(306, 60);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(262, 215);
            this.lblDatos.TabIndex = 2;
            this.lblDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCarpetaDeProvedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 333);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.twCarpetasProvedores);
            this.Controls.Add(this.btnCarpetas);
            this.Name = "frmCarpetaDeProvedores";
            this.Text = "Carpetas De Provedores";
            this.Load += new System.EventHandler(this.frmCarpetaDeProvedores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarpetas;
        private System.Windows.Forms.TreeView twCarpetasProvedores;
        private System.Windows.Forms.Label lblDatos;
    }
}