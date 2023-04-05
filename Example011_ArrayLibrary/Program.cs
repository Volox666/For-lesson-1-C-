void FullArray(int[] collection) // Заполняет массив случайными числами
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)  // Выводит массив в консоль
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // Ищет индекс эллемента с заданным значением
{
    int count = collection.Length;
    int index = 0;
    int position =-1;  // Если выводит -1 значит такого эллемента нет в массиве
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int[] array = new int[10];   // Создание нового массива с 10 элементами

FullArray(array);
PrintArray(array);
System.Console.WriteLine();

int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);
