using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;

namespace ExtensionMethod
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student {ID = 101, Name = "Preety" },
                new Student {ID = 102, Name = "Sambit" },
                new Student {ID = 103, Name = "Hina"},
                new Student {ID = 104, Name = "Anurag"},
                new Student {ID = 102, Name = "Sambit"},
                new Student {ID = 103, Name = "Hina"},
                new Student {ID = 101, Name = "Preety" },
            };
            return students;
        }
    }
    public class Program
    {
        static void Main()
        {
            var MS = Student.GetStudents()
                   .Select(std => $"{ std.Name}-{ std.ID}")
                   .Distinct().ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
        }

    }
}

