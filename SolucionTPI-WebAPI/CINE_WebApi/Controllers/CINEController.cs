﻿using AplicacionCINE.Datos;
using AplicacionCINE.Entidades;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CINE_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CINEController : ControllerBase
    {
        private IReservas app; /// Agrego LEO

        public CINEController()
        {
            app = new ReservasDAO(); ////////   Agrego LEO
            
        }
       
        [HttpGet("Reservas")]
        public IActionResult GetReservas()
        {
            return Ok(app.ConsultarReservas());
        }

        [HttpGet("Funciones")]
        public IActionResult GetFunciones()
        {
            return Ok(app.ConsultarFunciones());
        }

        [HttpGet("Clientes")]
        public IActionResult GetClientes()
        {
            return Ok(app.ConsultarClientes());
        }

        [HttpPost("NuevaReserva")]
        public IActionResult PostClientes(Reserva reserva)
        {
            try
            {
                if (reserva != null)
                {
                    return Ok(app.EjecutarInsertReserva(reserva));
                }

                return BadRequest("Datos de la reserva incorrectos!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPost("NuevoCliente")]
        public IActionResult PostClientes(Cliente cliente)
        {
            try
            {
                if (cliente != null)
                {
                    return Ok(app.EjecutarInsertClientes(cliente));
                }
                
                return BadRequest("Datos del cliente incorrectos!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

     
        [HttpDelete("DeleteCliente/{id}")]
        public IActionResult DeleteCliente(int id)
        {
            if (id != 0)
            {
                bool result = app.EliminarCliente(id);
                return Ok(result);

            }
            else
            {
                return BadRequest("Debe ingresar un cliente válido");
            }
        }
    }
}
