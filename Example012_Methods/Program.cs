﻿// Вид 1
void Method1()
{
    Console.WriteLine(" Автор ...");
}
//Method1();


//  Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg "Текст", count 4);
// Method21(count: 4, msg: "новый текст");


// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
// Console.WriteLine(year);

// Вид 4

// string Method4 (int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

 string Method4 (int count, string text)
 {
     string result = String.Empty;
    for(int i = 0; i < count; i++)
     {
        result = result + text; 
     }
     return result;
 }

string res = Method4(10, "asdf ");
Console.WriteLine(res);



// Таблица умножения как пример цикла в цикле

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

// Сортировка массива по порядку

int [] arr = {1, 5, 7, 8, 9, 3, 4, 1, 2, 5};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");   
    }
    Console.WriteLine();
}

PrintArray(arr);


