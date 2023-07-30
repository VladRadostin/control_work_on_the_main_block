// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    string result = Convert.ToString(value);
    return result;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    { 
        Console.Write($"{array[i]} "); 
    }
    Console.WriteLine();
}

void FillingInTheSecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3 & array1[i] != string.Empty)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void filltArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    { 
        array[i] = Prompt("Введите значения ");
    }
    Console.WriteLine();
}

string[] Mass1 = new string[5];
string[] Mass2 = new string[5];

filltArray(Mass1);
PrintArray(Mass1);
FillingInTheSecondArray(Mass1,Mass2);
PrintArray(Mass2);
