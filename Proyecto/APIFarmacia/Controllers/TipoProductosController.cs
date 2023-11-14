using Backend.Factory;
using Backend.Servicio;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIFarmacia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoProductosController : ControllerBase
    {

        private IServicios servicio;

        // agregar constructor que cree el servicio
        public TipoProductosController()
        {
            servicio = new FactoryImp().CrearServicio();
        }


        // GET: api/<TipoProductosController>
        [HttpGet]
        public IActionResult Get()
        {
            List<object> list = new List<object>();
            try
            {
                list = servicio.TablasAuxiliares.ListarTiposProductos();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<TipoProductosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TipoProductosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TipoProductosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TipoProductosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
