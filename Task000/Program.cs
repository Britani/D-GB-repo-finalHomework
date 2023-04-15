// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Зададим длинну будущего массива");
int size = Convert.ToInt32(Console.ReadLine());
string[] collection = new string[size];
FillArray(collection);
PrintArrey(collection);
int newSize = NewArraySize(collection);
string[] newCollection = new string [newSize];
CreateNewArray(collection, newCollection);
Console.Write(" -> ");
PrintArrey(newCollection);

void FillArray(string[] coll)
{
    int length = coll.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine($"Введите элемент номер {index+1}");
        coll[index] = Console.ReadLine();
        index++;
    }
}

void PrintArrey(string[] col)

{
    Console.Write("[");
    int count = col.Length;

    int position = 0;

    while (position < count - 1)

    {
        Console.Write($"\"{col[position]}\" ,");
        position++;
    }
    if (position == count - 1)
    {
        Console.Write($"\"{col[position]}\" ");
    }
    Console.Write("]");
}


int NewArraySize(string[] col)
{
    int count = 0;
    for (int i = 0; i < col.Length; i++)
    {
        //int length = col[i].Length;
        if (col[i].Length <= 3)//int length = str.Length;
        {
            count ++;
        }
    }
    return count;
}

void CreateNewArray(string[] col,string[] newCol)
{
    int index = 0;
   for (int i = 0; i < col.Length; i++)
   {
      if (col[i].Length<=3)
      {
        newCol[index]=col[i];
        index++;
        
      }
    }
}


