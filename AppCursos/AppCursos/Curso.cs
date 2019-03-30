using SQLite;

namespace AppCursos
{
    [Table("Cursos")]
  public class Curso
    {
        // El diseño de la entidad Curso.
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Formato { get; set; }
    }
}
