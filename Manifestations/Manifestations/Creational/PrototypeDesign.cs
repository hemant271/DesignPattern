using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manifestations.Creational
{
    public interface IPrototype
    {
        IPrototype Clone();
    }

    public class Student : IPrototype
    {
        public int age { get; set; }
        private int rollNumber { get; set; }
        public string name { get; set; }
        public Student(int age, int rollNumber, string name)
        {
            this.age = age;
            this.rollNumber = rollNumber;
            this.name = name;
        }
        public IPrototype Clone()
        {
            return new Student(age, rollNumber, name);
        }
    }

    internal class PrototypeDesign
    {
        public static void runMethod()
        {
            Student baseStudent = new Student(age: 20, rollNumber: 12345, name: "John Doe");
            Student clone1 = (Student)baseStudent.Clone();

            Console.WriteLine(clone1.name);
        }
    }
}
