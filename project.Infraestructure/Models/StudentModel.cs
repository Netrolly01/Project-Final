﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolActivityApp.Infraestructure.Models
{
    public class StudentModel
    {
        public int Id { get; set; } 
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Grado { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }

    }
}
