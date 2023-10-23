# Программа для вывода из имеющего массива новый массив, длина элементов которого не превышает три символа.
## Получение начального массива
Для получения начального массива используется метод **GetArray**, который считывает введенные пользователем через пробел значения и преобразовывает их в текстовый массив.
```
string[] GetArray(string message)
{
    Console.Write($"{message}: ");
    string text = Console.ReadLine()!;
    string[] array = text.Split(new char[] {' '});
    return array;
}
```

## Создание нового массива
Так как размер нового массива неизвестен, то с помощью метода **ArraySize** сначала узнаем его размер. Далее в методе **NewArray** мы выбираем элементы длиной меньше четырех символов и записываем их в новый массив.
```
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
```
## Печать массивов
Для визуализации данных используется метод **PrintArray**, который печатает начальный и конечный массив в заданном формате.
```
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
```