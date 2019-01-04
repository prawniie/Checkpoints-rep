using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Checkpoints
{
    public class Checkpoint1
    {

        public void Checkpoint_one()
        {

            while (true)
            {
                Console.Write("Write command: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                string[] commands = input.Split('-');
                int size = 0;

                foreach (var command in commands)
                {
                    if (command.Contains('A'))
                    {
                        string sizeString = command.Remove(0,1);
                        int.TryParse(sizeString, out size);
                        PrintTriangle(size);
                    }
                    else if (command.Contains('B'))
                    {
                        string sizeString = command.Remove(0, 1);
                        int.TryParse(sizeString, out size);
                        PrintTriangleUpSideDown(size);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, I didn't understand. Try again!");
                        continue;
                    }
                }
            }
        }

        private void PrintTriangleUpSideDown(int size)
        {
            for (int i = 0; size > i ; size--)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private void PrintTriangle(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
        }
    }
}
