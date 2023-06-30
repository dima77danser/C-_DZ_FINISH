// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив 
// из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



Console.WriteLine("введите 1 строку:");
string a1 = Convert.ToString(Console.ReadLine());
Console.WriteLine("введите 2 строку:");
string a2 = Convert.ToString(Console.ReadLine());
Console.WriteLine("введите 3 строку:");
string a3 = Convert.ToString(Console.ReadLine());
Console.WriteLine("введите 4 строку:");
string a4 = Convert.ToString(Console.ReadLine());
Console.WriteLine("введите 5 строку:");
string a5 = Convert.ToString(Console.ReadLine());

string [] array = { a1 ,a2, a3,a4,a5}; 

void Print()
{
for (int i =0; i<array.Length; i++) 
  {   
   Console.Write($"({array[i]})"+","); 
  }
  Console.WriteLine();
}

void NewArray ()
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    
    string s = array[i];
    int len = s.Length;
     if ((len <3)||(len==3))
    {
        Console.Write($"({array[i]})"+",");
    } 
    else 
    {
      count++;
      if (count ==5) 
      {
      Console.WriteLine("таких чисел в массиве нет");
      }
    }
  } 
  Console.WriteLine();
}
Console.WriteLine();
Print();
Console.WriteLine("новый массив из строк, длина которых меньше, либо равна 3 символам: ");
NewArray();