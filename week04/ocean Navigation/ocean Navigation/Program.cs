using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ocean_Navigation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShipManager shipManager = new ShipManager();
            while(true)
            {
                Console.Clear();
                int select = PrintMenu();
                if (select == 1)
                {
                    Console.Clear();
                        
                    Console.WriteLine("Enter Ship Number: ");
                    string ship_num = Console.ReadLine();
                    string latitude = TakeInput("latitude");
                    string longitude = TakeInput("Longitude");
                    Ship ship = new Ship(latitude, longitude, ship_num);
                    bool isAdded = shipManager.AddShip(ship);
                    if(isAdded)
                    {
                        Console.WriteLine("Ship Added");
                    }
                }
                else if(select == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Enter Ship number");
                    string ship_num = Console.ReadLine();
                    Ship ship = shipManager.FindShip(ship_num);
                    if(ship != null)
                    {
                        Console.WriteLine($"Ship is at {ship.longitude} and {ship.latitude}");
                    }
                    else
                    {
                        Console.WriteLine("ship not found");
                    }

                }
                else if(select == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Enter Ship's latitude");
                    string latitude = Console.ReadLine();
                    Console.WriteLine("Enter Ship's logitude");
                    string logitude = Console.ReadLine();
                    Ship ship = shipManager.FindByLocation(latitude, logitude);
                    if(ship != null)
                    {
                        Console.WriteLine($"Sips number is {ship.number}");
                    }
                    else
                    {
                        Console.WriteLine("ship not found");
                    }
              
                }
                else if(select == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the number to change the ship position: ");
                    string ship_num = Console.ReadLine();
                    Ship ship_to_update = shipManager.FindShip(ship_num);
                    if(ship_to_update != null)
                    {
                        Console.WriteLine("Enter Ship Number: ");
                        string number = Console.ReadLine();
                        string latitude = TakeInput("latitude");
                        string longitude = TakeInput("Longitude");
                        Ship updated_ship = new Ship(latitude, longitude,number);
                        ship_to_update.number = updated_ship.number;
                        Console.WriteLine(ship_to_update.number);
                        ship_to_update.longitude = updated_ship.longitude;
                        ship_to_update.latitude = updated_ship.latitude;
                        Console.WriteLine("Ship updated");
                    }
                    else
                    {
                        Console.WriteLine("Error updating ship.....");
                    }
                }
                else if(select == 5)
                {
                    break;
                }
                Console.ReadKey();
            }
        }
        static int PrintMenu()
        {
            Console.WriteLine("1.Add Ship");
            Console.WriteLine("2.View Ship");
            Console.WriteLine("3.View Ship Serial");
            Console.WriteLine("4.Change Ship Position");
            Console.WriteLine("5.Exit");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        static string  TakeInput(string argument )
        {
         
            Console.WriteLine($"Enter Ship's {argument}");
            Console.WriteLine($"Enter {argument} Degree: ");
            int degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Minute: ");
            float minute = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Direction");
            char direction = char.Parse(Console.ReadLine());
            Angle angle = new Angle( degree, minute, direction);
           string info = angle.ShipInfo(degree, minute, direction);
            return info;
        }
    }
}
