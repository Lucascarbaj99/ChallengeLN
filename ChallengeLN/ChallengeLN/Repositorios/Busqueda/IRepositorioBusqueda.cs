using ChallengeLN.Models;

namespace ChallengeLN.Repositorios
{
    public interface IRepositorioBusqueda
    {
        Task<List<Contacto>> BuscarPorParametro(string parametro);
    }
}
