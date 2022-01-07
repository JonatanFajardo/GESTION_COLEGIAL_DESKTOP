using Gestion.Colegial.Business.Extensions;
using Gestion.Colegial.Business.Helpers.Alert;
using Gestion.Colegial.Business.Services;
using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.Commons.Extensions;
using Gestion.Colegial.UI.FormsBase;
using Gestion.Colegial.UI.Helpers.Controles;
using System;
using System.Windows.Forms;

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
        public Add(List list)
        {
            InitializeComponent();
            _list = list;
        }
        public Add(List list, int id)
        {
            _list = list;
            _id = id;
            load();
            FillControls(id);
        }

        private async void FillControls(int id)
        {
            Answer ServiceInsert = await CargosServices.ListOne(id);
            if (!ServiceInsert.Access)
            {
                tbCargos cargosEntity = ServiceInsert.Data;
                //txtDescripcion.Texts = cargosEntity.Car_Descripcio;
            }
            else
                MessageBox.Show(ServiceInsert.Message);

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
                label1.Text = Modificar;
                this.Text = Modificar;
            }
        }
        //public void Send(int id, List list)
        //{
        //    Add add = new Add();
        //    _id = id;
        //    _list = list;
        //    //_send = Send;
        //    add.load();
        //}


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

        private void pnBackground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jnTexBox1_Load(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {
        }

        private void pnHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
