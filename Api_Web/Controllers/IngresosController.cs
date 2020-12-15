using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_Web.Entidades;
using Api_Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngresosController : ControllerBase
    {
        public IngresoServices _ingresos;

        public IngresosController(IngresoServices ingresos)
        {
            _ingresos = ingresos;
        }

        [HttpGet]
        public ActionResult<List<Ingreso>> Get()
        {
            return _ingresos.Get();

        }
        [HttpPost]
        public ActionResult<Ingreso> Create(Ingreso ing)
        {
            _ingresos.Create(ing);
            return Ok(ing);
        }

    }

}