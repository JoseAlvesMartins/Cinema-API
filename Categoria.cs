namespace CinemaApi.Models
{
    public class Categoria
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Subtitulo { get; set; }

        public Categoria()
        {
        }

        public Categoria(string id, string nome, string subtitulo)
        {
            Id = id;
            Nome = nome;
            Subtitulo = subtitulo;
        }
    }
}
