/**       
 *--------------------------------------------------------------------
 * 	   File name: Lab6.cs
 * 	Project name: Lab6
 *--------------------------------------------------------------------
 * Author’s name and email: Sam Collins (collinss5@etsu.edu)				
 *          Course-Section:  CSCI 1250-001
 *           Creation Date:	 10/19/22		
 * -------------------------------------------------------------------
 */

static void ShowCharacter(string str, int charPos)
{
    int charPosOffset = charPos - 1;
    if (charPosOffset < 0 || charPosOffset > str.Length - 1)
    {
        Console.WriteLine("Character Posistion is out of bounds!");
        return;
    }
    Console.WriteLine(str[charPosOffset]);
}

static float CalculateRetail(float wholesaleCost, float markupPercentage)
{
    float retailPrice = wholesaleCost + (wholesaleCost * markupPercentage);

    Console.WriteLine($"Item Retail Price: ${Math.Round(retailPrice, 2)}");
    return retailPrice;
}

static float Celcius(float fahrenheitTemp)
{
    float celciusTemp = (5.0f / 9.0f) * (fahrenheitTemp - 32.0f);
    return celciusTemp;
}

static bool IsPrime(int num)
{
    if (num == 0 || num == 1)
        return false;

    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}

static void MethodSelector()
{
    Console.WriteLine("\n----------------");
    Console.WriteLine("Select a method:\n");
    Console.WriteLine("ShowCharacter");
    Console.WriteLine("CalculateRetail");
    Console.WriteLine("Celcius");
    Console.WriteLine("IsPrime");
    Console.Write("\n>");

    string selection = Console.ReadLine();
    selection = selection.Trim();
    selection = selection.ToLower();

    switch (selection)
    {
        //------ShowCharacter------
        case "showcharacter":
            Console.Clear();

            Console.Write("Enter a string:\n>");
            string inputString = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("What character do you want to display? (integer number):\n>");
            int stringIndex = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");

            ShowCharacter(inputString, stringIndex);

            MethodSelector();
            break;
        //------ShowCharacter------

        //-----CalculateRetail-----
        case "calculateretail":
            Console.Clear();

            Console.Write("What is the wholesale cost of the item?:\n>");
            float wholesaleCost = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("What is the markup percentage?:\n>");
            float markupPercentage = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            CalculateRetail(wholesaleCost, markupPercentage * 0.01f);

            MethodSelector();
            break;
        //-----CalculateRetail-----

        //---------Celcius---------
        case "celcius":
            Console.Clear();

            for (int i = 80; i <= 100; i++)
            {
                Console.WriteLine($"F: {i} C: {Math.Round(Celcius(i), 2)}");
            }

            MethodSelector();
            break;
        //---------Celcius---------

        //---------IsPrime---------
        case "isprime":
            Console.Clear();

            Console.Write("Enter a number: (int)\n>");
            int primeInput = Int32.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"{primeInput} is prime: {IsPrime(primeInput)}");

            MethodSelector();
            break;
        //---------IsPrime---------

        default:
            Console.Clear();
            Console.WriteLine("Invalid selection!\n");
            MethodSelector();
            break;
    }
}

MethodSelector();