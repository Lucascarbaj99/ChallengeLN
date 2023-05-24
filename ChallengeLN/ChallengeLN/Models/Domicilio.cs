using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ChallengeLN.Models;

public partial class Domicilio
{
    public int Id { get; set; }
    public string? Direccion { get; set; }
    public string? Ciudad { get; set; }

    [JsonIgnore]
    public virtual Contacto? Contacto { get; set; }
}
