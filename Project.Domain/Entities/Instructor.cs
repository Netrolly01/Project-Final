using Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolActivityApp.Domain.Entities
{
    public class Instructor : BaseEntity
    {
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string Telefono { get; set; }
        public required string Email { get; set;}
        public required string Especializacion { get; set; }
    }
}
