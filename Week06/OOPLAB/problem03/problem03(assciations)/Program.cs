using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem03_assciations_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            WorkOutRoutine wr = new WorkOutRoutine("Chest Day");
            wr.AddExercise("Bench Press");
            wr.AddExercise("Incline Bench Press");
            wr.AddExercise("Decline Bench Press");
            wr.AddExercise("Chest Fly");
            wr.AddExercise("Push Ups");
            wr.AddExercise("Dips");
           
        }
    }
}
