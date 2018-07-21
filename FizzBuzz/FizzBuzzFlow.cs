using FizzBuzz.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzFlow : IFizzBuzzFlow
    {
        private readonly IFizzBuzzCalculator _fizzbuzz;

        public FizzBuzzFlow(IFizzBuzzCalculator fizzbuzz)
        {
            _fizzbuzz = fizzbuzz;
        }

        public string CalculateFizzBuzz(int input, char seperator)
        {
            string fizzbuzz = "";
            for (var i = 1; i <= input; i++)
            {
                fizzbuzz += _fizzbuzz.Calculate(i);

                if (input != i)
                {
                    fizzbuzz += seperator.ToString();
                }

            }
            return fizzbuzz;
        }
    }
}
