using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Domain;
using Persistence;
using SQLitePCL;

namespace Application.Actividades
{
    public class Create
    {
        public class Command : IRequest
        {
            public Actividad Actividad { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
            _context = context;                
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Actividades.Add(request.Actividad);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}