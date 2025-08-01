using System;
using System.Collections;
using System.Collections.Generic;


public class CustomCollection<T> : IList<T>
{
    private List<T> _items = new List<T>();

    public T this[int index]
    {
        get => _items[index];
        set => _items[index] = value;
    }
    public int Count => _items.Count;
    public bool IsReadOnly => false;
    public void Add(T item) => _items.Add(item);
    public void Clear() => _items.Clear();
    public bool Contains(T item) => _items.Contains(item);
    public void CopyTo(T[] array, int arrayIndex) => _items.CopyTo(array, arrayIndex);
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _items.Count; i++)
        {
            yield return _items[i];
        }
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    public int IndexOf(T item) => _items.IndexOf(item);
    public void Insert(int index, T item) => _items.Insert(index, item);
    public bool Remove(T item) => _items.Remove(item);
    public void RemoveAt(int index) => _items.RemoveAt(index);

}

public class Program
{
    static void Main(string[] args)
    {
        CustomCollection<string> myList = new CustomCollection<string>();
        myList.Add("First");
        myList.Add("Second");
        myList.Insert(1, "Inserted");

        Console.WriteLine("Items in the collection:");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }

        myList.RemoveAt(1);
        Console.WriteLine("\nAfter removing the inserted item:");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }

        myList[2] = "Updated Third";
    }
}   