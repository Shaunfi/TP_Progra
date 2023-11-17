using Backend.Entidades;
using Backend.Factory;
using Backend.Servicio;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIFarmacia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private IServicios servicio;
        private static List<Clientes> lClientes = new List<Clientes>();


        // agregar constructor que cree el servicio
        public ClientesController()
        {
            servicio = new FactoryImp().CrearServicio();
        }


        // GET: api/<ClientesController>
        [HttpGet("Consultar")]
        public IActionResult Get()
        {
            List<object> list = new List<object>();
            try
            {
                list = servicio.Clientes.Listar();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        // GET api/<ClientesController>/nombre
        [HttpGet("Consultar/{nombre}")]
        public IActionResult Get(string nombre)
        {
            try
            {
                if(nombre == null)
                {
                    return BadRequest("Debes pasar un nombre");
                }
                return Ok(servicio.Clientes.ListarFiltro(nombre));
            }
            catch(Exception ex)
            {
                return BadRequest("No se encontraron clientes");
            }
        }

        // GET api/<ClientesController>/nombre
        [HttpGet("Consultar/{nombre}/{nroDoc}")]
        public IActionResult Get(string nombre, int nroDoc)
        {
            try
            {
                if (nombre != null && nroDoc > 0)
                {
                    return Ok(servicio.Clientes.ListarFiltro(nombre, nroDoc));
                }
                return BadRequest("Debes pasar un nombre");
            }
            catch (Exception ex)
            {
                return BadRequest("No se encontraron clientes");
            }
        }

        // POST api/<ClientesController>
        [HttpPost]
        public IActionResult Post(Clientes cli)
        {
            try
            {
                if(cli == null)
                {
                    return BadRequest("Debes pasar un cliente");
                }
                return Ok(servicio.Clientes.Agregar(cli));
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego . " + ex.Message);
            }
        }

        // PUT api/<ClientesController>/5
        [HttpPost("Modificar")]
        public IActionResult Put([FromBody] Clientes cliente)
        {
            try
            {
                if (cliente == null)
                {
                    return BadRequest("Debes pasar un cliente para modificar");
                }
                return Ok(servicio.Clientes.Modificar(cliente));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego . " + ex.Message);
            }
        }

        //// DELETE api/<ClientesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
