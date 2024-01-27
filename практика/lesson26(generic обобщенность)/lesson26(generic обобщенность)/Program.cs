﻿namespace lesson26_generic_обобщенность_
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }
    }
    public sealed class Person : IComparable<Person>
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Person? other) => Age.CompareTo(other.Age);
    }

    public static class MaxFinder
    {
        public static T FindMax<T>(T[] array) where T : IComparable<T>
        {
            if (array is not { Length: > 0 })
                throw new ArgumentOutOfRangeException();

            T maxEl = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].CompareTo(maxEl) > 0)
                {
                    maxEl = array[i];
                }
            }
            return maxEl;
        }
    }
}
