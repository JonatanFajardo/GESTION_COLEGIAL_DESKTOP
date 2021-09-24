using Gestion.Colegial.Business.Extensions;
using Gestion.Colegial.Business.Helpers.Alert;
using Gestion.Colegial.Business.Services;
using Gestion.Colegial.Commons.Entities;
using Gestion.Colegial.Commons.Extensions;
using Gestion.Colegial.UI.FormsBase;
using Gestion.Colegial.UI.Helpers.Controles;
using System;
using System.Collections.Generic;
using static Gestion.Colegial.Business.Helpers.Alert.Alert;

namespace Gestion.Colegial.UI.Forms.Modalidades
{
    public partial class Add : Add_Base
    {
        private static List<string> send;
        private static tbModalidades send2;
        //public static List<string> Send { get => send; set => send = value; }
        public Add()
        {
            InitializeComponent();

        }
        public Add(tbModalidades Send)
        {
            Add add = new Add();
            send2 = Send;
            add.load();
        }
        public void load()
        {
            this.Show();
            txtDescripcion.Texts = send2.Mda_Descripcion;
        }

        public static void Send(tbModalidades Send)
        {
            Add add = new Add();
            send2 = Send;
            add.load();
        }

        //public static void Send(List<string> Send)
        //{
        //    Add add = new Add();
        //    add.load(Send);
        //    send = Send;
        //}


        public override void OnClick()
        {
            Answer obj = new Answer();


            var validation = Validation.CamposVacios(pnBackground);
            if (!validation)
            {
                if (send2 == null)
                {
                    var objEntidad = new tbModalidades()
                    {
                        Mda_Descripcion = txtDescripcion.Texts
                    };

                    Boolean respond = ModalidadesServices.Add(objEntidad);
                    if (!respond)
                    {
                        Alert.Show(enmType.Success);
                        Modalidades.List list = new List();
                        list.DataGridViewFill();
                        ControlsPlugin.CleanIfCompleted(pnBackground);

                    }
                    else
                    {

                        Alert.Show(enmType.Error);
                    }
                }
                else
                {
                    var objEntidad = new tbModalidades()
                    {
                        Mda_Id = send2.Mda_Id,
                        Mda_Descripcion = txtDescripcion.Texts
                    };
                    Boolean respond = ModalidadesServices.Edit(objEntidad);
                    if (!respond)
                    {
                        Alert.Show(enmType.Success, "El registro se ha modificado satifactoriamente.","Exito");
                        Modalidades.List list = new List();
                        list.DataGridViewFill();
                        ControlsPlugin.CleanIfCompleted(pnBackground);
                    }
                    else
                    {
                        Alert.Show(enmType.Error);
                    }
                }

            }
            else
            {

            }
        }

    }
}
