//Дан одномерный массив целых чисел, элементом которого, может быть либо 1, либо 0.
//Ваша задача вывести на экран максимальное количество следующих друг за другом 1

// Метод

int CalcOneByOne(int[] array)
{
    int summ1 = 0;
    int maxSumm = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 1)
        {
            summ1++;
        }else
        {
            if (summ1 > maxSumm) maxSumm = summ1;
            summ1 = 0;
        }
    }
    return Math.Max(summ1, maxSumm) > 1 ? Math.Max(summ1, maxSumm) : 0;
}

// Основной код программы

Console.Clear();

Console.WriteLine("Пример 1.");
int[] test1Array = {1, 1, 0, 1, 1, 1};

string str1 = string.Join("", test1Array);

Console.WriteLine($"Исходный массив: [{str1}], максимальное количество единиц подряд: {CalcOneByOne(test1Array)}");
Console.WriteLine();

Console.WriteLine("Пример 2.");
int[] test2Array = {1, 0, 1, 1, 0, 1};

string str2 = string.Join("", test2Array);

Console.WriteLine($"Исходный массив: [{str2}], максимальное количество единиц подряд: {CalcOneByOne(test2Array)}");
Console.WriteLine();

Console.WriteLine("Пример 3.");
int[] test3Array = {1, 0, 1, 0, 0, 0, 1};

string str3 = string.Join("", test3Array);

Console.WriteLine($"Исходный массив: [{str3}], максимальное количество единиц подряд: {CalcOneByOne(test3Array)}");
Console.WriteLine();

Console.WriteLine("Пример 4.");
int[] test4Array = {1, 0, 1, 1, 1, 1, 0};

string str4 = string.Join("", test4Array);

Console.WriteLine($"Исходный массив: [{str4}], максимальное количество единиц подряд: {CalcOneByOne(test4Array)}");
Console.WriteLine();

