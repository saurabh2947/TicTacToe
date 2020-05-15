using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SecondApp
{
    #region originalClass
    //class Student
    //{
    //    private int StudentID;
    //    private string StudentName;
    //    private double[] Marks = new double[5];

    //    public void CreateStudent()
    //    {
    //        Console.WriteLine("Enter the Student's ID, please.");
    //        StudentID = int.Parse(Console.ReadLine());
    //        Console.WriteLine("Enter your Student's name, please.");
    //        StudentName = Console.ReadLine();
    //    }

    //    public void EnterMarks()
    //    {
    //        Console.WriteLine("Enter the student's marks in all the five subjects");
    //        for (int i = 0; i < Marks.Length; i++)
    //        {
    //            Marks[i] = int.Parse(Console.ReadLine());
    //        }
    //    }

    //    public void Result()
    //    {
    //        double sum = 0;
    //        for (int i = 0; i < Marks.Length; i++)
    //        {
    //            sum = sum + Marks[i];
    //        }

    //        double average = sum / Marks.Length;

    //        if (average < 40)
    //        {
    //            Console.WriteLine("The student has failed!");
    //        }
    //        else
    //        {
    //            Console.WriteLine("The student has passed!");
    //        }
    //    }
    //    public void Result(int minMarks)
    //    {
    //        double sum = 0;
    //        for (int i = 0; i < Marks.Length; i++)
    //        {
    //            sum = sum + Marks[i];
    //        }

    //        double average = sum / Marks.Length;

    //        if (average < minMarks)
    //        {
    //            Console.WriteLine("The student has failed!");
    //        }
    //        else
    //        {
    //            Console.WriteLine("The student has passed!");
    //        }
    //    }
    //}
    //class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        var student = new Student();
    //        student.CreateStudent();
    //        student.EnterMarks();
    //        student.Result(35);
    //    }
    //} 
    #endregion

    #region Properties
    //class Student
    //{
    //    private int _SID;
    //    private string _Name;
    //    public Student(int _SID, string _Name)
    //    {
    //        this._SID = _SID;
    //        this._Name = _Name;
    //    }
    //    public int SID
    //    {
    //        //set { _SID = value; }
    //        get { return _SID; }
    //    }

    //    public string Name
    //    {
    //        set
    //        {
    //            if (value.Length<50)
    //            {
    //                _Name = value;
    //            }
    //        }
    //        get { return _Name; }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //     var S1=new Student(1,"Peter");
    //     Console.WriteLine("Student ID:{0} Name:{1}",S1.SID,S1.Name);
    //     S1.Name = "Fergo";
    //     Console.WriteLine("Student ID:{0} Name:{1}", S1.SID, S1.Name);
    //    }
    //} 
    #endregion

    class Student
    {
        [Required]
        public int SID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var S1=new Student(){Name = "Peter"};
            S1.Name = "kanfkasfkabfkcccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccasjnfkasnkfjbnasd";
            Console.WriteLine("Student SID:{0}, Name:{1}",S1.SID,S1.Name);
        }
    }
}
