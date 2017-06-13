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
    [Route("api/Question")]
    public class QuestionController : Controller
    {
        // GET: api/Question
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Question/5
        [HttpGet("{id}", Name = "GetQuestions")]
        public IEnumerable<Word> Get(int id)
        {
            return new DataMock().GetWordsByExerciseId(id);
        }
        
    }
}
