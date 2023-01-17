//имеется массив, состоящий из n элементов, требуется найти элемент равный find

//int[] Massiv = {1, 2, 4, 5, 6, 7, 8, 9};
//int n = Massiv.Length;  //переменная длина массива
//int find = 6;  //финд 5
//int index = 0;  //
//while (index < n)
//{
  //if (Massiv[index] == find)
  //{
   // Console.WriteLine(index); //показывает индекс
  //}
   // index++;
//}
 // эта же задача метод

void FillArray(int[] collection)    //аргумент коллекция // заполнение массива
{
     int length = collection.Length;   //длина массива
     int index = 0; // переменная 
     while (index < length) //
    {
     collection [index] = new Random().Next(1, 10); // обратиться к аргументу коллек и положить туда число из диап. 1-1
      index++;
    }
}
void PrintArray(int[] col)   //метод, который будет печатать массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
      Console.WriteLine(col[position]);
      position++;
    }
}

   int[] array = new int{10};// создай новый массив эррей из 10 элементов,


 FillArray(array);
 PrintArray(array);
