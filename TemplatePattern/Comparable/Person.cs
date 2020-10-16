using System;

namespace TemplatePattern.Comparable
{
    internal class Person : IComparable
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; }
        public int Age { get; }

        public int CompareTo(object obj)
        {
            var other = (Person) obj;
            if (string.Compare(Name, other.Name, StringComparison.Ordinal) == 0) return Age.CompareTo(other.Age);
            return string.Compare(Name, other.Name, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"{Name} : {Age} < ";
        }
    }
}