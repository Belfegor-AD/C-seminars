// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


int[] CreateArray(int size, int begin, int end){
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(begin, end);
    }
    return array;
}

int[] Flipping(int[] arr, int i){
    if (i <= arr.Length/2){
        int j = arr.Length - 1 - i;
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
        i++;
        return Flipping(arr, i);
    }
    return arr;
}


void PrintArray(int[] arr){
    foreach (int item in arr){
        Console.Write(item + " ");
    }
    Console.WriteLine();
}


Console.Clear();
int[] array = CreateArray(9, 0, 20); //Создание массива из 10 значений в диапазоне [0,20]
Console.Write("Изначальный массив чисел: ");
PrintArray(array);
int i = 0;
Flipping(array, i);
Console.Write("Перевёрнутый массив чисел: ");
PrintArray(array);
