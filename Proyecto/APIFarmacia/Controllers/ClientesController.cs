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
        [HttpGet]
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

        //// GET api/<ClientesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<ClientesController>
        [HttpPost]
        public IActionResult Post(Clientes dto)
        {
            if(dto != null)
            {
                return BadRequest();
            }
            lClientes.Add(dto);
            return Ok("Se registro el cliente exitosamente!");
        }

        //// PUT api/<ClientesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ClientesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
