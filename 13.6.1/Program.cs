using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        // Читаем текст из файла
        string text = File.ReadAllText("input.txt");
        string[] words = text.Split(new char[] { ' ', '\n', '\r', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        const int iterations = 10000; // Количество элементов для вставки

        // Тест для List<T>
        List<string> list = new List<string>();
        Stopwatch swList = Stopwatch.StartNew();
        for (int i = 0; i < iterations && i < words.Length; i++)
        {
            list.Insert(0, words[i]); // Вставка в начало списка
        }
        swList.Stop();
        Console.WriteLine($"List<T>: {swList.ElapsedMilliseconds} ms");

        // Тест для LinkedList<T>
        LinkedList<string> linkedList = new LinkedList<string>();
        Stopwatch swLinkedList = Stopwatch.StartNew();
        for (int i = 0; i < iterations && i < words.Length; i++)
        {
            linkedList.AddFirst(words[i]); // Вставка в начало связного списка
        }
        swLinkedList.Stop();
        Console.WriteLine($"LinkedList<T>: {swLinkedList.ElapsedMilliseconds} ms");
    }
}
