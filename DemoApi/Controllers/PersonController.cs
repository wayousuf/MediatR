using DemoLibrary.Commands;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator mediator;

        public PersonController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public async Task<List<Person>> Get()
        {
            return await mediator.Send(new GetPersonListQuery());
        }

        // GET api/<PersonController>      /5
        [HttpGet("{id}")]
        public async Task<Person> Get(int id)
        {
            return await mediator.Send(new GetPersonByIdQuery(id));
        }

        // POST api/<PersonController>
        [HttpPost]
        public async Task<Person> Post([FromBody] Person person)
        {
            var model = new InsertPersonCommand(person.FirstName, person.LastName);
            return await mediator.Send(model);
        }
    }
}
