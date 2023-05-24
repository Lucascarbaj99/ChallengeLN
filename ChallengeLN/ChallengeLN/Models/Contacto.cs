using System.Text.Json.Serialization;

namespace ChallengeLN.Models;

public partial class Contacto
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Empresa { get; set; }
    public string? Imagen { get; set; }
    public string? Email { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string? Telefono { get; set; }
    [JsonIgnore]
    public int DomicilioId { get; set; }
    [JsonRequired]
    public virtual Domicilio Domicilio { get; set; }
}
