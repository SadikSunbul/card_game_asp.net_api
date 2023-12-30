using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Via.Application.Features.Cards._MonsterCards.Comments.Create;
using Via.Application.Features.Cards._MonsterCards.Comments.Delete;
using Via.Application.Features.Cards._MonsterCards.Comments.Update;
using Via.Application.Features.Cards._MonsterCards.Queries.GetById;
using Via.Application.Features.Cards._MonsterCards.Queries.GetList;
using Via.Application.Features.Cards._MonsterCards.Queries.GetName;
using Via.Application.Features.Cards._PotionCards.Comments.Create;
using Via.Application.Features.Cards._PotionCards.Comments.Delete;
using Via.Application.Features.Cards._PotionCards.Comments.Update;
using Via.Application.Features.Cards._PotionCards.Queries.GetById;
using Via.Application.Features.Cards._PotionCards.Queries.GetByName;
using Via.Application.Features.Cards._PotionCards.Queries.GetList;

namespace Via.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PotionCardController : ControllerBase
    {
        private readonly IMediator mediator;

        public PotionCardController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CardCreate([FromBody] PotionCreateCommendRequest _request)
        {
            PotionCreateCommendRespons _respons = await mediator.Send(_request);
            return Ok(_respons);
        }

        [HttpDelete]
        public async Task<IActionResult> CardDrop([FromBody] PotionDeletCommendRequest _request)
        {
            PotionDeletCommendRespons _respons = await mediator.Send(_request);
            return Ok(_respons);
        }

        [HttpPatch]
        public async Task<IActionResult> CardUpdate([FromBody] PotionUpdateCommendRequest request)
        {
            var respons = await mediator.Send(request);
            return Ok(respons);
        }

        [HttpPost("id")]
        public async Task<IActionResult> GetIdCard([FromBody] PotionGetByIdQueriesRequest request)
        {
            var respons = await mediator.Send(request);
            return Ok(respons);
        }

        [HttpPost("name")]
        public async Task<IActionResult> GetNameCard([FromBody] PotionGetByNameQueriesRequest request)
        {
            var respons = await mediator.Send(request);
            return Ok(respons);
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetListCard()
        {
            var respons = await mediator.Send(new PotionGetListQueriesRequest());
            return Ok(respons);
        }
    }
}