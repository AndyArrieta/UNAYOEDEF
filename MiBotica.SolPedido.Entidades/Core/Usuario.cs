﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBotica.SolPedido.Entidades.Core
{
    public class Usuario
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string Codigo { get; set; }
        public int IdTipPer = new TipoUsuario().IdTipoPersona;
        public string Descripcion = new TipoUsuario().Descripcion;
        public bool Estado { get; set; }
        public string HoraI { get; set; }
        public string HoraS { get; set; }
        public string Dias { get; set; }
        public string Especialidad { get; set; }
        public int ndni { get; set; }
        public byte[] ClaveE { get; set; }

    }

}
