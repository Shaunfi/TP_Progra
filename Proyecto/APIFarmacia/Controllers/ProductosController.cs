using Backend.Entidades;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIFarmacia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {

        private static List<Productos> lProductos = new List<Productos>();

        // GET: api/<ProductosController>
        [HttpGet]
        public IActionResult Get()
        {

            return Ok(lProductos);
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
                return BadRequest();
            }
            lProductos.Add(dto);
            return Ok("Se registro el producto exitosamente!");
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
