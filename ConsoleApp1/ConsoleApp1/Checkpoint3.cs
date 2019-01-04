using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Repetition_Checkpoints
{
    public class Checkpoint3
    {

        public void Checkpoint_three()
        {
            //List<int> numbers = new List<int>{ 2, 8, 3, 11 };
            //PrintNumbers(numbers);

            //List<int> numbersModified = MultiplyBy100AndAdd3(numbers);
            //PrintNumbersModified(numbersModified);

            List<string> reorderedList = ReorderList(new List<string> { "a","b","c","d","e"}, new List<int> { 1,2,3,5,4});
        }

        public List<string> ReorderList(List<string> list, List<int> numbers)
        {
            List<string> reorderedList = new List<string>();

            int counter = 0;

            foreach (var item in list)
            {
                string newElement = list[numbers[counter]-1];
                reorderedList.Add(newElement);
                counter++;
            }
            return reorderedList;
        }

        public void PrintNumbers(List<int> numbers)
        {
            Console.WriteLine("LISTAN");
            Console.WriteLine(string.Join(",", numbers));
        }

        public List<int> MultiplyBy100AndAdd3(List<int> numbers)
        {
            List<int> numbersModified = numbers.Select(number => number * 100 + 3).ToList();

            return numbersModified;
        }

        public void PrintNumbersModified(List<int> numbersModified)
        {
            Console.WriteLine();
            Console.WriteLine("MULTIPLICERA MED 100 OCH LÄGG TILL TRE");
            Console.WriteLine(string.Join(",", numbersModified));
            Console.WriteLine();
        }
    }
}