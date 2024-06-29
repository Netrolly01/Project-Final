using Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolActivityApp.Domain.Entities
{
    public class Course : BaseEntity
    {
        public int CursoID { get; set; }
        public string NombreCursoAula { get; set; }
        public int Capacidad { get; set; }
    }
}
