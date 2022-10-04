using Gestion.Colegial.Business.Helpers;
using Gestion.Colegial.Business.Helpers.Alert;
using Gestion.Colegial.Business.Messagebox;
using Gestion.Colegial.Business.Services;
using Gestion.Colegial.Commons.Entities;
using System;
using System.Windows.Forms;

namespace Gestion.Colegial.UI.Forms.Acount
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

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

        private async void btnLog_Click(object sender, EventArgs e)
        {
            var entityAutentication = new tbUsuarios()
            {
                Usu_Name = txtUser.Texts,
                Usu_Contraseña = SecurityEncryptation.Encrypt(txtPassword.Texts)
            };
            // Evaluamos si existe el usuario en la db.
            Boolean result = await AccountServices.Autentication(entityAutentication);
            if (!result)
            {
                // Obtenemos los datos del usuario.
                var resultList = await AccountServices.List(entityAutentication);
                // Evaluamos si el registro no viene vacio.
                if (resultList != null)
                {
                    lblError.Visible = false;
                    FormsBase.BaseMain baseMain = new FormsBase.BaseMain();
                    GlobalVariable.Usuario.Usu_Id = Convert.ToInt32(resultList.Rows[0].ItemArray[0]);
                    GlobalVariable.Usuario.Usu_Nombre = Convert.ToString(resultList.Rows[0].ItemArray[1]);
                    GlobalVariable.Usuario.Usu_Rol = Convert.ToString(resultList.Rows[0].ItemArray[3]);
                    this.Hide();
                    baseMain.Show();
                }
                else
                {
                    Alert.Show(Alert.enmType.Warnin, "Error al ingresar", "No se pudo obtener su información.");
                }

                //GlobalVariable.tbUsuario.
            }
            else
            {
                lblError.Visible = true;
            }
        }
    }
}