using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            firstNumber = 10;
            secondNumber = firstNumber;
            firstNumber = 20;
            //Console.WriteLine("First Number is : "+ firstNumber + "\nSecond Number is : " + secondNumber);

　
            int[] firstArray = new int[2];
            firstArray[0] = 10;
            int[] secondArray = firstArray;
            int[] thirdArray = new int[2];
            firstArray.CopyTo(thirdArray, 0);
            int[] fourthArray = (int[]) firstArray.Clone();
            
            firstArray[0] = 20;
            firstArray[1] = 30;

            
            Console.WriteLine("\n\n**************Contents / Address of first Array**************");
            for (int index = 0; index < firstArray.Length; index++)
            {
                Console.WriteLine(firstArray[index]);
            }
            Console.WriteLine("\n\n**************Contents / Address of second Array**************");
            for (int index = 0; index < secondArray.Length; index++)
            {
                Console.WriteLine(secondArray[index]);
            }
            Console.WriteLine("\n\n**************Contents / Address of third Array**************");
            for (int index = 0; index < thirdArray.Length; index++)
            {
                Console.WriteLine(thirdArray[index]);
            }
            Console.WriteLine("\n\n**************Contents / Address of fourth Array**************");
            for (int index = 0; index < fourthArray.Length; index++)
            {
                Console.WriteLine(fourthArray[index]);
            }

            Console.ReadKey();
        }
    }
}
