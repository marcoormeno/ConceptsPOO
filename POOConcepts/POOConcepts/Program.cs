// See https://aka.ms/new-console-template for more information
using POOConcepts;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

try
{
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(1979, 1, 11));
    Console.WriteLine(new Date(1984, 11, 31));
    Console.WriteLine(new Date(2011, 6, 3));
}
catch (Exception error)
{

    Console.WriteLine (error.Message );
}





