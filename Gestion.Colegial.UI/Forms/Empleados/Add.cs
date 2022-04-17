﻿using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.UI.FormsBase;

namespace Gestion.Colegial.UI.Forms.Empleados
{
    public partial class Add : Add_Base
    {
        // Instancia que contiene la data local y privadamente.
        private static tbEmpleados send = new tbEmpleados();
        // Instancia del formularkio principal de la seccion list.
        private Empleados.List _list;

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
            //Answer ServiceInsert = await EmpleadosServices.ListOne(id);
            //if (!ServiceInsert.Access)
            //{
            //    PR_tbEmpleados_FindResult Entity = ServiceInsert.Data;
            //    txtEnc_Ocupacion.Texts = Entity.Enc_Ocupacion;
            //    txtPer_Identidad.Texts = Entity.Per_Identidad.ToString();
            //    txtPer_PrimerNombre.Texts = Entity.Per_PrimerNombre;
            //    txtPer_SegundoNombre.Texts = Entity.Per_SegundoNombre;
            //    txtPer_ApellidoPaterno.Texts = Entity.Per_ApellidoPaterno;
            //    txtPer_ApellidoMaterno.Texts = Entity.Per_ApellidoMaterno;
            //    dtpPer_FechaNacimiento.Value = Entity.Per_FechaNacimiento;
            //    txtPer_CorreoElectronico.Texts = Entity.Per_CorreoElectronico;
            //    txtPer_Telefono.Texts = Entity.Per_Telefono;
            //    txtPer_Direccion.Texts = Entity.Per_Direccion;
            //    txtPer_Sexo.Texts = Entity.Per_Sexo;
            //    cbEsActivo.Checked = Entity.Per_EsActivo;

            //}
            //else
            //    MessageBox.Show(ServiceInsert.Message);
        }

        public void load()
        {
            this.Show();

            // Se asigna valores a titulo del formulario segun su accion.
            string Registrar = "Registrar Empleados";
            string Modificar = "Modificar Empleados";
            if (_id.Equals(0))
            {
                label1.Text = Registrar;
                this.Text = Registrar;
                cbEsActivo.Visible = false;
            }
            else
            {
                label1.Text = Modificar;
                this.Text = Modificar;
            }
        }

        public async override void OnClick()
        {
            //    var validation = Validation.CamposVacios(pnBackground);

            //    // Validaciones especificas
            //    int edad = 18;
            //    if (Utilities.EdadMinima(dtpPer_FechaNacimiento.Value, edad))
            //    {
            //        Warning.ShowDialog($"La edad no debe ser menor a {edad}");
            //        return;
            //    }

            //    //Validaciones generales
            //    if (validation)
            //    {
            //        Warning.ShowDialog($"Rectifique las validaciones e intente nuevamente");
            //        return;
            //    }

            //    // Condicion que indica el tipo de envio que se hara.
            //    send.Enc_Id = _id;
            //    send.Enc_Ocupacion = txtEnc_Ocupacion.Texts;
            //    send.Per_Identidad = txtPer_Identidad.Texts;
            //    send.Per_PrimerNombre = txtPer_PrimerNombre.Texts;
            //    send.Per_SegundoNombre = txtPer_SegundoNombre.Texts;
            //    send.Per_ApellidoPaterno = txtPer_ApellidoPaterno.Texts;
            //    send.Per_ApellidoMaterno = txtPer_ApellidoMaterno.Texts;
            //    send.Per_CorreoElectronico = txtPer_CorreoElectronico.Texts;
            //    send.Per_Telefono = txtPer_Telefono.Texts;
            //    send.Per_Direccion = txtPer_Direccion.Texts;
            //    send.Per_FechaNacimiento = dtpPer_FechaNacimiento.Value;
            //    send.Per_Sexo = txtPer_Sexo.Texts;
            //    send.Per_EsActivo = cbEsActivo.Checked;

            //    if (_id.Equals(0))
            //    {
            //        send.Per_UsuarioRegistra = GlobalVariable.Usuario.Usu_Id;
            //        Boolean respond = await EmpleadosServices.Add(send);
            //        if (respond)
            //            goto Error;

            //        Alert.Show(Alert.enmType.Success);
            //        _list.DataGridViewFill();
            //        ControlsPlugin.CleanIfCompleted(pnBackground);
            //        this.Hide();
            //        return;
            //    }
            //    else
            //    {
            //        send.Per_UsuarioModifica = GlobalVariable.Usuario.Usu_Id;
            //        Boolean respond = await EmpleadosServices.Edit(send);
            //        if (respond)
            //            goto Error;

            //        Alert.Show(Alert.enmType.Success, "El registro se ha modificado satifactoriamente.", "Exito");
            //        _list.DataGridViewFill();
            //        ControlsPlugin.CleanIfCompleted(pnBackground);
            //        this.Hide();
            //        return;

            //    }
            //Error:
            //    Alert.Show(Alert.enmType.Error);
            //    return;

        }

        private void label11_Click(object sender, System.EventArgs e)
        {

        }
    }
}
