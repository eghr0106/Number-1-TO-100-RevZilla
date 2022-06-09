using ConsoleAppNumber1To100;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        private ModalNumbers _modalNumbers { get; set; }
        [SetUp]
        public void Setup()
        {
            _modalNumbers = new ModalNumbers();
        }

        [Test]
        public void NumbersListShouldNotbeNull()
        {
            var resultPrints = _modalNumbers.PrintModalNumbers();

            Assert.IsNotNull(resultPrints);           
        }


        [Test]
        public void NumbersListShouldPrintFizzIfItsDivisibleBy3()
        {
            var resultPrints = _modalNumbers.PrintModalNumbers();
            var resultPrintsAsArray = resultPrints.ToArray();

            for (int i = 0; i < resultPrintsAsArray.Length; i++)
            {
                if ((i + 1) % 3 == 0 && (i + 1) % 5 > 0) 
                {
                    Assert.AreEqual("FIZZ", resultPrintsAsArray[i]);
                }
            }           
        }

        [Test]
        public void NumbersListShouldPrintBuzzIfItsDivisibleBy5()
        {
            var resultPrints = _modalNumbers.PrintModalNumbers();
            var resultPrintsAsArray = resultPrints.ToArray();

            for (int i = 0; i < resultPrintsAsArray.Length; i++)
            {
                if ((i + 1) % 5 == 0 && (i + 1) % 3 > 0)
                {
                    Assert.AreEqual("BUZZ", resultPrintsAsArray[i]);
                }
            }
        }

        [Test]
        public void NumbersListShouldPrintFizzBuzzIfItsDivisibleBy3And5()
        {
            var resultPrints = _modalNumbers.PrintModalNumbers();
            var resultPrintsAsArray = resultPrints.ToArray();

            for (int i = 0; i < resultPrintsAsArray.Length; i++)
            {
                if ((i + 1) % 5 == 0 && (i + 1) % 3 == 0)
                {
                    Assert.AreEqual("FIZZ & BUZZ", resultPrintsAsArray[i]);
                }
            }
        }
    }
}