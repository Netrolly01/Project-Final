﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolActivityApp.Application.Dtos.Course
{
    public class CreateCourseDto
    {
        public int CursoID { get; set; }
        public required string NombreCursoAula { get; set; }
        public int Capacidad { get; set; }
    }
}
