using System;
using System.Collections;
using System.Collections.Generic;


public class CustomCollection<T>:ICollection<T>
{
    private List<T> _items = new List<T>();

    public int Count => _items.Count;
    public bool IsReadOnly => false;

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _items.Count; i++)
        {
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
    public void Clear()
    {
        _items.Clear();
    }
    public bool Contains(T item)
    {
        return _items.Contains(item);
    }
    public void CopyTo(T[] array, int arrayIndex)
    {
        _items.CopyTo(array, arrayIndex);
    }
    public bool Remove(T item)
    {
        return _items.Remove(item);
    }
    
}
public class Program
{
    static void Main(string[] args)
    {
        CustomCollection<string> shoppingCart = new CustomCollection<string>();
        
        shoppingCart.Add("Apple");
        shoppingCart.Add("Banana");
        shoppingCart.Add("Orange");

        Console.WriteLine($"Number Of Items in the shopping cart: {shoppingCart.Count}"); 

        Console.WriteLine("Items in the shopping cart:");
        foreach (var item in shoppingCart)
        {
            Console.WriteLine(item);
        }

        if(shoppingCart.Contains("Banana"))
        {
            Console.WriteLine("Removing Banana from the shopping cart:");
            shoppingCart.Remove("Banana");
        }
        else
        {
            Console.WriteLine("Banana is not in the shopping cart.");
        }

        Console.WriteLine($"Number Of Items in the shopping cart after removal: {shoppingCart.Count}");
        Console.WriteLine("Items in the shopping cart after removal:");
        foreach (var item in shoppingCart)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
    }
}