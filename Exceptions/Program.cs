using Exceptions;

//Physics.Speed(10, 0);
//Algebra.Divide(10, 0);

while (true)
{
    Console.WriteLine("Provide a positive integer.");

    try
    {
        uint n1 = Convert.ToUInt32(Console.ReadLine());
        uint n2 = Convert.ToUInt32(Console.ReadLine());
        uint n3 = Convert.ToUInt32(Console.ReadLine());
        // ...
    }
    catch (OverflowException)
    {
        Console.WriteLine("I said positive integer!");
    }
    catch (FormatException)
    {
        Console.WriteLine("Please, provide a number.");
    }
    catch
    {
        Console.Error.WriteLine("Unhandled exception.");
    }
}