namespace ApiPruebaCode.Models
{
    public class Detalle{
        public int Id { get; set; }
        public string tipo_direccion { get; set; }
        
        public int UsuarioId { get; set; }
        
        public int DireccionId { get; set; }

        public Usuario Usuario { get; set; }

        public Direccion Direccion {get;set;}

        
    }
}