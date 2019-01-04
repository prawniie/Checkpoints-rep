using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repetition_Checkpoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Checkpoints.Tests
{
    [TestClass()]
    public class Checkpoint3Tests
    {
        Checkpoint3 c3 = new Checkpoint3();

        [TestMethod()]
        public void Checkpoint_threeTest1()
        {
            var result = c3.ReorderList(new List<string> { "a", "b", "c", "d", "e" }, new List<int> { 1, 2, 3, 5, 4 });
            var expected = new List<string> {"a","b","c","e","d" };

            CollectionAssert.AreEqual(result,expected);
        }

        [TestMethod()]
        public void Checkpoint_threeTest2()
        {
            var result = c3.ReorderList(new List<string> { "a", "b", "c", "d" }, new List<int> { 3, 1, 4, 2 });
            var expected = new List<string> {"c","a","d","b" };

            CollectionAssert.AreEqual(result, expected);
        }

        [TestMethod()]
        public void Checkpoint_ThreeTest3()
        {
            var result = c3.ReorderList(new List<string> { "a", "b" }, new List<int> { 2, 2 });
            var expected = new List<string> {"b","b"};

            CollectionAssert.AreEqual(result, expected);
        }
    }
}