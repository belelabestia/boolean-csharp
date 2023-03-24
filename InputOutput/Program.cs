using var a = File.Open("data.txt", FileMode.Open);

try
{
    if (!File.Exists("data.txt"))
    {
        using StreamWriter output = File.CreateText("data.txt");

        for (int i = 0; i < 1000; i++)
        {
            output.WriteLine(i);
        }
    }

    using StreamReader input = File.OpenText("data.txt");

    while (!input.EndOfStream)
    {
        string riga = input.ReadLine()!;
        Console.WriteLine(riga);
    }
}
catch 
{
    Console.WriteLine("Ops!");
}