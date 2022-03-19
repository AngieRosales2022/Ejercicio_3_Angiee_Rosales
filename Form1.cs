using Ejercicio3_AngieeRosales.Acceso;
using Ejercicio3_AngieeRosales.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_AngieeRosales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(textBox1.Text, textBox2.Text);

            if (usuario == null)
            {
                MessageBox.Show("Datos erroneos");

            }
            else
            {
                MessageBox.Show("Login Exitoso");
                Form2 frmUsuarios = new Form2();
                frmUsuarios.Show();


            }


        }
    }
}
