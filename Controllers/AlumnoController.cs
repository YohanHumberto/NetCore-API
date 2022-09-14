using CursoEFCore.Modelos;
using CursoEFCore.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CursoEFCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlumnoController : ControllerBase
    {

        public IAlumnoService _AlumnoService;

        public AlumnoController(IAlumnoService alumnoService)
        {
            this._AlumnoService = alumnoService;
        }

        /// <summary>
        /// Este EndPoint retorna todos los Alumnos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllAlumnos()
        {
            return Ok(_AlumnoService.GetAllAlumno());
        }

        [HttpGet]
        [Route("{IdAlumno:int}")]
        public IActionResult GetAlumnoById(int IdAlumno)
        {
            return Ok(_AlumnoService.GetByIdAlumno(IdAlumno));
        }

        [HttpPost]
        public IActionResult AddAlumnos([FromForm] Alumno alumno)
        {

            ResStruct res = new ResStruct()
            {
                Estado = true,
                MSG = "Alumno agregado con exito."
            };

            if (alumno.Nombre != "" && alumno.Apellido != "" && alumno.Edad != 0) _AlumnoService.AddAlumno(alumno);
            else { res.Estado = false; res.MSG = "LAS PROPIEDADES NO PUEDEN ESTAR VACIAS."; }

            return Ok(new { res.Estado, res.MSG });
        }

        [HttpPut]
        public IActionResult UpdateAlumnos(Alumno alumno)
        {

            ResStruct res = new ResStruct()
            {
                Estado = true,
                MSG = "Alumno actualizado con exito."
            };

            if (alumno.Nombre != "" && alumno.Apellido != "" && alumno.Edad != 0) _AlumnoService.UpdateAlumno(alumno);
            else { res.Estado = false; res.MSG = "LAS PROPIEDADES NO PUEDEN ESTAR VACIAS."; }

            return Ok(new { res.Estado, res.MSG });

        }

        [HttpDelete("{IdAlumno:int}")]
        public IActionResult DeleteAlumnos(int IdAlumno)
        {
            try
            {
                _AlumnoService.DeleteAlumno(IdAlumno);
                return Ok(new { Estado = true, MSG = "Alumno eliminado con exito." });
            }
            catch (System.Exception e)
            {
                return Ok(new { Estado = false, MSG ="ERROR... NO se pudo eliminar el alumno", exec=  e.Message });
            }
        }

    }

    class ResStruct
    {
        public bool Estado;
        public string MSG;
    }
}
