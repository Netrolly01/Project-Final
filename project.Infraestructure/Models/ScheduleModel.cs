using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolActivityApp.Infrastructure.Models
{
    public class ScheduleModel
    {
        public int Id { get; set; }
        public string DiaSemana { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan Horafin { get; set; }

      
        public int ActividadID { get; set; }
        public ExtraActivityModel Actividad { get; set; }
    }
}

