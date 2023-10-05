/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма,
При решении не рекомендуется использовать коллекции, лучше обойтись массивами.*/

string[] FiltrStrings(string[] array1)
{
    int count = 0;
 for(int i = 0; i < array1.Length; i++)
 {
    if(array1[i].Length <= 3) count++;
 }

string[] array2 = new string[count];
int index = 0;

for(int i = 0; i < array1.Length; i++)
{
    if(array1[i].Length <= 3)
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
        if (i < arr.Length - 1) Console.WriteLine($"{arr[i]}");
        else Console.WriteLine($"{arr[i]}!");
    }
}