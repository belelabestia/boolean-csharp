// immaginiamo di avere un array di interi e di doverli raddoppiare tutti
// vogliamo costruire una funzione void che modifichi l'array in-place,
// cioè senza allocare altra memoria per un secondo array, ma invece modificando
// direttamente i valori del primo.

var numbers = new int[] { 1, 2, 3, 4 };

printNumbers(numbers);
doubleElementsInPlace(ref numbers);
printNumbers(numbers);

void printNumbers(int[] numbers)
{
    foreach (var n in numbers)
    {
        Console.Write(n);
        Console.Write(' ');
    }

    Console.WriteLine();
}

void doubleElementsInPlace(ref int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= 2;
    }

    numbers = new[] { 0 };
}

// immaginiamo di voler raddoppiare allo stesso modo una
// variabile che rappresenta un singolo numero intero.
// avremmo un problema!

var i = 24;

Console.WriteLine(i);
doubleNumberInPlace(i);
Console.WriteLine(i);

void doubleNumberInPlace(int number)
{
    number *= 2;
}

// visual studio ci avverte che modificare questa variabile è inutile!

// come potremmo fare a ottenere lo stesso comportamento
// con una variabile di tipo valore?

var n = 123;

Console.WriteLine(n);
doubleNumberInPlaceRef(ref n);
Console.WriteLine(n);

void doubleNumberInPlaceRef(ref int number)
{
    number *= 2;
}

// l'aggiunta del modificatore 'ref' modifica il meccanismo con cui
// la variabile viene passata alla funzione. non viene più passata
// una copia della variabile ma l'esatto riferimento in memoria,
// nello stesso modo in cui avverrebbe sullo heap con l'array.
// con 'ref', le variabili di tipo valore e quelle di tipo riferimento
// si comportano allo stesso modo!