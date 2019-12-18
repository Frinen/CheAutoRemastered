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
                try
                {
                    var entity = await _context.Engines.FindAsync(request.Id.ToString());

                    if (entity == null)
                    {
                        throw new NotFoundException(nameof(Engine), request.Id);
                    }

                    _context.Engines.Remove(entity);

                    var res = _context.SaveChangesAsync(cancellationToken).Result;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                

                return Unit.Value;
            }
        }
    }
}
