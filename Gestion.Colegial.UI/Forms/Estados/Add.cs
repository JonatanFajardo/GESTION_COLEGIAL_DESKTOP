using Gestion.Colegial.Business.Extensions;
using Gestion.Colegial.Business.Helpers.Alert;
using Gestion.Colegial.Business.Services;
using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.UI.FormsBase;
using Gestion.Colegial.UI.Helpers.Controles;
using System;

namespace Gestion.Colegial.UI.Forms.Estados
{
    public partial class Add : Add_Base
    {
        // Instancia que contiene la data local y privadamente.
        private static tbEstados send = new tbEstados();
        // Instancia del formulario principal de la seccion list.
        Estados.List _list;

        public Add() { }
        public Add(List list)
        {
            InitializeComponent();
            load();
            _list = list;
        }

        public void load()
        {
            this.Show();

            // Se asigna valores a titulo del formulario segun su accion.
            string Registrar = "Registrar Estados";
            string Modificar = "Modificar Estados";
            if (send.Est_Id == 0)
            {
                label1.Text = Registrar;
                this.Text = Registrar;
            }
            else
            {
                txtDescripcion.Texts = send.Est_Descripcion;
                label1.Text = Modificar;
                this.Text = Modificar;
            }
        }

        public static void Send(tbEstados Send)
        {
            Add add = new Add();
            send = Send;
            add.load();
        }

        public async override void OnClick()
        {
            var validation = Validation.CamposVacios(pnBackground);
            if (!validation)
            {
                // Condicion que indica el tipo de envio que se hara.
                send.Est_Descripcion = txtDescripcion.Texts;
                send.Est_UsuarioRegistra = GlobalVariable.Usuario.Usu_Id;
                if (send.Est_Id == 0)
                {
                    Boolean respond = await EstadosServices.Add(send);
                    if (!respond)
                    {
                        Alert.Show(Alert.enmType.Success);
                        _list.DataGridViewFill();
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
                    send.Est_UsuarioModifica = GlobalVariable.Usuario.Usu_Id;
                    Boolean respond = await EstadosServices.Edit(send);
                    if (!respond)
                    {
                        Alert.Show(Alert.enmType.Success, "El registro se ha modificado satifactoriamente.", "Exito");
                        _list.DataGridViewFill();
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

    }
}
