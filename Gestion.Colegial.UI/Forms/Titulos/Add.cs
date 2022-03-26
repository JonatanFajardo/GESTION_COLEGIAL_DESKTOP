using Gestion.Colegial.Business.Extensions;
using Gestion.Colegial.Business.Helpers.Alert;
using Gestion.Colegial.Business.Messagebox;
using Gestion.Colegial.Business.Services;
using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.Commons.Extensions;
using Gestion.Colegial.UI.FormsBase;
using Gestion.Colegial.UI.Helpers.Controles;
using System;
using System.Windows.Forms;

namespace Gestion.Colegial.UI.Forms.Titulos
{
    public partial class Add : Add_Base
    {
        // Instancia que contiene la data local y privadamente.
        private static tbTitulos send = new tbTitulos();
        // Instancia del formularkio principal de la seccion list.
        private Titulos.List _list;

        private int _id;

        public Add() { InitializeComponent(); }
        public Add(List list)
        {
            InitializeComponent();
            _list = list;
            load();
        }
        public Add(List list, int id)
        {
            InitializeComponent();
            _list = list;
            _id = id;
            FillControls(id);
            load();
        }

        //Pide los datos a la db y los llena.
        private async void FillControls(int id)
        {
            Answer ServiceInsert = await TitulosServices.ListOne(id);
            if (!ServiceInsert.Access)
            {
                PR_tbTitulos_FindResult Entity = ServiceInsert.Data;
                txtDescripcion.Texts = Entity.Tit_Descripcion;
            }
            else
                MessageBox.Show(ServiceInsert.Message);

        }

        public void load()
        {
            this.Show();

            // Se asigna valores a titulo del formulario segun su accion.
            string Registrar = "Registrar Titulos";
            string Modificar = "Modificar Titulos";
            if (_id.Equals(0))
            {
                label1.Text = Registrar;
                this.Text = Registrar;
            }
            else
            {
                label1.Text = Modificar;
                this.Text = Modificar;
            }
        }

        public async override void OnClick()
        {
            var validation = Validation.CamposVacios(pnBackground);

            //Validaciones generales
            if (validation)
            {
                Warning.ShowDialog($"Rectifique las validaciones e intente nuevamente");
                return;
            }

            // Condicion que indica el tipo de envio que se hara.
            send.Tit_Id = _id;
            send.Tit_Descripcion = txtDescripcion.Texts;

            if (_id.Equals(0))
            {
                send.Tit_UsuarioRegistra = GlobalVariable.Usuario.Usu_Id;
                Boolean respond = await TitulosServices.Add(send);
                if (respond)
                    goto Error;

                Alert.Show(Alert.enmType.Success);
                _list.DataGridViewFill();
                ControlsPlugin.CleanIfCompleted(pnBackground);
                this.Hide();
                return;
            }
            else
            {
                send.Tit_UsuarioModifica = GlobalVariable.Usuario.Usu_Id;
                Boolean respond = await TitulosServices.Edit(send);
                if (respond)
                    goto Error;

                Alert.Show(Alert.enmType.Success, "El registro se ha modificado satifactoriamente.", "Exito");
                _list.DataGridViewFill();
                ControlsPlugin.CleanIfCompleted(pnBackground);
                this.Hide();
                return;

            }
        Error:
            Alert.Show(Alert.enmType.Error);
            return;

        }
    }
}
