using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Application.Actividades;

namespace API.Controllers
{
    public class ActividadesController : BaseApiController
    {
        // private readonly DataContext _context;
   
        // public ActividadesController(DataContext context) 
        // {
        //     _context = context;                     
        // }

        // private readonly IMediator _mediator;
        // public ActividadesController(IMediator mediator)
        // {
        //     _mediator = mediator;            
        // }

        [HttpGet] //api/actividades
        public async Task<ActionResult<List<Actividad>>> GetActividades()
        {
            // return await _context.Actividades.ToListAsync();
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")] //api/actividades/{id}
        public async Task<ActionResult<Actividad>> GetActividad (Guid id)
        {
            // return await _context.Actividades.FindAsync(id);
            return await Mediator.Send(new Details.Query{Id = id});
        }

        [HttpPost] //api/actividades/{id}
        public async Task<IActionResult> CreateActividad (Actividad actividad)
        {
            return Ok (await Mediator.Send(new Create.Command{Actividad = actividad}));
        }

        [HttpPut("{id}")] //api/actividades/{id}
        public async Task<IActionResult> EditActividad (Guid id, Actividad actividad)
        {
            actividad.Id = id;

            return Ok (await Mediator.Send(new Edit.Command{Actividad = actividad}));
        }    

        [HttpDelete("{id}")] //api/actividades/{id}
        public async Task<IActionResult> DeleteActividad (Guid id)
        {       
            return Ok (await Mediator.Send(new Delete.Command{Id = id}));
        }              
    }
}