//Урок 4. Функции

// 1. Ввод N  int <- (string)
int GetVal(string text)
{
Console.Write("Введите числo:");
return Convert.ToInt32(Console.ReadLine());
}

// 2 .Создание массива
int[] CreateArray(int size)
{
int[] array = new int[size];
return array;
}

// 3. Заполнение массива 0 и 1
void FillArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  collection[0] = 1;
  while (index < length)
  {
    collection[index] = new Random().Next(0, 1);
    index++;
  }
}


//4/ Печать массива

void PrintArray(int[] col)
{
 int count = col.Length;

 for (int i = 0; i < count; i++)
 {
    Console.Write($"{col[i]}");
 }
 Console.WriteLine();
}
//5 конвертация из 2 в 10

int Binarr(int[] arrBin)
{
     int count = arrBin.Length;
     int exponent = arrBin.Length - 1;
     int result = 0;
     for (int i = 0; i < arrBin.Length; i++)
     {
         if (arrBin[i] == 1)
         {
            result += Convert.ToInt32(Math.Pow(2, exponent));
         }
         exponent--;
     }
     return result;
}    


PrintArray(array);
FillArray(array);
PrintArray(array);


















