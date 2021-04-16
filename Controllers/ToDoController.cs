using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private ToDoRepository toDoRepository = new ToDoRepository();
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<ToDoDto> Get()
        {
            return toDoRepository.GetAll();
        }

        // POST api/<ValuesController>
        [HttpPost]
        public int Post([FromBody] ToDoDto todo)
        {
            return toDoRepository.Add(todo);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ToDoDto todo)
        {
            toDoRepository.Update(id, todo);
        }
    }
}
