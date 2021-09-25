﻿using Gestion.Colegial.Business.Extensions;
using Gestion.Colegial.Business.Helpers.Alert;
using Gestion.Colegial.Business.Services;
using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.UI.FormsBase;
using Gestion.Colegial.UI.Helpers.Controles;
using System;

namespace Gestion.Colegial.UI.Forms.Semestres
{
    public partial class Add : Add_Base
    {
        // Instancia que contiene la data local y privadamente.
        private static tbSemestres send = new tbSemestres();
        public Add()
        {
            InitializeComponent();
        }

        public void load()
        {
            this.Show();
            if (send.Sem_Id == 0)
            {
                label1.Text = "Registrar Semestres";
            }
            else
            {
                txtDescripcion.Texts = send.Sem_Descripcion;
                label1.Text = "Modificar Semestres";
            }
        }

        public static void Send(tbSemestres Send)
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
                send.Sem_Descripcion = txtDescripcion.Texts;
                if (send.Sem_Id == 0)
                {
                    Boolean respond = SemestresServices.Add(send);
                    if (!respond)
                    {
                        Alert.Show(Alert.enmType.Success);
                        Semestres.List list = new List();
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
                    Boolean respond = SemestresServices.Edit(send);
                    if (!respond)
                    {
                        Alert.Show(Alert.enmType.Success, "El registro se ha modificado satifactoriamente.", "Exito");
                        Semestres.List list = new List();
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

    }
}
