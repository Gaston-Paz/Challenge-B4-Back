namespace Backend.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Cuit { get; set; }
        public string? Domicilio { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public Cliente(string nombres, string apellidos, string cuit, string celular, string email)
        {
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Cuit = cuit;
            this.Celular = celular;
            this.Email = email;
        }
    }
}
