using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, Person>
    {
        private readonly IMediator mediator;

        public GetPersonByIdHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<Person> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            var persons = await mediator.Send(new GetPersonListQuery());

            var output = persons?.FirstOrDefault(p => p.Id == request.Id);

            return output;
        }
    }
}
