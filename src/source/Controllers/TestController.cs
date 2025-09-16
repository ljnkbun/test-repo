using Application.Models.Params.Tests;
using Application.Queries.Tests;
using Microsoft.AspNetCore.Mvc;

namespace source.Controllers
{
    public class TestController : BaseApiController
    {
        // GET: api/<controller>
        [HttpGet]
        [Route("get-all")]
        public async Task<IActionResult> GetAll([FromQuery] TestParams filter)
        {
            return Ok(await Mediator.Send(new GetTestsQuery()
            {
                SkipCount = filter.SkipCount,
                MaxResultCount = filter.MaxResultCount,
                IsActiveFilter = filter.IsActiveFilter,
                LevelFilter = filter.LevelFilter,
            }));
        }

        //// GET api/<controller>/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get(int id)
        //{
        //    return Ok(await Mediator.Send(new GetTestQuery { Id = id }));
        //}

        //// POST api/<controller>
        //[HttpPost]
        //public async Task<IActionResult> Post(CreateTestCommand command)
        //{
        //    return Ok(await Mediator.Send(command));
        //}

        //// PUT api/<controller>/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(int id, UpdateTestCommand command)
        //{
        //    if (id != command.Id) return BadRequest();
        //    return Ok(await Mediator.Send(command));
        //}

        //// DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    return Ok(await Mediator.Send(new DeleteTestCommand { Id = id }));
        //}
    }
}
