﻿using Backend.Entidades;
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

        // GET api/<ProductosController>
        [HttpGet("filtro")]
        public IActionResult GetFiltro(int tipoProducto, string? descripcion)
        {
            
            if(tipoProducto == 0)
            {
                return BadRequest("enviar parametros");
            }
            descripcion = descripcion != null ? descripcion : String.Empty;
            if(descripcion == null || descripcion == "" || descripcion == String.Empty)
            {
                return Ok(servicio.Productos.ListarFiltro(tipoProducto));
            }
            return Ok(servicio.Productos.ListarFiltro(descripcion, tipoProducto));

        }

        // GET api/<ProductosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                // ver porque esta funcion devuelve un string
                string prod = servicio.Productos.ConsultarProducto(id);
                if(prod != null)
                {
                    return Ok(prod);
                }
                else
                {
                    return NotFound("No se encontro el producto con id " + id);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<ProductosController>/deshabilitar/5
        [HttpGet("deshabilitar/{id}")]
        public IActionResult Eliminar(int id)
        {
            try
            {
                // ver porque esta funcion devuelve un string
                bool result = servicio.Productos.DeshabilitarProducto(id);
                if (result == true)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound("No se encontro el producto con id " + id);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<ProductosController>
        [HttpPost]
        public IActionResult Post(Productos dto)
        {
            try
            {
                if (dto == null)
                {
                    return BadRequest("Debes pasar el producto");
                }
                return Ok(servicio.Productos.Agregar(dto));
            }
            catch
            {
                return BadRequest("No se pudo registrar, error");
            }
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
