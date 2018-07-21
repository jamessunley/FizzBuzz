using System;
using FizzBuzz;
using FizzBuzz.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Test
{
    [TestClass]
    public class FizzBuzzFlowTests
    {
        [TestMethod]
        public void Given_input_is_one_fizzbuzzCalculator_called_once()
        {
            //Given I have the number 1
            int input = 1;
            //And I have a character seperqtor as ,
            char seperator = ',' ;
            //And I have a fizzbuzzconverter object
            Mock<IFizzBuzzCalculator> mock = new Mock<IFizzBuzzCalculator> ();
            //When I call fizzbuzzflow.calculatefizzbuzz
            IFizzBuzzFlow fizzBuzzFlow = new FizzBuzzFlow(mock.Object);
            fizzBuzzFlow.CalculateFizzBuzz(input, seperator);
            //Then I will verify that fizzbuzzconverter object is called once
            mock.Verify(m => m.Calculate(It.IsAny<int>()), Times.Once);

        }

        [TestMethod]
        public void Given_input_is_two_fizzbuzzCalculator_called_twice()
        {
            //Given I have the number 2
            int input = 2;
            //And I have a character seperqtor as ,
            char seperator = ',';
            //And I have a fizzbuzzconverter object
            Mock<IFizzBuzzCalculator> mock = new Mock<IFizzBuzzCalculator>();
            //When I call fizzbuzzflow.calculatefizzbuzz
            IFizzBuzzFlow fizzBuzzFlow = new FizzBuzzFlow(mock.Object);
            fizzBuzzFlow.CalculateFizzBuzz(input, seperator);
            //Then I will verify that fizzbuzzconverter object is called twice
            mock.Verify(m => m.Calculate(It.IsAny<int>()), Times.Exactly(2));

        }

        [TestMethod]
        public void Given_input_is_one_hundred_fizzbuzzCalculator_called_100_times()
        {
            //Given I have the number 100
            int input = 100;
            //And I have a character seperqtor as ,
            char seperator = ',';
            //And I have a fizzbuzzconverter object
            Mock<IFizzBuzzCalculator> mock = new Mock<IFizzBuzzCalculator>();
            //When I call fizzbuzzflow.calculatefizzbuzz
            IFizzBuzzFlow fizzBuzzFlow = new FizzBuzzFlow(mock.Object);
            fizzBuzzFlow.CalculateFizzBuzz(input, seperator);
            //Then I will verify that fizzbuzzconverter object is called 100 times
            mock.Verify(m => m.Calculate(It.IsAny<int>()), Times.Exactly(100));
            
        }

        [TestMethod]
        public void Given_input_is_one_return_one()
        {
            //Given I have the number 1
            int input = 1;
            //And I have a character seperqtor as ,
            char seperator = ',';
            //And I have a fizzbuzzconverter object which returns 1
            Mock<IFizzBuzzCalculator> mock = new Mock<IFizzBuzzCalculator>();
            mock.Setup(fb => fb.Calculate(1)).Returns("1");
            //When I call fizzbuzzflow.cwlculatefizzbuzz
            IFizzBuzzFlow fizzBuzzFlow = new FizzBuzzFlow(mock.Object);
            string result = fizzBuzzFlow.CalculateFizzBuzz(input, seperator);
            //Then I will get back 1
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void Given_input_is_two_return_two()
        {
            //Given I have the number 2
            int input = 2;
            //And I have a character seperqtor as ,
            char seperator = ',';
            //And I have a fizzbuzzconverter object which returns 1 and then 2
            Mock<IFizzBuzzCalculator> mock = new Mock<IFizzBuzzCalculator>();
            mock.Setup(fb => fb.Calculate(1)).Returns("1");
            mock.Setup(fb => fb.Calculate(2)).Returns("2");
            //When I call fizzbuzzflow.cwlculatefizzbuzz
            IFizzBuzzFlow fizzBuzzFlow = new FizzBuzzFlow(mock.Object);
            string result = fizzBuzzFlow.CalculateFizzBuzz(input, seperator);
            //Then I will get back 1,2
            Assert.AreEqual("1,2", result);
        }

        [TestMethod]
        public void Given_input_is_three_return_fizz()
        {
            //Given I have the number 3
            int input = 3;
            //And I have a character seperqtor as ,
            char seperator = ',';
            //And I have a fizzbuzzconverter object which returns 1 and then 2
            Mock<IFizzBuzzCalculator> mock = new Mock<IFizzBuzzCalculator>();
            mock.Setup(fb => fb.Calculate(1)).Returns("1");
            mock.Setup(fb => fb.Calculate(2)).Returns("2");
            mock.Setup(fb => fb.Calculate(3)).Returns("fizz");
            //When I call fizzbuzzflow.cwlculatefizzbuzz
            IFizzBuzzFlow fizzBuzzFlow = new FizzBuzzFlow(mock.Object);
            string result = fizzBuzzFlow.CalculateFizzBuzz(input, seperator);
            //Then I will get back 1,2, fizz
            Assert.AreEqual("1,2,fizz", result);
        }
    }
}
