﻿


//Time complexity - O(n), где n это количество элементов входного массива и мы итерируем по массиву 1 раз
//Space complexity - 0(n), так как мы создаем новый массив для хранения уникальных элементов
class Program
{
    static void RemoveDuplicates(int[] arr)
    {

        var outarr = new int[arr.Length]; // создаем новый массив куда будем сохранять элементы, т.к. нельзя модифицировать изначальный массив
        int j = 0; // индекс уникального элемента

        for (int i = 0; i < arr.Length - 1; i++) // итерируем до предпоследнего элемента, так как последний элемент не с чем будет сравнить
        {
            if (arr[i] != arr[i + 1]) // сравниваем с соседним элементом на уникальность
            {
                outarr[j++] = arr[i]; //если элемент уникален то добавляем его в наш новый массив и увеличиваем счетчик для следующей итерации
            }
        }

        // Так как итерируем до предпоследнего элемента, последний элемент начального массива не попадет в новый массив
        // то добавляем его сами и увеличиваем счетчик после добавления для того чтобы потом изменить размер массива
        // Если не увеличим счетчик, то наш последний элемент тоже срежется
        outarr[j++] = arr[arr.Length - 1];

        // Ресайзим массив для того чтобы избавиться от нуля в конце массива
        Array.Resize(ref outarr, j);

        //Выводим массив с уникальными значениями
        foreach (int i in outarr)
            Console.Write(i + " ");
    }

    public static void Main(string[] args)
    {
        var arr = new int[] {1, 2, 3, 4, 4,56};
        RemoveDuplicates(arr);
    }
}