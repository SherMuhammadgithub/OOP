using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem03_assciations_
{
    internal class WorkOutRoutine
    {
        private string Name { get; set; }
        private List<Exercise> Exercises;
        public WorkOutRoutine(string name)
        {
            Name = name;
            Exercises = new List<Exercise>();
        }
        public void AddExercise(string name)
        {
            Exercises.Add(new Exercise(name));
        }

        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
    }
}
