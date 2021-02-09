using BL.Facturacion;
using System;
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
    public partial class FrmLogin : Form
    {
        SeguridadBL _seguridad;

        public FrmLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string usuario2;
            string contrasena;
           
            usuario = textBox1.Text;
            usuario2 = textBox1.Text;
            contrasena = textBox2.Text;

           var resultado = _seguridad.Autorizar(usuario, contrasena);

            if(resultado == true)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }

             

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
