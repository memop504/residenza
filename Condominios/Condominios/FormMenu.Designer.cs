namespace Condominios
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.apartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enMantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocupadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeMantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeFinalizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apartamentosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // apartamentosToolStripMenuItem
            // 
            this.apartamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disponiblesToolStripMenuItem,
            this.enMantenimientoToolStripMenuItem,
            this.ocupadosToolStripMenuItem});
            this.apartamentosToolStripMenuItem.Name = "apartamentosToolStripMenuItem";
            this.apartamentosToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.apartamentosToolStripMenuItem.Text = "Apartamentos";
            // 
            // disponiblesToolStripMenuItem
            // 
            this.disponiblesToolStripMenuItem.Name = "disponiblesToolStripMenuItem";
            this.disponiblesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.disponiblesToolStripMenuItem.Text = "Disponibles";
            this.disponiblesToolStripMenuItem.Click += new System.EventHandler(this.disponiblesToolStripMenuItem_Click);
            // 
            // enMantenimientoToolStripMenuItem
            // 
            this.enMantenimientoToolStripMenuItem.Name = "enMantenimientoToolStripMenuItem";
            this.enMantenimientoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.enMantenimientoToolStripMenuItem.Text = "En Mantenimiento";
            // 
            // ocupadosToolStripMenuItem
            // 
            this.ocupadosToolStripMenuItem.Name = "ocupadosToolStripMenuItem";
            this.ocupadosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ocupadosToolStripMenuItem.Text = "Ocupados";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesDeMantenimientoToolStripMenuItem,
            this.reporteDeFinalizacionToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportesDeMantenimientoToolStripMenuItem
            // 
            this.reportesDeMantenimientoToolStripMenuItem.Name = "reportesDeMantenimientoToolStripMenuItem";
            this.reportesDeMantenimientoToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.reportesDeMantenimientoToolStripMenuItem.Text = "Reportes de Mantenimiento";
            // 
            // reporteDeFinalizacionToolStripMenuItem
            // 
            this.reporteDeFinalizacionToolStripMenuItem.Name = "reporteDeFinalizacionToolStripMenuItem";
            this.reporteDeFinalizacionToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.reporteDeFinalizacionToolStripMenuItem.Text = "Reporte de Finalizacion";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem apartamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disponiblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enMantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocupadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeMantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeFinalizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}