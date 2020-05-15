using System;
using System.Security.Cryptography;

namespace FirstApp
{
    //struct Student
    //{
    //    public int StudentID;
    //    public string StudentName;
    //    public double Avg;
    //}
    class Program
    {
        static void Add(dynamic a, dynamic b)
        {
            Console.WriteLine(a + b);
        }
        static void Main(string[] args)
        {
            #region Day 1
            //int a, b, c;
            //a = 10;
            //b = 20;
            //c = a + b;
            //Console.WriteLine("The sum of {0} and {1} is {2}",a,b,c);

            //int a, b, c;
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //c = a + b;
            //Console.WriteLine("The sum is {0}", c); 
            #endregion
            #region Day 2
            //int a, b;
            //Console.WriteLine("Enter two numbers");
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //if (a>b)
            //{
            //    Console.WriteLine("{0} is greater than {1}", a, b);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is greater than {1}", b, a);
            //}

            //    int a, b, choice;
            //    Console.WriteLine("Enter two numbers");
            //    a = int.Parse(Console.ReadLine());
            //    b = int.Parse(Console.ReadLine());

            //L: Console.WriteLine("Enter a choice from:");
            //    Console.WriteLine("1. Addition 2. Subtraction 3. Multiplication 4. Division");
            //    choice = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine("Addition is:" + (a + b));
            //            break;
            //        case 2:
            //            Console.WriteLine("Subtraction is:" + (a - b));
            //            break;
            //        case 3:
            //            Console.WriteLine("Multiplication is:" + (a * b));
            //            break;
            //        case 4:
            //            Console.WriteLine("Division is:" + (a / b));
            //            break;
            //        default:
            //            Console.WriteLine("Please Enter a valid input");
            //            goto L;
            //    }
            //for (int i = 1; i < 11; i++)
            //{
            //    for (int k = 10; k > i; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < 2*(i)-1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //} 
            #endregion
            #region array
            //int[] A1 = new int[3];
            //A1[0] = 1;
            //A1[1] = 32;
            //A1[2] = 5;
            //foreach (int i in A1)
            //{
            //    Console.WriteLine(i);
            //}
            //Array.Sort(A1);
            //foreach (int i in A1)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion
            #region Struct
            //Student S;
            //S.Avg = 23;
            //S.StudentID = 123;
            //S.StudentName = "Kiran";
            //Console.WriteLine(S.StudentName);

            //Student[] SA=new Student[5];
            //Random R= new Random();
            //for (int i = 0; i < SA.Length; i++)
            //{
            //    SA[i].Avg = R.NextDouble()*100;
            //    Console.WriteLine(SA[i].Avg);
            //} 
            #endregion
            
            Add(2,3);
            Add(2.1,3.2);
        }
    }
}