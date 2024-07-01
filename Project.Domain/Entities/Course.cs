using Project.Domain;

namespace SchoolActivityApp.Domain.Entities
{
    public class Course : BaseEntity
    {
        public int CursoID { get; set; }
        public string NombreCursoAula { get; set; }
        public int Capacidad { get; set; }
    }
}
