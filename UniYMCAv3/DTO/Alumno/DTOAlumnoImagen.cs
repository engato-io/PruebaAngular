﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniYMCAv3.DTO.Alumno
{
    public class DTOAlumnoImagen
    {
        public byte[] imagen { get; set; }
        public string imagenBase64 { get; set; }
        public string extensionImagen { get; set; }
        public string nombre { get; set; }

    }
}
