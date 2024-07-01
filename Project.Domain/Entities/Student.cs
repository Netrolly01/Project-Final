using Project.Domain;

namespace SchoolActivityApp.Domain.Entities
{
    public class Student : BaseEntity
    {
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Grado { get; set;} = string.Empty;
        public string Direccion { get; set;} = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

    }
}
