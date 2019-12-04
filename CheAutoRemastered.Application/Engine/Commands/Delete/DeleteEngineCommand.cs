using CheAutoRemastered.Application.Interfaces;
using CheAutoRemastered.Core.Domain.Models.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CheAutoRemastered.Application.Engine.Commands.Delete
{
    public class DeleteEngineCommand : IRequest
    {
        public Guid Id { get; set; }

        public class DeleteEngineCommandHandler : IRequestHandler<DeleteEngineCommand>
        {
            private readonly ICheAutoDbContext _context;

            public DeleteEngineCommandHandler(ICheAutoDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(DeleteEngineCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.Engines.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Engine), request.Id);
                }

                _context.Engines.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
