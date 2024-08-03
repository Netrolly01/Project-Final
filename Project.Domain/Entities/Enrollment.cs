using Project.Domain;


namespace SchoolActivityApp.Domain.Entities
{
    public class Enrollment : BaseEntity
    {

        public int InscripcionesId { get; set; }
        public int EstudiantesId { get; set; }
        public DateTime FechaInscripcion { get; set; }
    }
}
