{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int arrSize = Convert.ToInt32(Console.ReadLine());

            var myArray = CreateArray(arrSize);

            Console.WriteLine($"Массив: {string.Join(", ", myArray)}");

            string binLine = string.Join("", myArray);

            Console.WriteLine($"{binLine} переводим в десятичное: {ToDec(binLine)}");

            Console.ReadLine();
        }

        static int[] CreateArray(int arrSize)
        {
            Random rnd = new Random(); 

            int[] myArray = new int[arrSize];

            myArray[0] = 1; 

            for (int i = 1; i < arrSize; i++)
            {
                myArray[i] = rnd.Next(0, 2);
            }

            return myArray;
        }

        public static int ToDec(string bin)
        {
            var result = 0;
            for (int i = 0; i < bin.Length; ++i)
            {
                if (bin[bin.Length - i - 1] == '1')
                {
                    result += (int)Math.Pow(2, i);
                }
            }
            return result;
        }

    }
}
