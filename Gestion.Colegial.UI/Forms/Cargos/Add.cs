using Gestion.Colegial.Business.Extensions;
using Gestion.Colegial.Business.Helpers.Alert;
using Gestion.Colegial.Business.Services;
using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.UI.FormsBase;
using Gestion.Colegial.UI.Helpers.Controles;
using System;

namespace Gestion.Colegial.UI.Forms.Cargos
{
    public partial class Add : Add_Base
    {
        // Instancia que contiene la data local y privadamente.
        private static tbCargos send = new tbCargos();
        public Add()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            this.Show();
            
            // Se asigna valores a titulo del formulario segun su accion.
            string Registrar = "Registrar Cargos";
            string Modificar = "Modificar Cargos";
            if (send.Car_Id == 0)
            {
                label1.Text = Registrar;
                this.Text = Registrar; 
            }
            else
            {
                txtDescripcion.Texts = send.Car_Descripcion;
                this.Text = Modificar;
                this.Text = Modificar;
            }
        }

        public static void Send(tbCargos Send)
        {
            Add add = new Add();
            send = Send;
            add.load();
        }

        public override void OnClick()
        {
            var validation = Validation.CamposVacios(pnBackground);
            if (!validation)
            {
                // Condicion que indica el tipo de envio que se hara.
                send.Car_Descripcion = txtDescripcion.Texts;
                send.Car_UsuarioRegistra = GlobalVariable.Usuario.Usu_Id;
                if (send.Car_Id == 0)
                {
                    Boolean respond = CargosServices.Add(send);
                    if (!respond)
                    {
                        Alert.Show(Alert.enmType.Success);
                        Cargos.List list = new List();
                        list.DataGridViewFill();
                        ControlsPlugin.CleanIfCompleted(pnBackground);
                        this.Hide();
                    }
                    else
                    {
                        Alert.Show(Alert.enmType.Error);
                    }
                }
                else
                {
                    send.Car_UsuarioModifica = GlobalVariable.Usuario.Usu_Id;
                    Boolean respond = CargosServices.Edit(send);
                    if (!respond)
                    {
                        Alert.Show(Alert.enmType.Success, "El registro se ha modificado satifactoriamente.", "Exito");
                        Cargos.List list = new List();
                        list.DataGridViewFill();
                        ControlsPlugin.CleanIfCompleted(pnBackground);
                        this.Hide();
                    }
                    else
                    {
                        Alert.Show(Alert.enmType.Error);
                    }
                }
            }
            else
            {

            }
        }

        private void Add_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            //Cargos.List list = new List();
            //list.DataGridViewFill();
        }
    }
}
