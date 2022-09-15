using CursoEFCore.Modelos;
using CursoEFCore.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CursoEFCore.Controllers
{
    /// <summary>
    /// Este es el controlador de profesor
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ProfesorController : ControllerBase
    {
        private IProfesorService _ProfesorService;

        /// <summary>
        /// Este es el constructor de la clase ProfesorController
        /// </summary>
        /// <param name="profesorService"></param>
        public ProfesorController(IProfesorService profesorService)
        {
            this._ProfesorService = profesorService;
        }

        /// <summary>
        /// Este EndPoint retorna todos los profesores
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllprofesores()
        {
            return Ok(_ProfesorService.GetAllProfesor());
        }

        /// <summary>
        /// Este EndPoint retorna un profesor por su ID
        /// </summary>
        /// <param name="IdProfesor"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{IdProfesor:int}")]
        public IActionResult GetProfesorById(int IdProfesor)
        {
            return Ok(_ProfesorService.GetByIdProfesor(IdProfesor));
        }

        /// <summary>
        /// Este EndPoint Agrega un nuevo profesor
        /// </summary>
        /// <param name="profesor"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddProfesores([FromForm] Profesor profesor)
        {

            ResStruct res = new ResStruct()
            {
                Estado = true,
                MSG = "Profesor agregado con exito."
            };

            if (profesor.Nombre != "" && profesor.Apellido != "" && profesor.Edad != 0) _ProfesorService.AddProfesor(profesor);
            else { res.Estado = false; res.MSG = "LAS PROPIEDADES NO PUEDEN ESTAR VACIAS."; }

            return Ok(new { res.Estado, res.MSG });
        }

        /// <summary>
        /// Este EntPoint actualiza un profesor
        /// </summary>
        /// <param name="profesor"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult UpdateProfesores(Profesor profesor)
        {

            ResStruct res = new ResStruct()
            {
                Estado = true,
                MSG = "Profesor actualizado con exito."
            };

            if (profesor.Nombre != "" && profesor.Apellido != "" && profesor.Edad != 0) _ProfesorService.UpdateProfesor(profesor);
            else { res.Estado = false; res.MSG = "LAS PROPIEDADES NO PUEDEN ESTAR VACIAS."; }

            return Ok(new { res.Estado, res.MSG });

        }

        /// <summary>
        /// Este EndPoint elimina un profesor por el ID
        /// </summary>
        /// <param name="IdProfesor"></param>
        /// <returns></returns>
        [HttpDelete("{IdProfesor:int}")]
        public IActionResult DeleteProfesores(int IdProfesor)
        {
            try
            {
                _ProfesorService.DeleteProfesor(IdProfesor);
                return Ok(new { Estado = true, MSG = "Profesor eliminado con exito." });
            }
            catch (System.Exception e)
            {
                return Ok(new { Estado = false, MSG = "ERROR... NO se pudo eliminar el profesor", exec = e.Message });
            }
        }

    }
}
