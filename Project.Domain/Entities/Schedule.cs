using Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolActivityApp.Domain.Entities
{
    public class Schedule : BaseEntity
    {
        public string DiaSemana { get; set; }
        public int HoraInicio { get; set; }
        public int Horafin { get; set; }
    }
}
