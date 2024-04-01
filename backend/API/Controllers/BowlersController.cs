using API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlersController : ControllerBase
    {
        private readonly IBowlersRepository _bowlingRepository;

        public BowlersController(IBowlersRepository repository)
        {
            _bowlingRepository = repository;
        }

        [HttpGet]
        public IEnumerable<Bowlers> Get()
        {
            var bowlingData = _bowlingRepository.Bowlers;
            return bowlingData;
        }
    }
}
