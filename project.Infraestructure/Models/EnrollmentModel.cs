using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolActivityApp.Infraestructure.Models
{
    public class EnrollmentModel
    {
    
        public int Id { get; set; }
        public int InscripcionesId { get; set; }
        public int EstudiantesId { get; set; }
        public DateTime FechaInscripcion { get; set; }
    }
}


