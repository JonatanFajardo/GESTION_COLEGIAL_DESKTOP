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
        // Instancia del formularkio principal de la seccion list.
        private Cargos.List _list;

        private int _id;

        public Add() { }
        public Add(int id, List list)
        {
            InitializeComponent();
            _list = list;
            _id = id;
            load(id);
        }

        public void load(int id)
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
                label1.Text = Modificar;
                this.Text = Modificar;
            }
        }
        public static void Send(int id, )
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
                send.Car_Descripcion = txtDescripcion.Texts;
                send.Car_UsuarioRegistra = GlobalVariable.Usuario.Usu_Id;
                if (send.Car_Id == 0)
                {
                    Boolean respond = await CargosServices.Add(send);
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
                    send.Car_UsuarioModifica = GlobalVariable.Usuario.Usu_Id;
                    Boolean respond = await CargosServices.Edit(send);
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
