namespace ProEventos.API.Models
{
    public class Evento
    {
        
        public int eventoId { get; set; }
        public string local{ get; set; }

        public string dataEvento { get; set; }

        public string tema { get; set; }

        public int quantidadePessoa { get; set; }

        public string lote { get; set; }

        public string imagemURL { get; set; }



    }
}