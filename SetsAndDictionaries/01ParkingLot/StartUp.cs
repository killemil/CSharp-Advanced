
namespace _01ParkingLot
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            SortedSet<string> parkingLot = new SortedSet<string>();

            while (!input.Equals("END"))
            {
                string[] inputArgs = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                string command = inputArgs[0];
                string carNumber = inputArgs[1];

                if (command.Equals("IN"))
                {
                    parkingLot.Add(carNumber);
                }
                else
                {
                    parkingLot.Remove(carNumber);
                }

                input = Console.ReadLine();
            }

            if (parkingLot.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car.Trim());
                }
            }
        }
    }
}
