﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void cotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCotizacion = new FrmCotizacion();
            frmCotizacion.MdiParent = this;
            frmCotizacion.Show();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void facturacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmFactura = new FrmFactura();
            frmFactura.MdiParent = this;
            frmFactura.Show();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturacionMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
