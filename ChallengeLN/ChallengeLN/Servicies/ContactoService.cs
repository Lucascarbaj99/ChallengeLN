using ChallengeLN.Context;
using ChallengeLN.Helpers;
using ChallengeLN.Models;
using ChallengeLN.Models.DTOs;

namespace ChallengeLN.Servicies
{
    public class ContactoService
    {
        private readonly ChallengeLnContext _dbContext;

        public ContactoService(ChallengeLnContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Contacto> GetById(int id) => await _dbContext.Contactos.FindAsync(id);
        public async Task Save(ContactoDTO contactoDTO)
        {
            Contacto contacto = new();
            contacto = ContactoHelper.ConvertContactoDTOToContacto(contactoDTO, contacto);
            await _dbContext.Contactos.AddAsync(contacto);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(ContactoDTO contactoDTO)
        {
            Contacto contacto = new();
            contacto = ContactoHelper.ConvertContactoDTOToContacto(contactoDTO, contacto);
            _dbContext.Contactos.Update(contacto);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Contacto contacto)
        {
            _dbContext.Contactos.Remove(contacto);
            await _dbContext.SaveChangesAsync();
        }
    }
}
