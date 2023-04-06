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

       void FillArray(string[] coll)
       {
           int length = coll.Length;
           int index = 0;
           while (index < length)
           {
               Console.WriteLine($"Введите элемент с индексом {index}");
               coll[index] = Console.ReadLine();//new Random().Next(1, 10);
               index++;
           }
       }

       void PrintArrey(string[] col)

       {

         int count = col.Length;

         int position = 0;

         while (position < count)

         {
             Console.Write(col[position]);
             position++;
         }
       }  