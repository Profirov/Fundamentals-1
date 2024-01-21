int lettersCount = int.Parse(Console.ReadLine());
int startChar = 97;
int endChar = startChar + lettersCount;
for (int firstChar = startChar; firstChar < endChar; firstChar++)
{
    for (int second = startChar; second < endChar; second++)
    {
        for (int third = startChar; third < endChar; third++)
        {
            Console.WriteLine($"{ (char)firstChar}{ (char)second}{ (char)third}");
        }
    }
}
