/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма,
При решении не рекомендуется использовать коллекции, лучше обойтись массивами.*/

string[] FiltrStrings(string[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3) count++;
    }

    if (count < 1) Console.Write("В массиве нет строк с заланным условием");
    else Console.WriteLine("Результат собран из строк по три и менее символов: ");

    string[] array2 = new string[count];
    int index = 0;

    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[index] = array1[i];
            index++;
        }
    }
    return array2;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

// Console.Write("Введите элементы массива через пробел: ");
// string[] array1 = Console.ReadLine().Split();

string[] array1 = { "Привет", "Я", "Ты", "Он", "Она", "Мы", "целая", "страна", "Пока", "гуд" };
// string[] array1 = {"Привет", "целая", "страна", "Пока"};
string[] array2 = FiltrStrings(array1);

PrintArray(array2);