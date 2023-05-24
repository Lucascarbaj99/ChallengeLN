using ChallengeLN.Context;
using ChallengeLN.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeLN.Repositorios
{
    public class RepositorioBusqueda : IRepositorioBusqueda
    {
        private readonly ChallengeLnContext _dbContext;

        public RepositorioBusqueda(ChallengeLnContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Contacto>> BuscarPorParametro(string parametro)
        {
            List<Contacto> contactosMatcheados = new();
            if (parametro.Contains("@"))
                contactosMatcheados = await _dbContext.Contactos.Include(x => x.Domicilio).Where(x => x.Email == parametro).ToListAsync();
            else if (int.TryParse(parametro, out int numero))
                contactosMatcheados = await _dbContext.Contactos.Include(x => x.Domicilio).Where(x => x.Telefono == numero.ToString()).ToListAsync();
            else
                contactosMatcheados = await _dbContext.Contactos.Include(x => x.Domicilio).Where(x => x.Domicilio.Ciudad == parametro || x.Domicilio.Direccion == parametro).ToListAsync();
            return contactosMatcheados;
        }
    }
}
