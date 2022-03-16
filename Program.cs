using System;
using Itenso.TimePeriod;

namespace planner
{
    class Program
    {
        static void Main(string[] args)
        {
            #region initialize the program
            
            //create a new schedule
            Schedule sched = new Schedule();

            //welcome the user
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine();
            System.Console.WriteLine("-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~");
            System.Console.WriteLine("                         TRIP PLANNER                       ");
            System.Console.WriteLine("-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~");
            System.Console.WriteLine();
            #endregion
/*
            #region show menu
            //menu loop
            
            bool menuLoop = true;
            while(menuLoop == true) {
                System.Console.WriteLine();
                System.Console.WriteLine("Please choose one of the following options: ");
                System.Console.WriteLine();
                System.Console.WriteLine("1. View list of all planned trips");
                System.Console.WriteLine("2. View/Modify a specific planned trip");
                System.Console.WriteLine("3. Plan a new trip");

            }

            #endregion
            */
            //outbound flight
            Flight flightout = new Flight();
            flightout.depTime = new DateTime(2021, 7, 11, 10, 30, 0);
            flightout.arrTime = new DateTime(2021, 7, 11, 14, 0, 0);

            //inbound flight
            Flight flightin = new Flight();
            flightin.depTime = new DateTime(2022, 1, 31, 21, 0, 0);
            flightin.arrTime = new DateTime(2022, 2, 1, 8, 0, 0);

            
            sched.add(flightout);
            sched.add(flightin);
            
            foreach(ITimePeriod timePeriod in sched.timeline) {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("Item: " + timePeriod);
            }

            
        }
    }
}
