using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{ Id = 1, Name = "An", Age = 16 },
                new Student{ Id = 2, Name = "Binh", Age = 17 },
                new Student{ Id = 3, Name = "Cuong", Age = 14 },
                new Student{ Id = 4, Name = "Anh", Age = 18 },
                new Student{ Id = 5, Name = "Dung", Age = 19 }
            };

            Console.WriteLine("a. Danh sach hoc sinh:");
            var allStudents = from s in students select s;
            foreach (var s in allStudents)
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}");

            Console.WriteLine("\nb. Hoc sinh co tuoi tu 15 den 18:");
            var age15to18 = from s in students
                            where s.Age >= 15 && s.Age <= 18
                            select s;
            foreach (var s in age15to18)
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}");

            Console.WriteLine("\nc. Hoc sinh co ten bat dau bang chu A:");
            var startWithA = from s in students
                             where s.Name.StartsWith("A")
                             select s;
            foreach (var s in startWithA)
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}");

            Console.WriteLine("\nd. Tong tuoi cua tat ca hoc sinh:");
            var totalAge = (from s in students select s.Age).Sum();
            Console.WriteLine(totalAge);

            Console.WriteLine("\ne. Hoc sinh co tuoi lon nhat:");
            var maxAge = (from s in students select s.Age).Max();
            var oldest = from s in students
                         where s.Age == maxAge
                         select s;
            foreach (var s in oldest)
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}");

            Console.WriteLine("\nf. Danh sach hoc sinh theo tuoi tang dan:");
            var sorted = from s in students
                         orderby s.Age ascending
                         select s;
            foreach (var s in sorted)
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}");
        }
    }
}
