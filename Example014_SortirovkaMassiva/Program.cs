// Сортировка массива по порядку

int [] arr = {1, 5, 7, 8, 9, 3, 4, 1, 2, 5};

void PrintArray(int[] array)  // Метод(функция) для печати массива
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");   
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)  // Упорядочивание массива
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i];                    // Замена местами элементов массива
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);



