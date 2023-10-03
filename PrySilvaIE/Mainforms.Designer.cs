namespace PrySilvaIE
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.registroProvedorDeSegurosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.listadoDeProvedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.carpetasDeProvedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.provedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(953, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.provedoresToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.registroProvedorDeSegurosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.listadoDeProvedoresToolStripMenuItem,
            this.toolStripMenuItem3,
            this.carpetasDeProvedoresToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // provedoresToolStripMenuItem1
            // 
            this.provedoresToolStripMenuItem1.Name = "provedoresToolStripMenuItem1";
            this.provedoresToolStripMenuItem1.Size = new System.Drawing.Size(288, 26);
            this.provedoresToolStripMenuItem1.Text = "Provedores";
            this.provedoresToolStripMenuItem1.Click += new System.EventHandler(this.provedoresToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(285, 6);
            // 
            // registroProvedorDeSegurosToolStripMenuItem
            // 
            this.registroProvedorDeSegurosToolStripMenuItem.Name = "registroProvedorDeSegurosToolStripMenuItem";
            this.registroProvedorDeSegurosToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.registroProvedorDeSegurosToolStripMenuItem.Text = "Registro provedor de seguros";
            this.registroProvedorDeSegurosToolStripMenuItem.Click += new System.EventHandler(this.registroProvedorDeSegurosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(285, 6);
            // 
            // listadoDeProvedoresToolStripMenuItem
            // 
            this.listadoDeProvedoresToolStripMenuItem.Name = "listadoDeProvedoresToolStripMenuItem";
            this.listadoDeProvedoresToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.listadoDeProvedoresToolStripMenuItem.Text = "Listado de provedores";
            this.listadoDeProvedoresToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProvedoresToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(285, 6);
            // 
            // carpetasDeProvedoresToolStripMenuItem
            // 
            this.carpetasDeProvedoresToolStripMenuItem.Name = "carpetasDeProvedoresToolStripMenuItem";
            this.carpetasDeProvedoresToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.carpetasDeProvedoresToolStripMenuItem.Text = "Carpetas de provedores";
            this.carpetasDeProvedoresToolStripMenuItem.Click += new System.EventHandler(this.carpetasDeProvedoresToolStripMenuItem_Click);
            // 
            // provedoresToolStripMenuItem
            // 
            this.provedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem});
            this.provedoresToolStripMenuItem.Name = "provedoresToolStripMenuItem";
            this.provedoresToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.provedoresToolStripMenuItem.Text = "Gestion";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.registroToolStripMenuItem.Text = "Provedores";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(953, 444);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestion de Ventas de Seguros";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem provedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem provedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registroProvedorDeSegurosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProvedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem carpetasDeProvedoresToolStripMenuItem;
    }
}