﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Gestion.Colegial.Commons.Entities
{
    public partial class tbEncargados_tbAlumnos
    {
        public int Enc_Id { get; set; }
        public int Alu_Id { get; set; }
        public int Par_Id { get; set; }

        public virtual tbAlumnos Alu { get; set; }
        public virtual tbEncargados Enc { get; set; }
        public virtual tbParentescos Par { get; set; }
    }
}