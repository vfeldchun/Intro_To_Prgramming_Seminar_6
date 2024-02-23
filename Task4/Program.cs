// Задача 4*(не обязательная): 
// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string inputString = "Мама мыла раму";

string[] wordArray = inputString.Trim().Split(' ');
ReversedWordArray(wordArray);

// Можно короче
// wordArray.Reverse();

System.Console.WriteLine(string.Join(" ", wordArray));


void ReversedWordArray(string[] wordArray)
{
    string tempWord = "";
    for (int i = 0; i <= wordArray.Length / 2; i++)
    {
        tempWord = wordArray[^(i + 1)];
        wordArray[^(i + 1)] = wordArray[i];
        wordArray[i] = tempWord;
    }
}



