// See https://aka.ms/new-console-template for more information
using Question1.Application;

Console.WriteLine("Welcome to ZBRA test!");

var exit = false;

while (!exit)
{
    Console.WriteLine("Select an option: \r\n 1 - Password \r\n 0 - Exit");
    var number = Console.ReadLine();
    
    if (int.Parse(number ?? "0") == 1)
    {
        var possibilities = ApplicationPasswordService.CalculatePossibilitiesBetween(184759, 856920);
        Console.WriteLine(String.Format("There are {0} passwords following rules", possibilities));
    }
    else if(int.Parse(number ?? "0") == 0)
    {
        Environment.Exit(0);
    }
}