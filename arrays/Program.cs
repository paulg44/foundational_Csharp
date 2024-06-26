﻿// [3] indicates number of elements that the array can hold
// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";

// Example of runtime error, Index out of bounds (there is no [3] in array)
// fraudulentOrderIDs[3] = "D000";

// string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// // For Each
// // Example
// string[] names = {"Rowena", "Robin", "Bao"};
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// int[] inventory = {200, 450, 700, 175, 250};
// int sum = 0;
// int bin = 0;
// foreach(int items in inventory)
// {
//    sum += items;
//    bin++;
//    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }

// Console.WriteLine($"We have {sum} items in inventory.");

// Challenge --- Your team has found a pattern. Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate. You write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B". This will be used by the fraud team to investigate further.

string[] array = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string item in array)
{
    if(item.StartsWith("B"))
    {
        Console.WriteLine(item);
    }
}