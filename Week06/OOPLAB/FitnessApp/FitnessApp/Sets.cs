using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    internal class Sets
    {
        public int Reps { get; set; }
        public int Weight { get; set; }
        public int RestTime { get; set; }
        public Sets(int reps, int weight, int restTime)
        {
            Reps = reps;
            Weight = weight;
            RestTime = restTime;
        }
    }
}
