// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Cars.Car car = new();
car.Id = Guid.NewGuid().ToString(); 
car.Name = "BMW";

Console.WriteLine("Welcome to your new car");

// Start the new notifications system 
