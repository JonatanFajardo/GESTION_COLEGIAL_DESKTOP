﻿using Gestion.Colegial.Business.Extensions;
using Gestion.Colegial.Business.Helpers.Alert;
using Gestion.Colegial.Business.Services;
using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.UI.FormsBase;
using Gestion.Colegial.UI.Helpers.Controles;
using System;

namespace Gestion.Colegial.UI.Forms.Parciales
{
    public partial class Add : Add_Base
    {
        // Instancia que contiene la data local y privadamente.
        private static tbParciales send = new tbParciales();
        // Instancia del formulario principal de la seccion list.
        Parciales.List _list;

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
            string Registrar = "Registrar Parciales";
            string Modificar = "Modificar Parciales";
            if (send.Pac_Id == 0)
            {
                label1.Text = Registrar;
                this.Text = Registrar;
            }
            else
            {
                txtDescripcion.Texts = send.Pac_Descripcion;
                label1.Text = Modificar;
                this.Text = Modificar;
            }
        }

        public static void Send(tbParciales Send)
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
                send.Pac_Descripcion = txtDescripcion.Texts;
                send.Pac_UsuarioRegistra = GlobalVariable.Usuario.Usu_Id;
                if (send.Pac_Id == 0)
                {
                    Boolean respond = await ParcialesServices.Add(send);
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
                    send.Pac_UsuarioModifica = GlobalVariable.Usuario.Usu_Id;
                    Boolean respond = await ParcialesServices.Edit(send);
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
