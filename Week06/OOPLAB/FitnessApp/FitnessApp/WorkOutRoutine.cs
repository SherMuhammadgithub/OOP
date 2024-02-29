using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    internal class WorkOutRoutine
    {
        public string Name { get; set; }
        private List<Exercises> Exercises;
        public WorkOutRoutine(string name)
        {
            Name = name;
            Exercises = new List<Exercises>();
        }
        public void AddExercise(Exercises exercise)
        {
            Exercises.Add(exercise);
        }

    }
}
