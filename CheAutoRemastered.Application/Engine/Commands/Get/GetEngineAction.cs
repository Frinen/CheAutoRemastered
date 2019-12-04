using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheAutoRemastered.Application.Engine.Commands.Get
{
    class GetEngineAction : IRequest<List<Domain.Models.Engine>>
    { }
    public class GetTodosQueryHandler : IRequestHandler<GetEngineAction, List<Domain.Models.Engine>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetTodosQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<TodosVm> Handle(GetTodosQuery request, CancellationToken cancellationToken)
        {
            var vm = new TodosVm();

            vm.Lists = await _context.TodoLists
                .ProjectTo<TodoListDto>(_mapper.ConfigurationProvider)
                .OrderBy(t => t.Title)
                .ToListAsync(cancellationToken);

            return vm;
        }
    }
    
}
