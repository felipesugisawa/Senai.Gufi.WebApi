﻿using System;
using System.Collections.Generic;

namespace Senai.Gufi.WebApi.Domains
{
    public partial class TipoUsuario
    {


        public int IdTipoUsuario { get; set; }

        public string TituloTipoUsuario { get; set; }

        public ICollection<Usuario> Usuario { get; set; }
    }
}
