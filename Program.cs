// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
// задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше 
// обойтись исключительно массивами.

string[] PullArray(string[] array) { // Функция создана для самостоятельного ввода переменных в массив пользователем.
    for(int i = 0; i < array.Length; i++) {
        Console.Write($"Напишите {i + 1} имя для массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

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

void ArrayFromCondition(string[] array) { // Функция выводит новый массив в соответствии с условием задачи.
    int count = CountOfSymbols(array);
    int j = 0;
    string[] desiredArray = new string[count];
    for(int i = 0; i < array.Length; i++) {
        if(array[i].Length < 4) {
            desiredArray[j] = array[i];
            j++;
        }
    }
    PrintArray(desiredArray);
}

var rnd = new Random().Next(2, 6);
string[] array = new string[rnd];
PullArray(array);
PrintArray(array);
Console.Write(" → ");
ArrayFromCondition(array);
