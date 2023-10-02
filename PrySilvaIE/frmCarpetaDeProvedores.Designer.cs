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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarpetaDeProvedores));
            this.twCarpetasProvedores = new System.Windows.Forms.TreeView();
            this.lblDatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // twCarpetasProvedores
            // 
            this.twCarpetasProvedores.Location = new System.Drawing.Point(12, 34);
            this.twCarpetasProvedores.Name = "twCarpetasProvedores";
            this.twCarpetasProvedores.Size = new System.Drawing.Size(299, 304);
            this.twCarpetasProvedores.TabIndex = 1;
            this.twCarpetasProvedores.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.twCarpetasProvedores_AfterSelect_1);
            // 
            // lblDatos
            // 
            this.lblDatos.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(341, 34);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(311, 392);
            this.lblDatos.TabIndex = 2;
            // 
            // frmCarpetaDeProvedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(708, 443);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.twCarpetasProvedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCarpetaDeProvedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carpetas De Provedores";
            this.Load += new System.EventHandler(this.frmCarpetaDeProvedores_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView twCarpetasProvedores;
        private System.Windows.Forms.Label lblDatos;
    }
}