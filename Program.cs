/* ЗАДАЧА:
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Введите количество элементов ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine())!;
    arrayStrings[i] = element;
}
string[] arrayElements = new string[size];
int length = 3;
int position = 0;

for (int e = 0; e < size; e++)
{
    if (arrayStrings[e].Length <= length)
    {
        arrayElements[position] = arrayStrings[e];
        position++;
    }
}
Console.WriteLine();
PrintArray(arrayElements);
Console.ResetColor();

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"{i+1}-й элемент: соответствие требованиям -> [{array[i]}]");
}
    Console.WriteLine();
    Console.ResetColor();
}