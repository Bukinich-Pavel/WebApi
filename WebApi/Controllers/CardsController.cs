using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : Controller
    {
        // GET api/cards
        [HttpGet]
        public IEnumerable<Card> Get()
        {
            return Repository.GetCards();
        }


        // POST api/cards
        [HttpPost]
        public void Post([FromBody] Card value)
        {
            Repository.AddCard(value);
        }


        // PUT api/cards/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Card value)
        {
            Repository.PutCard(id, value);
        }


        // DELETE api/cards/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Repository.DeleteCard(id);
        }


    }
}
