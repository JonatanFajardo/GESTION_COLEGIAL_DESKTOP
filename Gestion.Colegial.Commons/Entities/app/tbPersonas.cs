﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Gestion.Colegial.Commons.Entities
{
    public partial class tbPersonas
    {
        public tbPersonas()
        {
            tbAlumnos = new HashSet<tbAlumnos>();
            tbEmpleados = new HashSet<tbEmpleados>();
            tbEncargados = new HashSet<tbEncargados>();
        }

        /// <summary>
        /// Indica el identificador único de la persona.
        /// </summary>
        public int Per_Id { get; set; }
        /// <summary>
        /// Serie de digitos dado por el registro nacional para distingir únicamente a una persona.
        /// </summary>
        public string Per_Identidad { get; set; }
        /// <summary>
        /// Primer nombre de la persona.
        /// </summary>
        public string Per_PrimerNombre { get; set; }
        /// <summary>
        /// Segundo nombre de la persona.
        /// </summary>
        public string Per_SegundoNombre { get; set; }
        /// <summary>
        /// Primer apellido dado a la persona.
        /// </summary>
        public string Per_ApellidoPaterno { get; set; }
        /// <summary>
        /// Segundo apellido de la persona.
        /// </summary>
        public string Per_ApellidoMaterno { get; set; }
        /// <summary>
        /// Fecha en la que nacio la persona.
        /// </summary>
        public DateTime Per_FechaNacimiento { get; set; }
        /// <summary>
        /// Medio por el cual permite ponerse en contacto mediante mensaje electronico con la persona.
        /// </summary>
        public string Per_CorreoElectronico { get; set; }
        /// <summary>
        /// Almacena una serie de digitos de telefono.
        /// </summary>
        public string Per_Telefono { get; set; }
        /// <summary>
        /// Información sobre una direccion aproximada.
        /// </summary>
        public string Per_Direccion { get; set; }
        /// <summary>
        /// Indica el sexo de la persona.
        /// </summary>
        public string Per_Sexo { get; set; }
        /// <summary>
        /// Indica el estado actual de la persona.
        /// </summary>
        public bool? Per_EsActivo { get; set; }
        public bool Per_EsEliminado { get; set; }
        public int Per_UsuarioRegistra { get; set; }
        public DateTime Per_FechaRegistra { get; set; }
        public int? Per_UsuarioModifica { get; set; }
        public DateTime? Per_FechaModifica { get; set; }

        public virtual tbUsuarios Per_UsuarioModificaNavigation { get; set; }
        public virtual tbUsuarios Per_UsuarioRegistraNavigation { get; set; }
        public virtual ICollection<tbAlumnos> tbAlumnos { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleados { get; set; }
        public virtual ICollection<tbEncargados> tbEncargados { get; set; }
    }
}