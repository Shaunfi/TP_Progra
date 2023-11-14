using Backend.Entidades;
using Backend.Factory;
using Backend.Servicio;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIFarmacia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private IServicios servicio;
        private static List<Productos> lProductos = new List<Productos>();

        // agregar constructor que cree el servicio
        public ProductosController()
        {
            servicio = new FactoryImp().CrearServicio();
        }

        // GET: api/<ProductosController>
        [HttpGet]
        public IActionResult Get()
        {
            List<object> list = new List<object>();
            try
            {
                list = servicio.Productos.Listar();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        //// GET api/<ProductosController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<ProductosController>
        [HttpPost]
        public IActionResult Post(Productos dto)
        {
            if (dto != null)
            {
                bool result = servicio.Productos.Agregar(dto);
                return Ok("Se registro el producto exitosamente!");
            }
            return BadRequest("Debes pasar el producto");
        }

        //// PUT api/<ProductosController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ProductosController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
