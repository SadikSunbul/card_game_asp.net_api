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

namespace Via.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentCardController : ControllerBase
    {
        private readonly IMediator mediator;

        public EquipmentCardController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CardCreate([FromBody] EquipmentCreateCommendRequest _request)
        {
            EquipmentCreateCommendRespons _respons=await mediator.Send(_request);
            return Ok(_respons);
        }

        [HttpDelete]
        public async Task<IActionResult> CardDrop([FromBody] EquipmentDeleteCommendRequest _request)
        {
            EquipmentDeleteCommendRespons _respons = await mediator.Send(_request);
            return Ok(_respons);
        }
        
        [HttpPatch]
        public async Task<IActionResult> CardUpdate([FromBody]  EquipmentUpdateCommendRequest request)
        {
            var respons = await mediator.Send(request);
            return Ok(respons);
        }

        [HttpPost("id")]
        public async Task<IActionResult> GetIdCard([FromBody] EquipmentGetByIdQueriesRequest request)
        {
            var respons = await mediator.Send(request);
            return Ok(respons);
        }
        
        [HttpPost("name")]
        public async Task<IActionResult> GetNameCard([FromBody] EquipmentGetByNameQueriesRequest request)
        {
            var respons = await mediator.Send(request);
            return Ok(respons);
        }
        
        [HttpGet("list")]
        public async Task<IActionResult> GetListCard()
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            Response.Headers.Add("Access-Control-Allow-Credentials", "true");
            var respons = await mediator.Send(new EquipmentGetlistQueriesRequest());
            return Ok(respons);
        }
        
        
    }
}