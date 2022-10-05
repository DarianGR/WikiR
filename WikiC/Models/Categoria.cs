namespace WikiC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string NombreCat { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
