namespace CinemaApi.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int IdItem { get; set; }     
        public string Horario { get; set; }  

        public Reserva()
        {
        }

        public Reserva(int id, int idItem, string horario)
        {
            Id = id;
            IdItem = idItem;
            Horario = horario;
        }
    }
}
