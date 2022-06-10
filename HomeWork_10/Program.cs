string[] Syllables = {"tru", "qwo", "try", "idy", "oda", "ert", "yui", "svu","uno", "sti", "lot", "api"};
/*
Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1   (гласные - a, e, i, o, u, y.  ) 
*/
void CountVowelLetters(string[] words)
{
    int count = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i][0] == 'a' || 
            words[i][0] == 'e' || 
            words[i][0] == 'i' || 
            words[i][0] == 'o' ||
            words[i][0] == 'u' || 
            words[i][0] == 'y') 
        count++;
        Console.Write( words[i]+ ", ");
    }
    Console.WriteLine(" -> " + count);
}
CountVowelLetters(Syllables);


/*
Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы
исходного массива попарно.
Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}
*/
/*
string[] MergeSyllables(string[] words)
{
    string[] array = new string[words.Length/2];
    for (int i = 0; i < words.Length; i++)
    {
        words[i] = words[i] + words[i + 1];
        Console.Write(words[i] + "\t");
        i++;
    }
    return words;
    
}
MergeSyllables(Syllables);
*/

