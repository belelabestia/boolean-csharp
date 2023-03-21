List<int> list = new();

Console.WriteLine("Hi! I'm collecting numbers.");

while (true)
{
    Console.WriteLine("Give me a number for my collection! (or type 'exit' to quit)");

    var input = Console.ReadLine();

    if (input is "exit") break;

    var n = Convert.ToInt32(input);
    list.Add(n);
}

Console.WriteLine($"[{string.Join(", ", list)}]");

// fammi la seguente lista static: 1, 2, 3
int[] arr = { 1, 2, 3 };

// aggiungi 4 numeri forniti dall'utente
var l = arr.ToList();

l.Add(Convert.ToInt32(Console.ReadLine()));
l.Add(Convert.ToInt32(Console.ReadLine()));
l.Add(Convert.ToInt32(Console.ReadLine()));
l.Add(Convert.ToInt32(Console.ReadLine()));