using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Actividades
{
    public class List
    {
        public class Query : IRequest<List<Actividad>> {}

        public class Handler : IRequestHandler<Query, List<Actividad>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<List<Actividad>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Actividades.ToListAsync();
            }
        }
    }
}