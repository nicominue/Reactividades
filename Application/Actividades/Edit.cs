using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Actividades
{
    public class Edit
    {
            public class Command : IRequest
            {
                public Actividad Actividad { get; set; }
            }
            public class Handler : IRequestHandler<Command>
            {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            public Handler(DataContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var actividad = await _context.Actividades.FindAsync(request.Actividad.Id);

                // actividad.Titulo = request.Actividad.Titulo ?? actividad.Titulo;
                _mapper.Map(request.Actividad, actividad);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}