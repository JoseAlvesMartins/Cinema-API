namespace CinemaApi.Models
{
    public class Destaque
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Imagem { get; set; }

        public Destaque()
        {
        }

        public Destaque(string id, string titulo, string imagem)
        {
            Id = id;
            Titulo = titulo;
            Imagem = imagem;
        }
    }
}
