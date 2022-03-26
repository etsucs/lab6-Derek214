ShowCharacter("New York", 2);
CalculateRetail();
for (decimal temp = 80; temp <= 100; temp++)
{
    System.Console.Write($"{temp}°F    ");
    Celsius(temp);
}
IsPrime(5);
IsPrime(6);
static void ShowCharacter(string word, int position)
{
    char character = word[position - 1];
    System.Console.WriteLine(character);
}
static void CalculateRetail()
{
    System.Console.WriteLine("Enter the wholesale cost");
    decimal wholesale = decimal.Parse(Console.ReadLine());
    System.Console.WriteLine("Enter the markup percentage");
    decimal markup = (decimal.Parse(Console.ReadLine())) / 100;
    decimal retailPrice = Math.Round(wholesale + (wholesale * markup), 2);
    System.Console.WriteLine($"The retail price will be ${retailPrice}");
}
static void Celsius(decimal fahrenheitTemp)
{
    decimal celsiusTemp = Math.Round((fahrenheitTemp - 32) * 5 / 9, 2);
    System.Console.WriteLine($"{celsiusTemp}°C");
}
static void IsPrime(int num)
{
    bool isPrime = true;
    if (num == 0 || num == 1)
    {
        isPrime = false;
    }
    else
    {
         for (int i = 2; i < num/2; i++)
    {
        if (num % i == 0)
        {
            isPrime = false;
        }
    }
    
    }
    System.Console.WriteLine(isPrime);
}
