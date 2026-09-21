namespace CinemaApi.Models
{
    public class ItemCatalogo
    {
        public int Id { get; set; }
        public string Categoria { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public double Nota { get; set; }
        public string Duracao { get; set; }
        public string Genero { get; set; }
        public string Imagem { get; set; }
        public string Sinopse { get; set; }

        public ItemCatalogo()
        {
        }

        public ItemCatalogo(int id, string categoria, string titulo, int ano, double nota,
                            string duracao, string genero, string imagem, string sinopse)
        {
            Id = id;
            Categoria = categoria;
            Titulo = titulo;
            Ano = ano;
            Nota = nota;
            Duracao = duracao;
            Genero = genero;
            Imagem = imagem;
            Sinopse = sinopse;
        }
    }
}
