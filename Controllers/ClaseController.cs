using CursoEFCore.Modelos;
using CursoEFCore.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CursoEFCore.Controllers
{

    /// <summary>
    /// Este es el controlador de Clase
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ClaseController : ControllerBase
    {
        private IClaseService _ClaseService;

        /// <summary>
        /// Este es el constructor de la clase ClaseController
        /// </summary>
        /// <param name="claseService"></param>
        public ClaseController(IClaseService claseService)
        {
            this._ClaseService = claseService;
        }

        /// <summary>
        /// Este EndPoint retorna todos los Clases
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllClasees()
        {
            return Ok(_ClaseService.GetAllClase());
        }

        /// <summary>
        /// Este EndPoint retorna un Clase por su ID
        /// </summary>
        /// <param name="IdClase"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{IdClase:int}")]
        public IActionResult GetClaseById(int IdClase)
        {
            return Ok(_ClaseService.GetByIdClase(IdClase));
        }

        /// <summary>
        /// Este EndPoint Agrega un nuevo Clase
        /// </summary>
        /// <param name="clase"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddClasees([FromForm] Clase clase)
        {

            ResStruct res = new ResStruct()
            {
                Estado = true,
                MSG = "Clase agregada con exito."
            };

            if (clase.Nombre != "") _ClaseService.AddClase(clase);
            else { res.Estado = false; res.MSG = "LAS PROPIEDADES NO PUEDEN ESTAR VACIAS."; }

            return Ok(new { res.Estado, res.MSG });
        }

        /// <summary>
        /// Este EntPoint actualiza un Clase
        /// </summary>
        /// <param name="clase"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult UpdateClasees(Clase clase)
        {

            ResStruct res = new ResStruct()
            {
                Estado = true,
                MSG = "Clase actualizado=a con exito."
            };

            if (clase.Nombre != "") _ClaseService.UpdateClase(clase);
            else { res.Estado = false; res.MSG = "LAS PROPIEDADES NO PUEDEN ESTAR VACIAS."; }

            return Ok(new { res.Estado, res.MSG });

        }

        /// <summary>
        /// Este EndPoint elimina un Clase por el ID
        /// </summary>
        /// <param name="IdClase"></param>
        /// <returns></returns>
        [HttpDelete("{IdClase:int}")]
        public IActionResult DeleteClasees(int IdClase)
        {
            try
            {
                _ClaseService.DeleteClase(IdClase);
                return Ok(new { Estado = true, MSG = "Clase eliminada con exito." });
            }
            catch (System.Exception e)
            {
                return Ok(new { Estado = false, MSG = "ERROR... NO se pudo eliminar la Clase", exec = e.Message });
            }
        }
    }
}
