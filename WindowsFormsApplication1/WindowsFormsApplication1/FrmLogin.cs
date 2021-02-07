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
        public FrmLogin()
        {
            InitializeComponent();
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
           

            if (usuario == "admin"  && contrasena == "1234")
            {
                this.Close();
               
            }
            else
      
            if (usuario2 == "admin97" && contrasena == "1997")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }

             

        }
    }
}
