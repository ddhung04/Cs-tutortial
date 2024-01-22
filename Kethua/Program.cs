using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kethua
{
    public class Person
    {
        private string name;
        private string address;

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public string GetName()
        {
            return name;
        }

        public string GetAddress()
        {
            return address;
        }

        public override string ToString()
        {
            return $"Person[name={name}, address={address}]";
        }
    }

    public class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        public void SetProgram(string program)
        {
            this.program = program;
        }

        public void SetYear(int year)
        {
            this.year = year;
        }

        public void SetFee(double fee)
        {
            this.fee = fee;
        }

        public string GetProgram()
        {
            return program;
        }

        public int GetYear()
        {
            return year;
        }

        public double GetFee()
        {
            return fee;
        }

        public override string ToString()
        {
            return $"Student[{base.ToString()}, program={program}, year={year}, fee={fee}]";
        }
    }

    class Program
    {
        static void Main()
        {
            // Sử dụng ví dụ
            Student student = new Student("Duy Hung", "144 Xuan Thuy", "Computer Science", 2, 1500.0);
            Console.WriteLine(student.ToString());

            student.SetYear(3);
            student.SetFee(1800.0);
            Console.WriteLine(student.ToString());
            Console.ReadKey();
        }
    }
}


