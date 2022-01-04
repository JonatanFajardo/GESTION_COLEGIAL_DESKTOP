using Gestion.Colegial.Business.Services;
using Gestion.Colegial.Commons.Extensions;
using Gestion.Colegial.UI.FormsBase;
using System;

namespace Gestion.Colegial.UI.Forms.Alumnos
{
    public partial class Add : Add_Base
    {
        // Instancia del formulario principal de la seccion list.
        Alumnos.List _list;
        int _id;

        public Add() { }
        public Add(int id, List list)
        {
            InitializeComponent();
            _id = id;
            _list = list;
            //load(id);
        }

        //private async void load(int id)
        //{
        //    Answer ServiceResult = await AlumnosServices.
        //}
    }
}
