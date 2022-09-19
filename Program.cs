//snack1
Console.WriteLine("Inserisci un primo numero: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inserisci un secondo numero: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
    Console.WriteLine($"{firstNumber} è maggiore di {secondNumber}");
} else if (secondNumber > firstNumber)
{
    Console.WriteLine($"{secondNumber} è maggiore di {firstNumber}");
} else
{
    Console.WriteLine($"{firstNumber} e {secondNumber} sono uguali");
}


//snack2
Console.WriteLine("Scrivi una frase");
string firstString = Console.ReadLine();
Console.WriteLine("Srivi un'altra frase");
string secondString = Console.ReadLine();
if (firstString.Length > secondString.Length)
{
    Console.WriteLine($"La frase più corta è: {secondString}");
    Console.WriteLine($"La frase più lunga è: {firstString}");
} else if (secondString.Length > firstString.Length)
{
    Console.WriteLine($"La frase più corta è: {firstString}");
    Console.WriteLine($"La frase più lunga è: {secondString}");
} else
{
    Console.WriteLine($"Le due frasi '{firstString}' e '{secondString}' hannno la stessa lunghezza");
}


//snack3
int sum = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Inserisci un numero: ");
    sum += Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"La somma di tutti i numeri inseriti è uguale a: {sum}");


//snack4
int thisSum = 0;
float average = 0;
int min = 2;
int max = 10;
for(int i = min; i <= max; i++)
{
    thisSum += i;
}
average = (float)thisSum / (max - min);
Console.WriteLine($"La somma dei numeri da 2 a 10 è: {thisSum}");
Console.WriteLine($"La media dei numeri da 2 a 10 è: {average}");


//snack5
Console.WriteLine("Inserisci un numero: ");
int numberToCheck = Convert.ToInt32(Console.ReadLine());
int numberToPrint;
if (numberToCheck % 2 == 0)
{
    numberToPrint = numberToCheck;
} else
{
    numberToPrint = ++numberToCheck;
}
Console.WriteLine(numberToPrint);


//snack6
string[] guestList = { "Lisa", "Pippo", "Carmine", "Carla" };
Console.WriteLine("Inserisci il tuo nome e verificherò se sei in lista");
string userName = Console.ReadLine();
int userIndex = Array.IndexOf(guestList, userName);
if (userIndex != -1)
{
    Console.WriteLine("Sei in lista! Buon divertimento");
} else
{
    Console.WriteLine("Non sei in lista, non puoi passare...");
}


//snack7
int[] oddList = new int[6];
for(int i = 0; i < oddList.Length; i++)
{
    Console.WriteLine("Inserisci un numero: ");
    int numbToAdd = Convert.ToInt32(Console.ReadLine());
    if (numbToAdd % 2 != 0)
    {
        oddList[i] = numbToAdd;
    }
}
Console.WriteLine("Ho raccolto solo i numeri dispari:");
for(int i = 0; i < oddList.Length - 1; i++)
{
    if (oddList[i] != 0)
    {
        Console.Write(oddList[i]);
        Console.Write(" ");
    }
}
if (oddList[oddList.Length - 1] != 0)
{
    Console.Write(oddList[oddList.Length - 1]);
}
Console.WriteLine();


//snack8
int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int anotherSum = 0;
for(int i = 0; i < ints.Length; i++)
{
    if (i % 2 != 0)
    {
        anotherSum += ints[i];
    }
}
Console.WriteLine($"Il risultato della somma dei soli elementi con indice dispari è uguale a: {anotherSum}");


//snack9
int[] myArray = new int[50];
int thisOtherSum = 0;
int index = 0;
do
{
    Console.WriteLine("La somma totale degli elementi nell'array è minore di 50, inserisci un nuovo numero");
    int newNumb = Convert.ToInt32(Console.ReadLine());
    thisOtherSum += newNumb;
    myArray[index] = newNumb;
    index++;
} while (thisOtherSum < 50);
Console.WriteLine($"Ora la somma totale è di {thisOtherSum}");


//snack10
Random rand = new Random();
Console.WriteLine("Quanti array devo creare?");
int arrayQuantity = Convert.ToInt32(Console.ReadLine());
int currentQuantity = 0;
while (currentQuantity < arrayQuantity)
{
    int[] newArray = new int[10];
    for (int i = 0; i < 10; i++)
    {
        int newRndNumb = rand.Next(1, 100);
        newArray[i] = newRndNumb;
        Console.Write(newRndNumb);
        Console.Write(" ");
    }
    Console.WriteLine();
    currentQuantity++;
}
Console.WriteLine($"Ho creato {arrayQuantity} array di 10 elementi ciascuno");


//snack12
//Scrivere una funzione per verificare se un numero è pari o dispari.
//Quindi chiedere un numero all'utente e comunicargli se è pari o dispari.

Console.WriteLine("Inserisci un numero");
int userNumber = Convert.ToInt32(Console.ReadLine());

void oddOrEven(int number)
{
    if(number % 2 == 0)
    {
        Console.WriteLine($"Il numero {number} è pari");
    } else
    {
        Console.WriteLine($"Il numero {number} è dispari");
    }
}

oddOrEven(userNumber);
