namespace ChallengeLN.Models.DTOs
{
    public class ContactoDTO
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Empresa { get; set; }
        public string? Imagen { get; set; }
        public string? Email { get; set; }
        public string? FechaNacimiento { get; set; }
        public string? Telefono { get; set; }
        public Domicilio? Domicilio { get; set; }
    }
}
