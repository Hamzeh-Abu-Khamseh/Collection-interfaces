using System;
using System.Collections;
using System.Collections.Generic;




namespace CustomCollectionDemo
{



    public class CustomCollection<T> : IEnumerable<T>
    {
        private List<T> _items = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                /* 
                yield return
                * the function of yield return is to return the current value to the caller, but it remembers the current location in the code for the next call.
                * the next time the iterator is accessed, it resumes execution from the state it was left in, immediately after the last yield return statement.
                */


                yield return _items[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            _items.Add(item);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CustomCollection<int> numbers = new CustomCollection<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}