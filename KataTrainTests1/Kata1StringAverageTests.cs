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
        public void AverageStringTest()
        {
            //Arrange
            var ex = new Kata1StringAverage();
            var input = "one two three four five";

            //Act
            var result = ex.AverageString(input);

            //Assert
            var expected = "three";
            Assert.AreEqual(result,expected);

        }
    }
}