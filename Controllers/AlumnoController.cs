using CursoEFCore.Modelos;
using CursoEFCore.Servicios;
using Microsoft.AspNetCore.Http;
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

        //[HttpGet]
        //public async Task<IActionResult> GetAllAlumnos()
        //{
        //    return Ok(_AlumnoService.GetAllAlumno());
        //}

        [HttpGet]
        public List<Alumno> GetAlumnoById()
        {
            return _AlumnoService.GetAllAlumno();
        }

        //public List<Alumno> AddAlumnos()
        //{
        //    return _AlumnoService.GetAllAlumno();
        //}

        //public List<Alumno> UpdateAlumnos()
        //{
        //    return _AlumnoService.GetAllAlumno();
        //} 

        //public List<Alumno> DeleteAlumnos()
        //{
        //    return _AlumnoService.GetAllAlumno();
        //}

    }
}
