using ChallengeLN.Models;
using ChallengeLN.Models.DTOs;

namespace ChallengeLN.Helpers
{
    public static class ContactoHelper
    {
        public static Contacto ConvertContactoDTOToContacto(ContactoDTO contactoDTO, Contacto contacto)
        {
            contacto.Id = contactoDTO.Id;
            contacto.Nombre = contactoDTO.Nombre ?? contacto.Nombre;
            contacto.Empresa = contactoDTO.Empresa ?? contacto.Empresa;
            contacto.Domicilio = contactoDTO.Domicilio ?? contacto.Domicilio;
            contacto.Email = contactoDTO.Email ?? contacto.Email;
            contacto.FechaNacimiento = contactoDTO.FechaNacimiento is null ? contacto.FechaNacimiento : DateTime.Parse(contactoDTO.FechaNacimiento);
            contacto.Imagen = contactoDTO.Imagen ?? contacto.Imagen;
            contacto.Telefono  = contactoDTO.Telefono ?? contacto.Telefono;
            return contacto;
        }
    }
}
