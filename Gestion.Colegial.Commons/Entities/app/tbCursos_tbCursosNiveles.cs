﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Gestion.Colegial.Commons.Entities
{
    public partial class tbCursos_tbCursosNiveles
    {
        public int Cur_Id { get; set; }
        public int Cun_Id { get; set; }

        public virtual tbCursosNiveles Cun { get; set; }
        public virtual tbCursos Cur { get; set; }
    }
}