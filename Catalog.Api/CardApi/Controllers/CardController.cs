using Cards.Api.Model;
using Cards.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Cards.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase
    {


        private readonly ILogger<CardController> _logger;
        private readonly ICardService _cardService;

        public CardController(ILogger<CardController> logger, ICardService cardService)
        {
            _logger = logger;
            _cardService = cardService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Card>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Card>>> Get()
        {
            var result = await _cardService.GetAllCard();
            return Ok(result);
        }


        [HttpGet("card/{id}", Name = "GetCard")]
        [ProducesResponseType(typeof(Card), 200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]

        public async Task<ActionResult<Card>> GetCard(int id)
        {
            if (id <= 0)
                return BadRequest("Requesteted id card is not valid.");

            var result = await _cardService.GetCard(id);
            if (result == null)
                return NotFound($"Card with {id} not found.");

            return Ok(result);
        }


        [HttpGet("createCard", Name = "createCard")]
        [ProducesResponseType(typeof(Card), 200)]

        public async Task<ActionResult<Card>> CreateCard([FromBody] Card card)
        {
            var result = await _cardService.CreateCard(card);
            return Ok(result);
        }
    }
}
