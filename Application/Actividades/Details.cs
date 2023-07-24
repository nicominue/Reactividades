using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;
using SQLitePCL;

namespace Application.Actividades
{
    public class Details
    {
        public class Query : IRequest<Actividad>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Actividad>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Actividad> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Actividades.FindAsync(request.Id);
            }
        }
    }
}