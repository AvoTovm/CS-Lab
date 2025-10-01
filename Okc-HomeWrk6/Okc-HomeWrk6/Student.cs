using System;

namespace Okc_HomeWrk6
{
    class Student
    {
        public static int count;
        private string _name;
        private int _age;
        private int _studentId;

        public Student() : this("No-name", 0, 0) { }
        public Student(string name, int age) : this(name, age, 0) { }
        public Student(string name, int age, int studentId)
        {
            _name = name;
            _age = age;
            _studentId = studentId;
            count++;
        }

        public override string ToString()
        {
            return $"{_name} StudentID ({_studentId}), {_age} years old";
        }
    }
}