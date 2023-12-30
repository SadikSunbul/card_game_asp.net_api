using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Via.Application.Features.Cards._MonetCards.Comments.Create;
using Via.Application.Features.Cards._MonetCards.Comments.Delete;
using Via.Application.Features.Cards._MonetCards.Comments.Update;
using Via.Application.Features.Cards._MonetCards.Queries.GetById;
using Via.Application.Features.Cards._MonetCards.Queries.GetList;
using Via.Application.Features.Cards._MonetCards.Queries.GetName;
using Via.Application.Features.Cards._MonsterCards.Comments.Create;
using Via.Application.Features.Cards._MonsterCards.Comments.Delete;
using Via.Application.Features.Cards._MonsterCards.Comments.Update;
using Via.Application.Features.Cards._MonsterCards.Queries.GetById;
using Via.Application.Features.Cards._MonsterCards.Queries.GetList;
using Via.Application.Features.Cards._MonsterCards.Queries.GetName;

namespace Via.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterCardController : ControllerBase
    {
        private readonly IMediator mediator;

        public MonsterCardController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CardCreate([FromBody] MonsterCreateCommendRequest _request)
        {
            MonsterCreateCommendRespons _respons = await mediator.Send(_request);
            return Ok(_respons);
        }

        [HttpDelete]
        public async Task<IActionResult> CardDrop([FromBody] MonsterDeleteCommendRequest _request)
        {
            MonsterDeleteCommendRespons _respons = await mediator.Send(_request);
            return Ok(_respons);
        }

        [HttpPatch]
        public async Task<IActionResult> CardUpdate([FromBody] MonsterUpdateCommendRequest request)
        {
            var respons = await mediator.Send(request);
            return Ok(respons);
        }

        [HttpPost("id")]
        public async Task<IActionResult> GetIdCard([FromBody] MonsterGetByIdQueriesRequest request)
        {
            var respons = await mediator.Send(request);
            return Ok(respons);
        }

        [HttpPost("name")]
        public async Task<IActionResult> GetNameCard([FromBody] MonsterGetByNameQueriesRequest request)
        {
            var respons = await mediator.Send(request);
            return Ok(respons);
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetListCard()
        {
            var respons = await mediator.Send(new MonsterGetlistQueriesRequest());
            return Ok(respons);
        }
    }
}