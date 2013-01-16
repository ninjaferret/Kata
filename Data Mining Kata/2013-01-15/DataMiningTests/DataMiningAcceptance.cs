using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataMiningCore;
using NUnit.Framework;


namespace DataMiningTests
{
    [TestFixture]
    public class DataMiningAcceptance
    {
        [Test]
        public void That_Returns_10()
        {
            Assert.That(FootballMining.GetWeatherWithLowestVariance(WeatherInput), Is.EqualTo("10"));
        }

        [Test]
        public void ThatWeSplitStringsAppropriately()
        {
         Class1 class1 = new Class1();
            var enumerableString = class1.split(WeatherInput);
            Assert.That(enumerableString.Length, Is.EqualTo(12));
        }

        [Test]
        public void EachLineHasFiveElements()
        {
            var class1 = new Class1();
            var enumerableString = class1.split(WeatherInput);
            Assert.IsTrue(enumerableString.All(line => line.Length == 6));
        }

        [Test]
        public void CanProductAListOfMonthAndDifferenceBetweenTwoValues()
        {
            var class1 = new Class1();
            var input = new[] {"1", "40", "30"};
            Assert.That(class1.ExtractVariance(input, 1, 2), Is.EqualTo(new Tuple<string, decimal>("1", 10M)));
        }

        private const string WeatherInput = @"    1    9.8     3.4       7    34.4    68.5
    2    8.0     1.3      12    16.8    84.9
    3   14.7     4.7       0    16.2   180.3
    4   13.3     4.9       1    98.4   141.7
    5   18.2     9.7       0    25.4   166.6
    6   19.4    11.6       0   110.8   118.5
    7   21.3    13.2       0    71.8   161.6
    8   23.5    14.3       0    36.4   182.6  
    9   20.0    10.3       0    41.2   178.9  
   10   14.2     8.0       0    88.4    85.6  
   11   11.0     4.6       1    71.8    75.4  
   12    9.0     2.6      10    95.8    58.0  
";
    }
}
