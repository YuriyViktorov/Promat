// Даны два положительных целых числа, представленных в виде строк. 
//Необходимо получить сумму чисел, которые представлены этими строками. 
//Причем полученная сумма должна быть преобразована в строку.
//Для решения этой задачи запрещено преобразовывать входные строки сразу напрямую в целое число при помощи встроенной функции. 
//Необходимо сделать это самостоятельно.



Console.Clear();

// Методы
int ConvertStringToInt(string str)
{
    int result = 0;
    for(int i = 0; i < str.Length; i++)
    {
        int tmp = str[i] - '0';
        result += tmp * Convert.ToInt32(Math.Pow(10,str.Length-1-i));
    }
    
    Console.Write("num = " + result + " ");
    
    return result;
}

string SummAndConvert(int A, int B)
{
    return Convert.ToString(A + B);
}

// Основной код программы
string a1 = "11";
string b1 = "123";
Console.WriteLine("Пример 1:");
Console.Write("Входные значения: ");
Console.WriteLine("Результат: " + SummAndConvert(ConvertStringToInt(a1),ConvertStringToInt(b1)));
Console.WriteLine();

string a2 = "456";
string b2 = "77";
Console.WriteLine("Пример 2:");
Console.Write("Входные значения: ");
Console.WriteLine("Результат: " + SummAndConvert(ConvertStringToInt(a2),ConvertStringToInt(b2)));
Console.WriteLine();

string a3 = "0";
string b3 = "0";
Console.WriteLine("Пример 3:");
Console.Write("Входные значения: ");
Console.WriteLine("Результат: " + SummAndConvert(ConvertStringToInt(a3),ConvertStringToInt(b3)));
Console.WriteLine();

