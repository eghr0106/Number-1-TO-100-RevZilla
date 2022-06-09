using System;

namespace ConsoleAppNumber1To100
{
    class Program
    {
        static void Main(string[] args)
        {

            var modalNumbers = new ModalNumbers().PrintModalNumbers();

            if (modalNumbers != null) 
            {
                foreach (var item in modalNumbers)
                {
                    Console.WriteLine(item);
                }
            }            
            
        }
    }
}
