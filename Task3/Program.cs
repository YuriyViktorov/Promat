
// Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'. Определите, является ли ваша строка допустимой.
// Любую открывающуюся скобку можно добавить в стэк без проверок,
// для каждой закрывающейся скобки надо проверить не пустой ли стэк, чтобы не получить ошибки при извлечении
// и проверить лежит ли сверху стэка соответствующая ей открывающая.
// В конце проверить стэк на пустоту, чтобы убедиться, что не осталось открытых скобок.


// Метод
bool CheckBrackets(string str)
{
    Console.Write("*");
    Console.Write(str);
    Console.WriteLine("*");
    Console.Write("Результат: ");

    Stack<char> brackets = new Stack<char>();

    foreach (char sym in str)
    {
        switch (sym)
        {
            case '(' or '{' or '[':
                brackets.Push(sym);
                break;
            case ']':
                if (brackets.Count == 0) return false;
                if (brackets.Pop() != '[') return false;
                break;
            case ')':
                if (brackets.Count == 0) return false;
                if (brackets.Pop() != '(') return false;
                break;
            case '}':
                if (brackets.Count == 0) return false;
                if (brackets.Pop() != '{') return false;         
                break;
            default:
                break;
        }
    }
    if (brackets.Count > 0) return false;
    return true;
}

// Основной код программы

Console.Clear();

string testStr = "()";
Console.WriteLine("Пример 1:");
Console.Write("Входная строка: s =");
Console.WriteLine(CheckBrackets(testStr));
Console.WriteLine();

testStr = "()[]{}";
Console.WriteLine("Пример 2:");
Console.Write("Входная строка: s =");
Console.WriteLine(CheckBrackets(testStr));
Console.WriteLine();

testStr = "(]";
Console.WriteLine("Пример 3:");
Console.Write("Входная строка: s =");
Console.WriteLine(CheckBrackets(testStr));
Console.WriteLine();

testStr = "()[]{()}";
Console.WriteLine("Пример 4:");
Console.Write("Входная строка: s =");
Console.WriteLine(CheckBrackets(testStr));
Console.WriteLine();

testStr = "(a)aa";
Console.WriteLine("Пример 5:");
Console.Write("Входная строка: s =");
Console.WriteLine(CheckBrackets(testStr));
Console.WriteLine();

