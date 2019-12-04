using AutoMapper;
using AutoMapper.QueryableExtensions;
using CheAutoRemastered.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CheAutoRemastered.Application.Engine.Commands.Get
{
    public class GetEngineAction : IRequest<List<Domain.Models.Engine>>
    { }
    public class GetEngineActionHandler : IRequestHandler<GetEngineAction, List<Domain.Models.Engine>>
    {
        private readonly ICheAutoDbContext _context;
        private readonly IMapper _mapper;

        public GetEngineActionHandler(ICheAutoDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Domain.Models.Engine>> Handle(GetEngineAction request, CancellationToken cancellationToken)
        {
            var engineList = new List<Domain.Models.Engine>();

            engineList =  _context.Engines
                .OrderBy(t => t.Name)
                .ToList();

            return engineList;
        }
    }
    
}
