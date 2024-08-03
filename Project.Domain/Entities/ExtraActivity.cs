using Project.Domain;
using SchoolActivityApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolActivityApp.Domain.Entities
{
    public class ExtraActivity : BaseEntity
    {
        public int ActividadID { get; set; }
        public required string NombreActividad { get; set; }
        public required string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin {  get; set; }
        public int InstructorID { get; set; }
        public int CursoID { get; set; }



    }
}
