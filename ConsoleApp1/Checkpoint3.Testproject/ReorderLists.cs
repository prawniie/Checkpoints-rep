using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint3.Testproject
{
    public class ReorderLists
    {
        public List<string> ReorderList(List<string> list, List<int> numbers)
        {
            List<string> reorderedList = new List<string>();

            int counter = 0;

            foreach (var item in list)
            {
                string newElement = list[numbers[counter] - 1];
                reorderedList.Add(newElement);
                counter++;
            }
            return reorderedList;
        }
    }
}
