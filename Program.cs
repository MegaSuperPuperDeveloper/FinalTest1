// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
// задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше 
// обойтись исключительно массивами.

void PrintArray(string[] array) { // Функция выводит массив.
    Console.Write("[");
    for(int i = 0; i < array.Length; i++) {
        Console.Write('"' + $"{array[i]}");
        if(i == array.Length - 1) Console.Write('"');
        else Console.Write('"' + ", ");
    }
    Console.Write("]");
}

int CountOfSymbols(string[] array) { // Функция считает количество переменных в массиве у которых меньше 4 символов.
    int count = 0;
    for(int i = 0; i < array.Length; i++) {
        if(array[i].Length < 4) count++;
    }
    return count;
}

string[] array = new string[] {"Moscos", "Hi", "Bye", "Kazan"};
Console.WriteLine(CountOfSymbols(array));