// Дан одномерный массив целых однозначных чисел (элемент массива содержит число от 1 до 9).
//Ваша задача вывести на экран число, которое формируется элементами массива слева-направо + 1

// Метод
int ParseArrayByStdMethod(int[] array)
{
    string str = string.Join("", array);
    Console.Write("[");
    Console.Write(str);
    Console.WriteLine("]");
    Console.Write("Число: ");
    return int.Parse(str);
    
}


// Основной код программы

Console.Clear();

Console.WriteLine("Пример 1:");
int[] test1 = {1,2,1,1,4};
Console.Write("Исходный массив: ");
Console.WriteLine(ParseArrayByStdMethod(test1)+1);
Console.WriteLine();

Console.WriteLine("Пример 2:");
int[] test2 = {1,1,2,9};
Console.Write("Исходный массив: ");
Console.WriteLine(ParseArrayByStdMethod(test2)+1);
Console.WriteLine();

Console.WriteLine("Пример 3:");
int[] test3 = {9};
Console.Write("Исходный массив: ");
Console.WriteLine(ParseArrayByStdMethod(test3)+1);
Console.WriteLine();


