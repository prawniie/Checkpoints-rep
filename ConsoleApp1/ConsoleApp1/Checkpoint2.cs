using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Repetition_Checkpoints
{
    public class Checkpoint2
    {
        public void Checkpoint_two()
        {
            while (true)
            {
                string input = AskUserForRooms();

                if (input.ToLower() == "exit")
                    break;

                bool isValid = ValidateInput(input);

                if (isValid == false)
                {
                    continue;
                }

                List<Room> listOfRooms = CreateListOfRooms(input);
                //PrintRooms(listOfRooms);
                PrintLitUpRooms(listOfRooms);
                PrintLargestRoom(listOfRooms);
                PrintNumberOfRooms(listOfRooms);
            }
        }


        public string AskUserForRooms()
        {
            Console.WriteLine("\n--------------------------------------------------------------------\n");
            Console.WriteLine("Enter room name (write 'exit' to quit): ");
            string input = Console.ReadLine();
            return input;
        }

        public bool ValidateInput(string input)
        {
            string inputFormat = @"^\s?[a-zA-Z]+ [1-9]\d?m2 (On|Off)\s?$";

            string[] roomArray = input.Split('|');

            foreach (var room in roomArray)
            {
                Match match = Regex.Match(room, inputFormat, RegexOptions.IgnoreCase);

                if (!match.Success)
                {
                    WriteRed("Invalid input data");
                    return false;
                }
            }
            return true;
        }

        public List<Room> CreateListOfRooms(string input)
        {
            List<Room> listOfRooms = new List<Room>();

            string[] roomArray = input.Trim().Split('|');

            foreach (var room in roomArray)
            {
                string trimmedRoom = room.Trim();
                string[] eachRoom = trimmedRoom.Split(' ');

                Room r = new Room();
                r.Name = eachRoom[0];
                r.Size = int.Parse(eachRoom[1].Replace("m2",""));
                r.LightsOnOrOff = eachRoom[2];
                listOfRooms.Add(r);
            }

            return listOfRooms;
        }

        public void PrintRooms(List<Room> listOfRooms)
        {
            int counter = 1;

            Console.WriteLine();
            foreach (var room in listOfRooms)
            {
                WriteGreen($"* Roomname {counter}: {room.Name}");
                counter++;
            }
        }

        public void PrintLitUpRooms(List<Room> listOfRooms)
        {
            Console.WriteLine();

            var litUpRooms = listOfRooms.Where(room => room.LightsOnOrOff == "On").ToList();

            if (litUpRooms.Count() > 0)
            {
                WriteGreen($"The lights are on in {string.Join(" and ", litUpRooms.Select(room => room.Name))}".ToString());
            }
        }

        public void PrintLargestRoom(List<Room> listOfRooms)
        {
            var largestRoom = listOfRooms.OrderByDescending(room => room.Size).First();

            WriteGreen($"The largest room is {largestRoom.Name} with {largestRoom.Size} m2");

        }

        public void PrintNumberOfRooms(List<Room> listOfRooms)
        {
            var numberOfRooms = listOfRooms.Count();
            WriteGreen($"The apartment has {numberOfRooms} rooms");
            Console.WriteLine();

        }

        private void WriteGreen(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        private void WriteRed(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }


    }
}
