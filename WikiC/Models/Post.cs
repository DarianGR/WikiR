namespace WikiC.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int TagId { get; set; }
        public Tag Tags { get; set; }
    }
}
