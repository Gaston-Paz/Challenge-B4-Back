using Backend.Helpers.Validations;
using System.ComponentModel.DataAnnotations;

namespace Backend.DTO
{
    public class ClienteDTO
    {
        public int Id { get; set; }

        [RequiredValidation]
        public string? Nombres { get; set; }

        [RequiredValidation]
        public string? Apellidos { get; set; }
        public DateTime? FechaNacimiento { get; set; }

        [CuitValidation]
        [RequiredValidation]
        public string? Cuit { get; set; }
        public string? Domicilio { get; set; }

        [RequiredValidation]
        public string? Celular { get; set; }

        [EmailValidation]
        [RequiredValidation]
        public string? Email { get; set; }

        public ClienteDTO(string nombres, string apellidos, string cuit, string celular, string email)
        {
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Cuit = cuit;
            this.Celular = celular;
            this.Email = email;
        }
    }
}
