using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VocalnicService.Models;
using VocalnicService.Data;

namespace VocalnicService.Controllers
{
    [Produces("application/json")]
    [Route("api/Exercise")]
    public class ExerciseController : Controller
    {
        // GET: api/Exercise
        [HttpGet]
        public IEnumerable<Exercise> Get()
        {
            return new DataMock().GetExercises();
        }

        // GET: api/Exercise/5
        [HttpGet("{id}", Name = "GetExercise")]
        public Exercise Get(int id)
        {
            return new DataMock().GetExerciseById(id);
        }


        /*        
        // POST: api/Exercise
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Exercise/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
         */
    }

}
