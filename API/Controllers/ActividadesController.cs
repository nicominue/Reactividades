using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ActividadesController : BaseApiController
    {
        private readonly DataContext _context;
   
        public ActividadesController(DataContext context) 
        {
            _context = context;
                      
        }

        [HttpGet] //api/actividades
        public async Task<ActionResult<List<Actividad>>> GetActividades()
        {
            return await _context.Actividades.ToListAsync();
        }

        [HttpGet("{id}")] //api/actividades/{id}
        public async Task<ActionResult<Actividad>> GetActividad (Guid id)
        {
            return await _context.Actividades.FindAsync(id);
        }
                    
    }
}