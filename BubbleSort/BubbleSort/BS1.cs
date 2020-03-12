using System;
namespace BubbleSortNoFunc
{
    public class BubbleSortNoFunc
    {
        static int[] numbers = new int[100];
        static void InitArray()
        {
            int i;
            for (i = 0; i <= 99; i++)
            {

                numbers[i] = 100 - i;
            }
        }
        static void DispArray()
        {
            int i;
            Console.WriteLine("Initial array contents are:");
            for (i = 0; i <= 99; i++)
            {
                Console.Write(Convert.ToString(numbers[i]) + " ");
            }
            Console.WriteLine();
        }
        static void BubbleSort()
        {
            int current = 99;
            int i;
            bool swapped;
            do
            {
                swapped = false;
                for (i = 0; i <= current - 1; i += 1)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        swapped = Swap(i, swapped);
                    }
                }
                current = current - 1;
            }
            while (!(swapped == false));
        }
        static bool Swap(int i, bool swapped)
        {
            int temp;
            temp = numbers[i];
            numbers[i] = numbers[i + 1];
            numbers[i + 1] = temp;
            swapped = true;
            return swapped;
        }
        public static void Main(string[] args)
        {
            InitArray();
            DispArray();
            BubbleSort();
            DispArray();
        }
    }
}