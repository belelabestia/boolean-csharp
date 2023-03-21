// [1, 3, 5, 7]

var array = getUserInput();
var _square = squareArray(array);
var sum = arraySum(array);
var squaresSum = arraySum(_square);

printArray(array); // 1, 2, 4, 6
printArray(_square); // 1, 4, 16, 36
Console.WriteLine(sum); // 13
Console.WriteLine(squaresSum); // 57

int[] getUserInput()
{
    Console.WriteLine("insert array length:");

    var len = Convert.ToInt32(Console.ReadLine());
    var arr = new int[len];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"insert {i + 1}° element:");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    return arr;
}

void printArray(int[] array)
{
    Console.WriteLine(arrayToString(array));
}

string arrayToString(int[] array)
{
    var result = "[";

    for (int i = 0; i < array.Length; i++)
    {
        result += array[i].ToString();

        if (i < array.Length - 1)
        {
            result += ", ";
        }
    }

    result += "]";

    return result;
}

int square(int x) => x * x;

int[] squareArray(int[] array)
{
    var result = new int[array.Length];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = square(array[i]);
    }

    return result;
}

int arraySum(int[] array)
{
    var sum = 0;

    foreach (int x in array)
    {
        sum += x;
    }

    return sum;
}