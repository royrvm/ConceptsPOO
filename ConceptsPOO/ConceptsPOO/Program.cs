// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("Hello, World!");
Console.WriteLine("=============");

try
{
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(2022, 8, 25));
    Console.WriteLine(new Date(2022, 8, 5));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}
