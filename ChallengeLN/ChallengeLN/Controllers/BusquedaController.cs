using ChallengeLN.Models;
using ChallengeLN.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeLN.Controllers
{
    [ApiController]
    [Route("busqueda")]
    public class BusquedaController : Controller
    {
        private readonly IRepositorioBusqueda _repositorioBusqueda;

        public BusquedaController(IRepositorioBusqueda repositorioBusqueda)
        {
            _repositorioBusqueda = repositorioBusqueda;
        }
        [HttpGet]
        [Route("search/{parametro}")]
        public async Task<IActionResult> Buscar(string parametro)
        {
            try
            {
                List<Contacto> resultados = await _repositorioBusqueda.BuscarPorParametro(parametro);
                if (!resultados.Any())
                    return NotFound("No se encontraron resultados");
                return Ok(resultados);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
