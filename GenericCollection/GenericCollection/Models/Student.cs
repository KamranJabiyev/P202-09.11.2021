using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollection.Models
{
    class Student:IComparable
    {
        public int Id { get;}
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        private static int count;
        public Student()
        {
            Id = count;
            count++;
        }

        public Student(string name,string surname,int age):this()
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public int CompareTo(object obj)
        {
            Student student = obj as Student;
            return Age.CompareTo(student.Age);
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
