using System;

namespace Reboot
{
    public class Program
    {
        #region Stars_fn
        static void Stars(int noOfRows)
        {
            for (int i = 0; i < noOfRows; i++)
            {
                for (int j = (noOfRows - i); j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < (2 * i + 1); k++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
        } 
        #endregion
        #region if else
        static string isPrime(int number)
        {
            int flag = 0;
            for (int i = 2; i < (number / 2) + 1; i++)
                flag += (number % i) == 0 ? 1 : 0;
            return flag == 0 ? "The number is prime" : "The number is not prime";
        }
        #endregion
        static void Main(string[] args)
        {
            #region Stars
            //Console.WriteLine("Enter the number of rows of stars you want");
            //try
            //{
            //    int noOfStars = int.Parse(Console.ReadLine());
            //    Stars(noOfStars);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Please only enter integers in the field");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Please enter a sensible number");
            //} 
            #endregion
            #region Prime
            //Console.WriteLine("Enter an integer to check if it is prime.");
            //string textNumber = Console.ReadLine();
            //try
            //{
            //    Console.WriteLine(isPrime(int.Parse(textNumber)));
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Please enter a valid integer");
            //} 
            #endregion
            #region Average
            //    int sum = 0;
            //    int ctr = 0;
            //    while (1 > 0)
            //    {
            //        Console.WriteLine("Please enter marks");
            //        string strInput = Console.ReadLine();
            //        try
            //        {
            //            int numInput = int.Parse(strInput);
            //            if (numInput < 20)
            //            {
            //                if (numInput > 0)
            //                {
            //                    sum += numInput;
            //                    ctr++;
            //                }
            //                else
            //                    break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Please enter marks less than 20");
            //            }
            //        }
            //        catch (Exception)
            //        {
            //            Console.WriteLine("Invalid value entered"); ;
            //        }
            //    }
            //    Console.WriteLine("The average is: {0}", (sum / ctr)); 
            #endregion
            var denis = new Human();
            Console.WriteLine("Please enter first name");
            NameEntry:
            try
            {
                denis.FirstName = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid First Name");
                goto NameEntry;
            }
            Console.WriteLine("Please enter last name");
            denis.LastName = Console.ReadLine();
            Console.WriteLine("This is {0}",denis.FullName);
        }
    }
}
