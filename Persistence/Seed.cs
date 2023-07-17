using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Actividades.Any()) return;
            
            var actividades = new List<Actividad>
            {
                new Actividad
                {
                    Titulo = "Past Activity 1",
                    Fecha = DateTime.UtcNow.AddMonths(-2),
                    Descripcion = "Activity 2 months ago",
                    Categoria = "drinks",
                    Ciudad = "London",
                    Evento = "Pub",
                },
                new Actividad
                {
                    Titulo = "Past Activity 2",
                    Fecha = DateTime.UtcNow.AddMonths(-1),
                    Descripcion = "Activity 1 month ago",
                    Categoria = "culture",
                    Ciudad = "Paris",
                    Evento = "Louvre",
                },
                new Actividad
                {
                    Titulo = "Future Activity 1",
                    Fecha = DateTime.UtcNow.AddMonths(1),
                    Descripcion = "Activity 1 month in future",
                    Categoria = "culture",
                    Ciudad = "London",
                    Evento = "Natural History Museum",
                },
                new Actividad
                {
                    Titulo = "Future Activity 2",
                    Fecha = DateTime.UtcNow.AddMonths(2),
                    Descripcion = "Activity 2 months in future",
                    Categoria = "music",
                    Ciudad = "London",
                    Evento = "O2 Arena",
                },
                new Actividad
                {
                    Titulo = "Future Activity 3",
                    Fecha = DateTime.UtcNow.AddMonths(3),
                    Descripcion = "Activity 3 months in future",
                    Categoria = "drinks",
                    Ciudad = "London",
                    Evento = "Another pub",
                },
                new Actividad
                {
                    Titulo = "Future Activity 4",
                    Fecha = DateTime.UtcNow.AddMonths(4),
                    Descripcion = "Activity 4 months in future",
                    Categoria = "drinks",
                    Ciudad = "London",
                    Evento = "Yet another pub",
                },
                new Actividad
                {
                    Titulo = "Future Activity 5",
                    Fecha = DateTime.UtcNow.AddMonths(5),
                    Descripcion = "Activity 5 months in future",
                    Categoria = "drinks",
                    Ciudad = "London",
                    Evento = "Just another pub",
                },
                new Actividad
                {
                    Titulo = "Future Activity 6",
                    Fecha = DateTime.UtcNow.AddMonths(6),
                    Descripcion = "Activity 6 months in future",
                    Categoria = "music",
                    Ciudad = "London",
                    Evento = "Roundhouse Camden",
                },
                new Actividad
                {
                    Titulo = "Future Activity 7",
                    Fecha = DateTime.UtcNow.AddMonths(7),
                    Descripcion = "Activity 2 months ago",
                    Categoria = "travel",
                    Ciudad = "London",
                    Evento = "Somewhere on the Thames",
                },
                new Actividad
                {
                    Titulo = "Future Activity 8",
                    Fecha = DateTime.UtcNow.AddMonths(8),
                    Descripcion = "Activity 8 months in future",
                    Categoria = "film",
                    Ciudad = "London",
                    Evento = "Cinema",
                }
            };

            await context.Actividades.AddRangeAsync(actividades);
            await context.SaveChangesAsync();
        }
    }
}