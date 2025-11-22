' This code runs in the Sub Main() method of a console application
Console.Write("Please enter your name: ")
Dim name = Console.ReadLine()
Dim currentDate = DateTime.Now
Console.WriteLine($"Hello, {name}, on {currentDate:d} at {currentDate:t}")
Console.Write("Press any key to continue...")
Console.ReadKey(True)
