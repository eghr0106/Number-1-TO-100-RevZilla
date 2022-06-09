using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppNumber1To100
{
    public class ModalNumbers
    {
        public List<string> PrintModalNumbers() 
        {
            var NaturalNumbers = new NaturalNumbers(1, 100);

            var ListOfNumbers = NaturalNumbers.ListOfNumbers;

            var result = new List<string>();

            foreach (var item in ListOfNumbers)
            {
                if (item % 3 == 0 && item % 5 == 0)
                {
                    result.Add( "FIZZ & BUZZ");
                }
                else if (item % 3 == 0)
                {
                    result.Add("FIZZ");
                }
                else if (item % 5 == 0)
                {
                    result.Add("BUZZ");
                }
                else
                {
                    result.Add(item.ToString());
                }
            }

            return result;           
        }
    }
}
