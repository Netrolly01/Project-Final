using Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolActivityApp.Domain.Entities
{
    public class Enrollment : BaseEntity
    {

        public int InscripcionesId { get; set; }
        public int EstudiantesId { get; set; }
        public DateTime FechaInscripcion { get; set; }
    }
}
