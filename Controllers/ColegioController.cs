using CursoEFCore.Modelos;
using CursoEFCore.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CursoEFCore.Controllers
{
    /// <summary>
    /// Este es el controlador de Colegio
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ColegioController : ControllerBase
    {

        private IColegioService _ColegioService;

        /// <summary>
        /// Este es el constructor de la clase ColegioController
        /// </summary>
        /// <param name="colegioService"></param>
        public ColegioController(IColegioService colegioService)
        {
            this._ColegioService = colegioService;
        }

        /// <summary>
        /// Este EndPoint retorna todos los Colegio
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllColegio()
        {
            return Ok(_ColegioService.GetAllColegio());
        }

        /// <summary>
        /// Este EndPoint retorna un Colegio por su ID
        /// </summary>
        /// <param name="IdColegio"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{IdColegio:int}")]
        public IActionResult GetColegioById(int IdColegio)
        {
            return Ok(_ColegioService.GetByIdColegio(IdColegio));
        }

        /// <summary>
        /// Este EndPoint Agrega un nuevo Colegio
        /// </summary>
        /// <param name="Colegio"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddColegio([FromForm] Colegio Colegio)
        {

            ResStruct res = new ResStruct()
            {
                Estado = true,
                MSG = "Colegio agregado con exito."
            };

            if (Colegio.Nombre != "") _ColegioService.AddColegio(Colegio);
            else { res.Estado = false; res.MSG = "LAS PROPIEDADES NO PUEDEN ESTAR VACIAS."; }

            return Ok(new { res.Estado, res.MSG });
        }

        /// <summary>
        /// Este EntPoint actualiza un Colegio
        /// </summary>
        /// <param name="Colegio"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult UpdateColegio(Colegio Colegio)
        {

            ResStruct res = new ResStruct()
            {
                Estado = true,
                MSG = "Colegio actualizado con exito."
            };

            if (Colegio.Nombre != "") _ColegioService.UpdateColegio(Colegio);
            else { res.Estado = false; res.MSG = "LAS PROPIEDADES NO PUEDEN ESTAR VACIAS."; }

            return Ok(new { res.Estado, res.MSG });

        }

        /// <summary>
        /// Este EndPoint elimina un Colegio por el ID
        /// </summary>
        /// <param name="IdColegio"></param>
        /// <returns></returns>
        [HttpDelete("{IdColegio:int}")]
        public IActionResult DeleteColegio(int IdColegio)
        {
            try
            {
                _ColegioService.DeleteColegio(IdColegio);
                return Ok(new { Estado = true, MSG = "Colegio eliminado con exito." });
            }
            catch (System.Exception e)
            {
                return Ok(new { Estado = false, MSG = "ERROR... NO se pudo eliminar el Colegio", exec = e.Message });
            }
        }

    }
}
