using System;

namespace WindowsFormsApplication1
{
    partial class FrmMenuPrincipal
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
            this.trnsaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionMensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAIYRangoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trnsaccionesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.reportesToolStripMenuItem1,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trnsaccionesToolStripMenuItem
            // 
            this.trnsaccionesToolStripMenuItem.Name = "trnsaccionesToolStripMenuItem";
            this.trnsaccionesToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturacionMensualToolStripMenuItem,
            this.facturasCreditoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // facturacionMensualToolStripMenuItem
            // 
            this.facturacionMensualToolStripMenuItem.Name = "facturacionMensualToolStripMenuItem";
            this.facturacionMensualToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.facturacionMensualToolStripMenuItem.Text = "Facturacion Mensual";
            this.facturacionMensualToolStripMenuItem.Click += new System.EventHandler(this.facturacionMensualToolStripMenuItem_Click);
            // 
            // facturasCreditoToolStripMenuItem
            // 
            this.facturasCreditoToolStripMenuItem.Name = "facturasCreditoToolStripMenuItem";
            this.facturasCreditoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.facturasCreditoToolStripMenuItem.Text = "Facturas Credito";
            // 
            // reportesToolStripMenuItem1
            // 
            this.reportesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionEmpresaToolStripMenuItem,
            this.cAIYRangoToolStripMenuItem,
            this.agregarClientesToolStripMenuItem});
            this.reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            this.reportesToolStripMenuItem1.Size = new System.Drawing.Size(101, 20);
            this.reportesToolStripMenuItem1.Text = "Mantenimiento";
            this.reportesToolStripMenuItem1.Click += new System.EventHandler(this.reportesToolStripMenuItem1_Click);
            // 
            // informacionEmpresaToolStripMenuItem
            // 
            this.informacionEmpresaToolStripMenuItem.Name = "informacionEmpresaToolStripMenuItem";
            this.informacionEmpresaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.informacionEmpresaToolStripMenuItem.Text = "Informacion Empresa";
            this.informacionEmpresaToolStripMenuItem.Click += new System.EventHandler(this.informacionEmpresaToolStripMenuItem_Click);
            // 
            // cAIYRangoToolStripMenuItem
            // 
            this.cAIYRangoToolStripMenuItem.Name = "cAIYRangoToolStripMenuItem";
            this.cAIYRangoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cAIYRangoToolStripMenuItem.Text = "CAI y Rango";
            // 
            // agregarClientesToolStripMenuItem
            // 
            this.agregarClientesToolStripMenuItem.Name = "agregarClientesToolStripMenuItem";
            this.agregarClientesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.agregarClientesToolStripMenuItem.Text = "Agregar Clientes";
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
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // cotizacionesToolStripMenuItem
            // 
            this.cotizacionesToolStripMenuItem.Name = "cotizacionesToolStripMenuItem";
            this.cotizacionesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.cotizacionesToolStripMenuItem.Text = "Cotizaciones";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.facturacionToolStripMenuItem_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 371);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FrmMenuPrincipal_Load_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void informacionEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionMensualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasCreditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trnsaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informacionEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAIYRangoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClientesToolStripMenuItem;
        private object facturacionToolStripMenuItem1;
        private EventHandler facturasCreditoToolStripMenuItem_Click;

        public object cotizacionToolStripMenuItem { get; private set; }
    }
}