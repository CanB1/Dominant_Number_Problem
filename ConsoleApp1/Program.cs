using System;

namespace Proje
{

    class Program
    {
        static void D(double N, string number)
        {



            int sum = 0;
            int digit = 0;
            int control = 0;
            while (N >= 1)
            {
                N /= 10.0; //To calculate the digit of the number, we divide by 10 but must be equal or greater than 1
                digit++;
            }
            int[] numbers = new int[digit]; //We create an array with as many elements as the number of digits
            int[] equalNumbers = new int[digit];
            for (int i = 0; i < number.Length; i++)
            {
                numbers[i] = Convert.ToInt32(number[i].ToString());  //Since strings are character arrays,
                                                                     //we can convert the number of elements to int
                                                                     //and equalize them to our new array.
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                control = 0;
                for (int j = 0; j < numbers.Length; j++)
                {

                    if (numbers[i] - numbers[j] == 0)               //we subtract the digits of the number from the other digits
                                                                    //to calculate how many of the same digits
                                                                    //if 0 the number is equal to the other digit
                    {
                        control++;

                    }
                    equalNumbers[i] = control;                      //we assign the control variable to the other array we created
                }                                                   //so the largest digit becomes the largest element of the array
            }
            Array.Sort(equalNumbers);                 //When you sort and reverse the array, 
            Array.Reverse(equalNumbers);             //the largest element will be the first element.
            double halfOfDigit = digit / 2.0;
            if (equalNumbers[0] > halfOfDigit)       //with the final check we see if the number is the dominant number
            {
                Console.WriteLine(number + " is Dominant Number");
            }
            else
            {
                Console.WriteLine(number + " is not Dominant number");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            string number = Console.ReadLine(); //i created a string to save the digits of the number
            double N = Convert.ToInt32(number); //the number itself
            D(N, number);
        }
    }


}
