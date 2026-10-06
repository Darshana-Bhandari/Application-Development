using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a List of fruits
        List<string> fruits = new List<string>
        {
            "Apple",
            "Mango",
            "Banana"
        };

        // Add a new fruit
        fruits.Add("Orange");

        // Remove one fruit
        fruits.Remove("Banana");

        // Print all fruits
        Console.WriteLine("Fruits in the list:");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Create Dictionary
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Apple" },
            { 2, "Mango" },
            { 3, "Banana" }
        };

        // Add new entry
        fruitDictionary.Add(4, "Orange");

        // Print all key-value pairs
        Console.WriteLine("\nFruit Dictionary:");

        foreach (KeyValuePair<int, string> item in fruitDictionary)
        {
            Console.WriteLine($"ID: {item.Key}, Fruit: {item.Value}");
        }
    }
}