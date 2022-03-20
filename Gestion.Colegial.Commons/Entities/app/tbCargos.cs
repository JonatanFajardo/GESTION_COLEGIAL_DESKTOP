﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Gestion.Colegial.Commons.Entities
{
    public partial class tbCargos
    {
        public tbCargos()
        {
            tbEmpleados = new HashSet<tbEmpleados>();
        }

        /// <summary>
        /// Identificador único del puesto.
        /// </summary>
        public int Car_Id { get; set; }
        /// <summary>
        /// Dato informativo del cargo.
        /// </summary>
        public string Car_Descripcion { get; set; }
        public bool Car_EsEliminado { get; set; }
        public int Car_UsuarioRegistra { get; set; }
        public DateTime Car_FechaRegistra { get; set; }
        public int? Car_UsuarioModifica { get; set; }
        public DateTime? Car_FechaModifica { get; set; }

        public virtual tbUsuarios Car_UsuarioModificaNavigation { get; set; }
        public virtual tbUsuarios Car_UsuarioRegistraNavigation { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleados { get; set; }
    }
}