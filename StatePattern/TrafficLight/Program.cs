using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace statePatternPractice
{
    // via interfaces
    public interface IStateSignal
    {
        void NextState();
        void PrintState();
        void PrevState();
    }
    public class TrafficLight
    {
        IStateSignal currentState;
        public TrafficLight(IStateSignal state)
        {
            currentState = state;
        }
        public void SetState(IStateSignal state)
        {
            currentState = state;
        }
        public void NextState()
        {
            currentState.NextState();
        }
        public void PrintState()
        {
            currentState.PrintState();
        }
        public void PrevState()
        {
            currentState.PrevState();
        }
    }
    public class RedState : IStateSignal
    {
        public TrafficLight tarfficLight;
        public RedState(TrafficLight trafficLight)
        {
            tarfficLight = trafficLight;
        }
        public void NextState()
        {
            tarfficLight.SetState(new GreenState(tarfficLight));
        }
        public void PrevState()
        {
            tarfficLight.SetState(new YellowState(tarfficLight));
        }
        public void PrintState()
        {
            Console.WriteLine("Red Light");
        }
    }
    public class GreenState : IStateSignal
    {
        public TrafficLight tarfficLight;
        public GreenState(TrafficLight trafficLight)
        {
            tarfficLight = trafficLight;
        }
        public void NextState()
        {
            tarfficLight.SetState(new YellowState(tarfficLight));
        }
        public void PrevState()
        {
            tarfficLight.SetState(new RedState(tarfficLight));
        }
        public void PrintState()
        {
            Console.WriteLine("Green Light");
        }
    }
    public class YellowState : IStateSignal
    {
        public TrafficLight tarfficLight;
        public YellowState(TrafficLight trafficLight)
        {
            tarfficLight = trafficLight;
        }
        public void NextState()
        {
            tarfficLight.SetState(new RedState(tarfficLight));
        }
        public void PrevState()
        {
            tarfficLight.SetState(new GreenState(tarfficLight));
        }
        public void PrintState()
        {
            Console.WriteLine("Yellow Light");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight(null);
            trafficLight.SetState(new RedState(trafficLight));

            // take input from user

            int choice;
            bool flag = false; // to avoid first iteration
            while (true)
            {
                if (flag)
                {
                    Console.WriteLine("Enter 0 for prev and 1 for next");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        trafficLight.NextState();

                    }
                    else if (choice == 0)
                    {
                        trafficLight.PrevState();
                    }

                }
                flag = true; // set flag to true after first iteration
                trafficLight.PrintState();
            }
        }
    }
}
