namespace ApiPruebaCode.Models
{
    public class Usuario{
         public int Id { get; set; }
        public string primer_nombre { get; set;}
        public string segundo_nombre { get; set;}

        public string primer_apellido { get; set; }

        public string segundo_apellido { get; set; }
        public string num_idenitificacion { get; set; }
        public string tipo_identificacion { get; set; }

        public DateTime fecha_nacimiento { get; set; }
        public int edad { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        
    }
}