// вид 1 ничего не принимают и ничего не возвращают
void Meythod1()
{
    Console.WriteLine("Автор я");
}
Meythod1(); // Вызов метода скобки обязательно


// Вид 2

// Это методы, которые ничего не возвращают, но в то же время могут принимать какие-то аргументы
void Method2(string msg)  // где void ключевое слово, дальше идентификатор, в скобках указаны какие-то аргументы.
{
    Console.WriteLine(msg);  // оператор, в скобках указан принятый аргумент.
}

Method2("text");

// Вид 2_1 Именованные аргументы

// Отмечу, что ещё есть так называемые именованные аргументы, когда у нас явно может быть
// указано какому аргументу, какое значение мы хотим указать. Это часто бывает нужно, если
// методы принимают какое-то количество аргументов, отличное от 1

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg); // где переменная count отображает на экране определённое количество сообщений msg.
        i++;
    }
}

Method21("text 22", 4);     //метод вызывает text 22, после запятой указано количество вызовов, в нашем случае 4.

// Теперь идея в том, что мы можем в том числе явно указывать к какому аргументу, какое
// значение мы хотим присвоить, через такую конструкцию.
// Было: Metod21(“Текст”, 4);
// Стало: Metod21(msg: “Текст”, count: 4);
// Явно указывая наименование аргумента, не обязательно писать их по порядку.
// Metod21(count: 4, msg: “Текст”);
// Это тоже особенность, то есть можно, например, написать count: 4, дальше написать msg:
// Новый текст

// Вид 3

// Эти методы, которые что-то возвращают, но ничего не принимают. Если метод что-то
// возвращает, мы в обязательном порядке должны указать тип данных, значение которого
// ожидаем

int Method3() // не принимает никакие аргументы
{
    return 12; // DataTime.Now.Year; // обязательное использование оператора return,
}
int year = Method3();      // вызываем метод, в левой части используем идентификатор
                           //переменной (year) и через оператор присваивания (=) кладём нужное значение
Console.WriteLine(year);


// Вид 4  методы, которые что-то принимают и что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);


string Method41(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++) // вначале ключевое слово, затем инициализация
                                    //счётчика, после проверка условия и инкремент (увеличение счётчика).
    {
        result = result + text;
    }
    return result;
}
string res1 = Method41(10, "fds");
Console.WriteLine(res);


// Таблица умножения
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}





//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
 + "ежели бы вас послали вместо нашего милого Винценгероде,"
 + "вы бы взяли приступом согласие прусского короля."
 + "Вы так красноречивы. Вы дадите мне чаю?";

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result;
}
string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);
newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
newText = Replase(newText, 'С', 'с');
Console.WriteLine(newText);


// На самом деле мы сами указали достаточно много действий, но в то же время они могут быть
// выражены тремя пунктами.
// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3. Повторять пока есть неотсортированные элементы.

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}" + " ");
    }
    Console.WriteLine();
}



void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) 
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
    array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
selectionSort(arr);
PrintArray(arr);








