using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, Person>
    {
        private readonly IDataAccess dataAccess;

        public InsertPersonHandler(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }
        public Task<Person> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(this.dataAccess.InsetPerson(request.FirstName, request.LastName));
        }
    }
}
