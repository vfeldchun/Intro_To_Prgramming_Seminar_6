// Задача 1: 
// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] charArray = new char[2, 3]
{
    {'a', 'b', 'c'},
    {'d', 'e', 'f'}
};

string resultString = GetStringFromCharArray(charArray);
System.Console.WriteLine(resultString);


string GetStringFromCharArray(char[,] charArray)
{
    string resultString = "";

    foreach (var ch in charArray)
        resultString += ch;

    return resultString;
}