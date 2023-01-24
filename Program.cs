// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.WriteLine("Укажите количество строк");
int num = int.Parse(Console.ReadLine()!);
string[] arr = UserFillArray(num);
Console.WriteLine();
PrintArray(arr);
Console.WriteLine();
int count = CountStringsNewArray(arr);
if (count > 0)
{
    string[] arrNew = FillArrayNew(arr, count);
    PrintArray(arrNew);
}
else Console.WriteLine("Нет строк, длина которых меньше либо равна 3 символам");


string[] UserFillArray(int number)
{
    string[] array = new string[number];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите строку");
        array[i] = Console.ReadLine()!;
    }
    return array;

}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int CountStringsNewArray(string[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) counter++;
    }
    return counter;
}

string[] FillArrayNew(string[] array, int counter)
{
    string[] arrayNew = new string[counter];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            arrayNew[j] = array[i];
            j++;
        }
    }
    return arrayNew;
}

