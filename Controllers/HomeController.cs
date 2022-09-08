using CursoEFCore.Contexto;
using CursoEFCore.Modelos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CursoEFCore.Controllers
{
    [ApiController]
    [Route("api1/[controller]")]
    public class HomeController : ControllerBase
    {

        private readonly IContextDB _DbContext;

        public HomeController(IContextDB context)
        {
            this._DbContext = context;  
        }

        [HttpGet]
        public List<Colegio> Get()
        {
            _DbContext.Colegios.Add(new Modelos.Colegio());
            _DbContext.Colegios.Add(new Modelos.Colegio());
            _DbContext.SaveChanges(true);

            var colegios = _DbContext.Colegios;

            return new List<Colegio>();
        }
    }
}
