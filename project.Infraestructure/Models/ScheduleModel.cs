using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolActivityApp.Infraestructure.Models
{
    public class ScheduleModel

    {
        public int Id { get; set; }
        public string DiaSemana { get; set; }
        public int HoraInicio { get; set; }
        public int Horafin { get; set; }
    }
}
