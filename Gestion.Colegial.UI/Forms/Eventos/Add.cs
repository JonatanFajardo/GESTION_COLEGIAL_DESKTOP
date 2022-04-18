using Gestion.Colegial.Business.Extensions;
using Gestion.Colegial.Business.Helpers.Alert;
using Gestion.Colegial.Business.Messagebox;
using Gestion.Colegial.Business.Services;
using Gestion.Colegial.Commons.Extensions;
using Gestion.Colegial.UI.FormsBase;
using Gestion.Colegial.UI.Helpers.Controles;
using GESTION_COLEGIAL.Entities.Entities;
using System;
using System.Windows.Forms;

namespace Gestion.Colegial.UI.Forms.Eventos
{
    public partial class Add : Add_Base
    {
        // Instancia que contiene la data local y privadamente.
        private static tbEventos send = new tbEventos();
        // Instancia del formularkio principal de la seccion list.
        private Gestion.Colegial.UI.Forms.Eventos.List _list;

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
            Answer ServiceInsert = await EventosServices.ListOne(id);
            if (!ServiceInsert.Access)
            {
                PR_tbEventos_FindResult Entity = ServiceInsert.Data;
                even_Nombre.Texts = Entity.even_Nombre;
                even_Nombre.Texts = Entity.even_Informacion;
                even_Nombre.Texts = Entity.even_Fecha.ToString();
                even_Nombre.Texts = Entity.even_Hora.ToString();
            }
            else
                MessageBox.Show(ServiceInsert.Message);

        }

        public void load()
        {
            this.Show();

            // Se asigna valores a titulo del formulario segun su accion.
            string Registrar = "Registrar Eventos";
            string Modificar = "Modificar Eventos";
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
            send.even_Id = _id;
            send.even_Nombre = even_Nombre.Texts;
            send.even_Informacion = even_Informacion.Texts;
            send.even_Fecha = even_Fecha.Value;
            send.even_Hora = TimeSpan.Parse(even_Hora.Value.ToString());

            if (_id.Equals(0))
            {
                send.even_UsuarioRegistra = GlobalVariable.Usuario.Usu_Id;
                Boolean respond = await EventosServices.Add(send);
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
                send.even_UsuarioModifica = GlobalVariable.Usuario.Usu_Id;
                Boolean respond = await EventosServices.Edit(send);
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
