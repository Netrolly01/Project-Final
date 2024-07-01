using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolActivityApp.Infrastructure.Models
{
    public class CourseModel
    {
        public int Id { get; set; }
        public int CursoID { get; set; }
        public string NombreCursoAula { get; set; }
        public int Capacidad { get; set; }
    }
}
