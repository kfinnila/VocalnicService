using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VocalnicService.Models;

namespace VocalnicService.Data
{
    public class DataMock
    {
        private List<Exercise> exercises = new List<Exercise>();
        private List<Word> questions = new List<Word>();

        public DataMock()
        {
            exercises.Add(new Exercise() { Id = 4, Name = "Mate - Números", Description = "Tipos de números" });
            exercises.Add(new Exercise() { Id = 5, Name = "Mate - Trigonometría", Description = "Trigonometría" });
            exercises.Add(new Exercise() { Id = 6, Name = "Mate - Cálculo diferencial", Description = "Cálculo difrencial" });
            exercises.Add(new Exercise() { Id = 7, Name = "Mate - General", Description = "" });
            exercises.Add(new Exercise() { Id = 8, Name = "Viaje - General", Description = "" });
            exercises.Add(new Exercise() { Id = 9, Name = "Viaje - Medios", Description = "" });
            exercises.Add(new Exercise() { Id = 10, Name = "Viaje - Verbos", Description = "" });
            exercises.Add(new Exercise() { Id = 11, Name = "Fútbol", Description = "" });
            exercises.Add(new Exercise() { Id = 21, Name = "Física 1", Description = "" });
            LoadQuestions();
        }


        public List<Exercise> GetExercises()
        {
            return exercises;
        }

        public Exercise GetExerciseById(int id)
        {
            return exercises.Where(a => a.Id == id).FirstOrDefault();
        }


        public List<Word> GetWordsByExerciseId(int id)
        {
            return questions.Where(a => a.ExerciseId == id).ToList();
        }

        public void LoadQuestions()
        {
            using (StreamReader r = File.OpenText("Data\\QuestionData.json"))
            {
                string json = r.ReadToEnd();
                questions = JsonConvert.DeserializeObject<List<Word>>(json);
            }
        }

    }
}
