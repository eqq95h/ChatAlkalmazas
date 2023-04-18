using ChatAlkalmazas.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChatAlkalmazas.Server
{
    [Route("api/[Messenger]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private List<Message> MessagesDb = new List<Message>(); 
        // GET: api/<MessagesController>
        [HttpGet]
        [ActionName ("Receive")]
        public IEnumerable<Message> Get()
        {
            if (MessagesDb.Count != 0)
                return MessagesDb;
            else
                return null;
        }

        // GET api/<MessagesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MessagesController>
        [HttpPost]
        [ActionName ("Send")]
        public void Post([FromBody] Message value)
        {
            MessagesDb.Add(value);
        }

        // PUT api/<MessagesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MessagesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
