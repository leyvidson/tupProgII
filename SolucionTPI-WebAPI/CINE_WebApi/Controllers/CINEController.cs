using AplicacionCINE.Servicios;
using AplicacionCINE.Servicios.Interfaz;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CINE_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CINEController : ControllerBase
    {
        private IServicio oServicio;
        private FabricaServicio oFabrica;

        public CINEController()
        {
            oFabrica = new FabricaServicioImp();        //estas 2 lineas reemplazan a GESTOR
            oServicio = oFabrica.CrearServicio();
        }

        // GET: api/<CINEController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CINEController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        //GEt Clientes
        [HttpGet("/clientes")]
        public IActionResult ObtenerClientes()
        {
            return Ok(oServicio.ConsultarDB("SP_CONSULTAR_CLIENTE"));
        }

        // POST api/<CINEController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            
        }

        // PUT api/<CINEController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<CINEController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
