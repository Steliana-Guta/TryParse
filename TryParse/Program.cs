using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age in full years :");
            string inputAgeString =  Console.ReadLine();
            int inputAge = Convert.ToInt32(inputAgeString);
            Int32.TryParse(inputAgeString, out inputAge);
            if (inputAge > 0)
            {
                Console.WriteLine("You are " + inputAge + " years old.");
            }
            else
            {
                Console.WriteLine("You entered an invalid answear");
           //to accept 21.5 i would change the parse from int32 to decimal
            }
        }
    }
}
