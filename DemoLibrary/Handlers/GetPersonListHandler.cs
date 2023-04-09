using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;

namespace DemoLibrary.Handlers
{
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<Person>>
    {
        private readonly IDataAccess dataAccess;

        public GetPersonListHandler(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }
        public Task<List<Person>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(dataAccess.GetPersons());
        }
    }
}
