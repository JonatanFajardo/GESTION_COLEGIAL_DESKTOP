using Gestion.Colegial.Business.Messagebox;
//using Gestion.Colegial.Commons.Clases;
using Gestion.Colegial.Business.Services;
using System;
using System.Windows.Forms;

namespace Gestion.Colegial.UI.Forms.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        B_Usuarios objDatos = new B_Usuarios();



        private void guardar()
        {
            //Boolean validar = objDatos.Login(txtDescripcion.Text, JNTexBox2.Text);

            //if (validar)
            //{
            //    Main form = new Main();
            //    this.Hide();
            //    form.Show();
            //}
            //else
            //{
            //    Error.ShowDialog("Correo o contraseña incorrectos");
            //}
        }

        private void btnloginlbl_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnloginpcb_Click(object sender, EventArgs e)
        {

            guardar();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Warning.ShowDialog("Desea Salir de la aplicacion?");

            if (Warning.isOk())
            {
                Application.Exit();
            }
        }

        private void btnloginpcb_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnloginlbl_Enter(object sender, EventArgs e)
        {

        }
    }
}
