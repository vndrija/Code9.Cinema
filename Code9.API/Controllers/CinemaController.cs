using Code9.Domain.Commands;
using Code9.Domain.Models;
using Code9.Domain.Queries;
using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace Code9.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CinemaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CinemaController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<ActionResult<List<Cinema>>> GetAllCinemas()
        {
            var query = new GetAllCinemaQuery();
            var result = await _mediator.Send(query);
            return Ok(result);

        }

        [HttpPost]
        
        public async Task<ActionResult<Cinema>> AddCinema(AddCinemaRequest addCinemaRequest)
        {
            var addCinemaCommand = new AddCinemaCommand
            {
                Name = addCinemaRequest.Name,
                City = addCinemaRequest.City,
                Street = addCinemaRequest.Street,
                NumberOfAuditioriums = addCinemaRequest.NumberOfAuditioriums
            };

            var result = await _mediator.Send(addCinemaCommand);
            return result;

        }

    }


}
