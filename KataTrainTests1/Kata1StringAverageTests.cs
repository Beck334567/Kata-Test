using NUnit.Framework;
using KataTrain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTrain.Tests
{
    [TestFixture()]
    public class Kata1StringAverageTests
    {
        [Test()]
        [TestCase("one two three four five","three")]
        [TestCase("zero nine five two", "four")]
        [TestCase("", "n/a")]
        [TestCase(null, "n/a")]
        [TestCase("five four", "four")]
        public void AverageStringTest(string input,string output)
        {
            //Arrange
            var ex = new Kata1StringAverage();
            
            //Act
            var result = ex.AverageString(input);
          
            //Assert
            Assert.AreEqual(result, output);
       

        }
    }
}