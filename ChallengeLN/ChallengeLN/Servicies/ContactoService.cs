using ChallengeLN.Context;
using ChallengeLN.Helpers;
using ChallengeLN.Models;
using ChallengeLN.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace ChallengeLN.Servicies
{
    public class ContactoService
    {
        private readonly ChallengeLnContext _dbContext;

        public ContactoService(ChallengeLnContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Contacto> GetById(int id) => await _dbContext.Contactos.Include(c => c.Domicilio).FirstOrDefaultAsync(c => c.Id == id);
        public async Task Save(ContactoDTO contactoDTO)
        {
            Contacto contacto = new();
            contacto = ContactoHelper.ConvertContactoDTOToContacto(contactoDTO, contacto);
            await _dbContext.Domicilios.AddAsync(contacto.Domicilio);

            await _dbContext.Contactos.AddAsync(contacto);
            await _dbContext.SaveChangesAsync();

        }

        public async Task Update(ContactoDTO contactoDTO, Contacto contacto)
        {
            contacto = ContactoHelper.ConvertContactoDTOToContacto(contactoDTO, contacto);
            _dbContext.Domicilios.Update(contacto.Domicilio);
            _dbContext.Contactos.Update(contacto);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Contacto contacto)
        {
            _dbContext.Domicilios.Remove(contacto.Domicilio);
            _dbContext.Contactos.Remove(contacto);
            await _dbContext.SaveChangesAsync();
        }
    }
}
