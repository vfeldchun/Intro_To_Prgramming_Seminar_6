// Задача 2: 
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string inputString = "“aBcD1ef!-";

string resultString = GetLowerCaseString(inputString);
System.Console.WriteLine(resultString);
// Простой вариант
// System.Console.WriteLine(inputString.ToLower());


string GetLowerCaseString(string inputString)
{
    string resultString = "";

    foreach (var ch in inputString)
        if (char.IsUpper(ch)) resultString += char.ToLower(ch);
        else resultString += ch;

    return resultString;
}
