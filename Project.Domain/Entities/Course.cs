namespace SchoolActivityApp.Domain.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public required string NombreCursoAula { get; set; }
        public int Capacidad { get; set; }
    }
}
