using System;
using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void Given_Input_Is_1_Return_1()
        {
            //given i have the number 1
            int i = 1;

            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();
            string s = fizzBuzzCalculator.Calculate(i);

            //then i get back 1
            Assert.AreEqual("1", s);

        }

        [TestMethod]
        public void Given_Input_Is_2_Return_2()
        {
            //given i have the number 2
            int i = 2;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();
            string s = fizzBuzzCalculator.Calculate(i);

            //then i get back 2
            Assert.AreEqual("2", s);
        }

        [TestMethod]
        public void Given_Input_Is_3_Return_fizz()
        {
            //given i have the number 3
            int i = 3;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();
            string s = fizzBuzzCalculator.Calculate(i);

            //then i get back fizz
            Assert.AreEqual("fizz", s);
        }

        [TestMethod]
        public void Given_Input_Is_4_Return_4()
        {
            //given i have the number 4
            int i = 4;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();
            string s = fizzBuzzCalculator.Calculate(i);
            //then i get back 4
            Assert.AreEqual("4", s);
        }

        [TestMethod]
        public void Given_Input_Is_5_Return_buzz()
        {
            //given i have the number 5
            int i = 5;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();
            string s = fizzBuzzCalculator.Calculate(i);
            //then i get back 5
            Assert.AreEqual("buzz", s);
        }

        [TestMethod]
        public void Given_Input_Is_6_Return_fizz()
        {
            //given i have the number 6
            int i = 6;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();
            string s = fizzBuzzCalculator.Calculate(i);
            //then i get back 6
            Assert.AreEqual("fizz", s);
        }

        [TestMethod]
        public void Given_Input_Is_7_Return_7()
        {
            //given i have the number 7
            int i = 7;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();
            string s = fizzBuzzCalculator.Calculate(i);
            //then i get back 7
            Assert.AreEqual("7", s);
        }

        [TestMethod]
        public void Given_Input_Is_9_Return_fizz()
        {
            //given i have the number 9
            int i = 9;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();
            string s = fizzBuzzCalculator.Calculate(i);
            //then i get back 9
            Assert.AreEqual("fizz", s);
        }

        [TestMethod]
        public void Given_Input_Is_10_Return_buzz()
        {
            //given i have the number 10
            int i = 10;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();
            string s = fizzBuzzCalculator.Calculate(i);
            //then i get back 10
            Assert.AreEqual("buzz", s);
        }

        [TestMethod]
        public void Given_Input_Is_11_Return_11()
        {
            //given i have the number 11
            int i = 11;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();
            string s = fizzBuzzCalculator.Calculate(i);
            //then i get back 11
            Assert.AreEqual("11", s);
        }

        [TestMethod]
        public void Given_Input_Is_15_Return_fizzbuzz()
        {
            //given i have the number 15
            int i = 15;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();
            string s = fizzBuzzCalculator.Calculate(i);
            //then i get back 15
            Assert.AreEqual("fizzbuzz", s);
        }

        [TestMethod]
        public void Given_Input_Is_16_Return_16()
        {
            //given i have the number 16
            int i = 16;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();
            string s = fizzBuzzCalculator.Calculate(i);
            //then i get back 16
            Assert.AreEqual("16", s);
        }

        [TestMethod]
        public void Given_Input_Is_30_Return_fizzbuzz()
        {
            //given i have the number 30
            int i = 30;
            //when i pass in the number to the fizz buzz converter
            IFizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator();
            string s = fizzBuzzCalculator.Calculate(i);
            //then i get back fizzbuzz
            Assert.AreEqual("fizzbuzz", s);
        }

    }
}
