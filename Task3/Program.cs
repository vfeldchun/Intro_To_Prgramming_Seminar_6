// Задача 3: 
// Задайте произвольную строку. Выясните, является ли она палиндромом.

string[] inputStringArray = new string[]
{
    "aBcD1ef!-",
    "шалаш",
    "55655",
    "А роза упала на лапу Азора"
};

foreach (string str in inputStringArray)
{
    if (IsPolindrome(str.ToLower()))
        System.Console.WriteLine($"Строка: \"{str}\" - палиндромом!");
    else
        System.Console.WriteLine($"Строка: \"{str}\" - НЕ палиндром!");
}


bool IsPolindrome(string inputString)
{
    bool isPolindrome = false;
    string noSpaceString = RemoveSpacesFromString(inputString);
    string reversedSring = ReverseString(noSpaceString);

    if (noSpaceString == reversedSring) isPolindrome = true;

    return isPolindrome;
}

string RemoveSpacesFromString(string inputString)
{
    string spacesRemovedString = string.Concat(inputString.Split(' '));
    return spacesRemovedString;
}

string ReverseString(string inputString)
{
    string reversedString = "";

    // Можно короче
    // reversedString = string.Concat(inputString.ToCharArray().Reverse());

    for (int i = 1; i <= inputString.Length; i++)
    {
        reversedString += inputString[^i];
    }

    return reversedString;
}