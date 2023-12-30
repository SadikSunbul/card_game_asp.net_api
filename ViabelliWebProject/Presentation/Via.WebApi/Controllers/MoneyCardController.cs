using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Via.Application.Features.Cards._EquipmentCards.Comments.Create;
using Via.Application.Features.Cards._EquipmentCards.Comments.Delete;
using Via.Application.Features.Cards._EquipmentCards.Comments.Update;
using Via.Application.Features.Cards._EquipmentCards.Queries.GetById;
using Via.Application.Features.Cards._EquipmentCards.Queries.GetList;
using Via.Application.Features.Cards._EquipmentCards.Queries.GetName;
using Via.Application.Features.Cards._MonetCards.Comments.Create;
using Via.Application.Features.Cards._MonetCards.Comments.Delete;
using Via.Application.Features.Cards._MonetCards.Comments.Update;
using Via.Application.Features.Cards._MonetCards.Queries.GetById;
using Via.Application.Features.Cards._MonetCards.Queries.GetList;
using Via.Application.Features.Cards._MonetCards.Queries.GetName;

namespace Via.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyCardController : ControllerBase
    {
        private readonly IMediator mediator;

        public MoneyCardController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CardCreate([FromBody] MoneyCreateCommendRequest _request)
        {
            MoneyCreateCommendRespons _respons=await mediator.Send(_request);
            return Ok(_respons);
        }

        [HttpDelete]
        public async Task<IActionResult> CardDrop([FromBody] MoneyDeleteCommendRequest _request)
        {
            MoneyDeleteCommendRespons _respons = await mediator.Send(_request);
            return Ok(_respons);
        }
        
        [HttpPatch]
        public async Task<IActionResult> CardUpdate([FromBody]  MoneyUpdateCommendRequest request)
        {
            var respons = await mediator.Send(request);
            return Ok(respons);
        }

        [HttpPost("id")]
        public async Task<IActionResult> GetIdCard([FromBody] MoneyGetByIdQueriesReques request)
        {
            var respons = await mediator.Send(request);
            return Ok(respons);
        }
        
        [HttpPost("name")]
        public async Task<IActionResult> GetNameCard([FromBody] MoneyGetByNameQueriesRequest  request)
        {
            var respons = await mediator.Send(request);
            return Ok(respons);
        }
        
        [HttpGet("list")]
        public async Task<IActionResult> GetListCard()
        {
            var respons = await mediator.Send(new MoneyGetlistQueriesRequest());
            return Ok(respons);
        }

    }
}
