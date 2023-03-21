// Scrivere una funzione per verificare se un numero è pari o dispari.
// Quindi chiedere un numero all'utente e comunicargli se è pari o dispari.

menuArray();

void menuArray()
{
    while (true)
    {
        Console.WriteLine("chose a snack (0 | 1) or type 'quit':");
        var input = Console.ReadLine();

        if (input is "quit" or "exit")
        {
            Console.WriteLine("exiting.");
            return;
        }

        try
        {
            var snacks = new[] { snack9, snack12 };
            var option = Convert.ToInt32(input);
            var selectedSnack = snacks[option];

            selectedSnack();
        }
        catch 
        {
            Console.WriteLine("invalid input.");
            continue;
        }
    }
}

void menu()
{
    while (true)
    {
        Console.WriteLine("chose a snack (9 | 12) or type 'quit':");
        var input = Console.ReadLine();

        if (input is "quit" or "exit")
        {
            Console.WriteLine("exiting.");
            return;
        }

        switch (input)
        {
            case "9":
                snack9();
                break;
            case "12":
                snack12();
                break;
            default:
                Console.WriteLine("invalid option");
                break;
        }
    }
}

void snack12()
{
    Console.WriteLine("insert a number:");
    var n = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine($"inserted number is {(isEven(n) ? "even." : "odd.")}");
}
void snack9()
{
    // Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
    // Continua a chiedere i numeri all’utente e a inserirli nell’array,
    // fino a quando la somma degli elementi è minore di 50.

    int[] numbers = Array.Empty<int>();
    int sum;

    do
    {
        var newArray = new int[numbers.Length + 1];

        Console.WriteLine("insert a number:");
        var newNumber = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            newArray[i] = numbers[i];
        }

        newArray[^1] = newNumber;
        numbers = newArray;

        sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine($"partial sum: {sum}");

    } while (sum < 50);

    Console.WriteLine($"done. final sum is: {sum}");
}

bool isEven(int num)
{
    return num % 2 == 0;
}