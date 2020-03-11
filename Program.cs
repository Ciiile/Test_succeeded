using System;

namespace iPole_01
{

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Cecilie", 21);


            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}

// hello 
