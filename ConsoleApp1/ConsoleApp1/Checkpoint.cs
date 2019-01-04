using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Checkpoint
    {

        public void Checkpoint1()
        {
            Console.Write("Write command: ");
            string input = Console.ReadLine();

            string[] commands = input.Split('-');

            foreach (var command in commands)
            {
                int size = 0;
                int.TryParse(command, out size);

                PrintTriangle(size);
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

        public void Checkpoint2()
        {
            //Checkpoint2
        }

    }
}
