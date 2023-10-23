// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] GetArray(string message)
{
    Console.Write($"{message}: ");
    string text = Console.ReadLine()!;
    string[] array = text.Split(new char[] {' '});
    return array;
}

int ArraySize(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    return count;
}

string[] NewArray(string[] array, int size)
{
    string[] newArray = new string[size];
    int newIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[newIndex] = array[i];
            newIndex++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
}

string[] array = GetArray("Введите произвольные значения через пробел");
Console.WriteLine();
PrintArray(array);
int size = ArraySize(array);
string[] newArray = NewArray(array, size);
PrintArray(newArray);




