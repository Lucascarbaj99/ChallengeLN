using ChallengeLN.Models;
using Microsoft.AspNetCore.Mvc;
using ChallengeLN.Models.DTOs;
using ChallengeLN.Servicies;

namespace ChallengeLN.Controllers
{
    [ApiController]
    [Route("contacto")]
    public class ContactoController : ControllerBase
    {
        private readonly ContactoService _contactoService;

        public ContactoController(ContactoService contactoService)
        {
            _contactoService = contactoService;
        }
        const string wrongInformation = "Verifique la información enviada";
        const string contactNotFound = "Contacto no encontrado";
        [HttpGet]
        [Route("getById/{idContacto:int}")]
        public async Task<IActionResult> GetById(int idContacto)
        {
            try
            {
                Contacto contacto = await _contactoService.GetById(idContacto);
                if (contacto == null)
                    return BadRequest(contactNotFound);

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "OK", response = contacto });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("save")]
        public async Task<IActionResult> Save([FromBody] ContactoDTO contactoDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(wrongInformation);

                await _contactoService.Save(contactoDTO);

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "OK" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> Update([FromBody] ContactoDTO contactoDTO)
        {
            try
            {
                Contacto contacto = await _contactoService.GetById(contactoDTO.Id);
                if (contacto == null)
                    return BadRequest(contactNotFound);

                await _contactoService.Update(contactoDTO);

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "OK" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpDelete]
        [Route("delete/{idContacto:int}")]
        public async Task<IActionResult> Delete(int idContacto)
        {
            string token = Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value;
            if (token != "lucas")
                return Unauthorized("Error de autorización");
            try
            {
                Contacto contacto = await _contactoService.GetById(idContacto);
                if (contacto == null)
                    return BadRequest(contactNotFound);

                await _contactoService.Delete(contacto);
                return Ok("Contacto Eliminado");
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
