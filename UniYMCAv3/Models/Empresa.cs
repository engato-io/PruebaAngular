﻿using System;
using System.Collections.Generic;

namespace UniYMCAv3.Models
{
    public partial class Empresa
    {
        public Empresa()
        {
            Grupo = new HashSet<Grupo>();
        }

        public int EmpresaId { get; set; }
        public string Rfc { get; set; }
        public string RazonSocial { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaVigencia { get; set; }
        public int UsuarioId { get; set; }

        public virtual DatosFiscales DatosFiscales { get; set; }
        public virtual EmpresaDetalle EmpresaDetalle { get; set; }
        public virtual ICollection<Grupo> Grupo { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
