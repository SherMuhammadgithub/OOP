using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    internal class Exercises
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string TargetMuscleGroup { get; set; }
        public List <Sets> Sets { get; set; }
        public Exercises(string name, string description, string targetMuscleGroup, Sets set)
        {
            Name = name;
            Description = description;
            TargetMuscleGroup = targetMuscleGroup;
            Sets = new List<Sets>();
            Sets.Add(set);
        }
    }
}
