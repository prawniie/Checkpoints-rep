using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Repetition_CheckpointsTests
{

    [TestClass()]
    public class Checkpoint2Tests
    {
        Repetition_Checkpoints.Checkpoint2 c2 = new Repetition_Checkpoints.Checkpoint2();

        [DataRow("Kitchen 10m2 On",true)]
        [DataRow("Kitchen 9m2 Off | Bedroom 24m2 On", true)]
        [TestMethod()]
        public void should_return_true_when_input_is_in_valid_format(string input, bool expected)
        {
            var result = c2.ValidateInput(input);

            Assert.AreEqual(result,expected);
        }

        [DataRow("Kitchen xm2 On",false)]
        [DataRow("Kitchen 10m2 Onnn", false)]
        [TestMethod()]
        public void should_return_false_when_input_is_in_invalid_format(string input, bool expected)
        {
            var result = c2.ValidateInput(input);

            Assert.AreEqual(result, expected);
        }
    }
}
