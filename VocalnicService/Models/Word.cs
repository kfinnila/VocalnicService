using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VocalnicService.Models
{
    public class Word
    {
        public int Id { get; set; }
        public int ExerciseId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
