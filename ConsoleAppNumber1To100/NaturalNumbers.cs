using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNumber1To100
{
    public class NaturalNumbers
    {
        public List<int> ListOfNumbers { get; private set; }

        public NaturalNumbers(int firstNumber, int lastNumber)
        {
            if (ListOfNumbers == null) 
            {
                ListOfNumbers = new List<int>();
            }

            for (int i = firstNumber; i <= lastNumber; i++)
            {
                ListOfNumbers.Add(i);
            }
           
        }
    }
}
