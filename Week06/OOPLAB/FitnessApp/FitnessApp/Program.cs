using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sets set1 = new Sets(10, 100, 60);
            Exercises exercise1 = new Exercises("Bench Press", "Lay on a bench and press the bar up", "Chest", set1);
            WorkOutRoutine routine1 = new WorkOutRoutine("Chest Day");
            routine1.AddExercise(exercise1);
            Console.WriteLine(routine1.Name);
        }
    }
}
