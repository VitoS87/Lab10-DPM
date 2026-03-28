using System;
using System.Text.RegularExpressions;
//1
//Console.Write("Введите количество чисел:");
//int n = int.Parse(Console.ReadLine()!);
//Figures figures = new Figures(n);
//figures.Create();
//figures.HowMany();
//class Figures
//{
//    private int Count;
//    public int Quantity { get; set; }
//    public List<int>? Numbers;
//    public Figures(int n)
//    {
//        Quantity = n;

//        Numbers = new List<int>();
//    }
//    public void Create()
//    {
//        Console.WriteLine("Введите числа:");
//        for (int i = 0; i < Quantity; i++)
//        {
//            int num = int.Parse(Console.ReadLine()!);
//            Numbers!.Add(num);
//        }
//    }
//    public void HowMany()
//    {
//        SortedSet<int> s = new SortedSet<int>();
//        foreach (int i in Numbers!)
//        {
//            s.Add(i);
//        }
//        Console.WriteLine("Количество чисел:" + s.Count);
//        Console.WriteLine("Все числа:");
//        foreach (int i in s) Console.WriteLine(i + " ");
//    }
//}
//2
Console.WriteLine("Введите текст");
string text = Console.ReadLine()!;
char[] separators = { ' ', '.', ',', '!', '?', ':', ';', '-' };
string[] words = text.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
Dictionary<string, int> wordсount = new Dictionary<string, int>();
foreach (string word in words)
{
    if (wordсount.ContainsKey(word))
        wordсount[word]++;
    else
        wordсount[word] = 1;
}
Console.WriteLine("Повторяющиеся слова:");
foreach (var pair in wordсount.Where(p => p.Value > 1))
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}