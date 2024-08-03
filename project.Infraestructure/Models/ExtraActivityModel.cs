using SchoolActivityApp.Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolActivityApp.Infrastructure.Models
{
    public class ExtraActivityModel
    {
        public int Id { get; set; }
        public int ActividadID { get; set; }
        public string NombreActividad { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int InstructorID { get; set; }
        public int CursoID { get; set; }

     
        public InstructorModel Instructor { get; set; }
        public CourseModel Curso { get; set; }
        public List<EnrollmentModel> Inscripciones { get; set; }
        public List<ScheduleModel> Horarios { get; set; }
    }
}

