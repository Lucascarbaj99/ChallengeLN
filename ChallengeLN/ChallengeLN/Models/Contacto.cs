namespace ChallengeLN.Models;

public partial class Contacto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Empresa { get; set; } = null!;

    public string Imagen { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime FechaNacimiento { get; set; }

    public string Telefono { get; set; } = null!;

    public string Domicilio { get; set; } = null!;
}
