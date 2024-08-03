using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolActivityApp.Application.Dtos.Course
{
    public class UpdateCourseDto
    {
        public int Id { get; set; }
        public int CursoID { get; set; }
        public string? NombreCursoAula { get; set; }
        public int Capacidad { get; set; }
    }
}
