using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace todos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        // GET api/todos
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "todo1", "todo2" };
        }

        // GET api/todos/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "todo";
        }

        // POST api/todos
        [HttpPost]
        public void Post([FromBody] string todo)
        {
        }

        // PUT api/todos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string todo)
        {
        }

        // DELETE api/todos/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
