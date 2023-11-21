using Backend.Entidades;
using Backend.Factory;
using Backend.Servicio;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIFarmacia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturasController : ControllerBase
    {

        private IServicios servicio;


        // agregar constructor que cree el servicio
        public FacturasController()
        {
            servicio = new FactoryImp().CrearServicio();
        }


        // GET: api/<FacturasController>
        //[HttpGet("Consultar/{hasta}/{desde}/{cliente}/{nroF}")]
        [HttpGet("Consultar")]
        public IActionResult Get(DateTime hasta, DateTime desde, string cliente, int nroF)
        {
            List<object> list = null;
            try
            {
                // ver si algun parametro puede ser null, manejarlo
                cliente = cliente != null ? cliente : String.Empty;
                list = servicio.Facturas.ListarFiltros(desde, hasta, cliente, nroF);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        // GET api/<FacturasController>/5
        [HttpGet("{id}/detalles")]
        public IActionResult GetDetalles(int id)
        {
            try
            {
                if(id == 0)
                {
                    return BadRequest("Debes proporcionar un id");
                }
                return Ok(servicio.Facturas.ListarDetalles(id));
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // POST api/<FacturasController>
        [HttpPost]
        public IActionResult Post(Facturas factura)
        {
            try
            {
                if(factura == null)
                {
                    return BadRequest("Debes pasar una factura");
                }
                return Ok(servicio.Facturas.Agregar(factura));
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT api/<FacturasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FacturasController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                servicio.Facturas.DarDeBaja(id);
                return Ok("Se dio de baja la factura " + id.ToString());
            } 
            catch (Exception ex)
            {
                return BadRequest("No se pudo efectuar la baja");
            }

        }
    }
}
