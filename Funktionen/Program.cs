using System;

namespace Funktionen
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            int number = 0;


            Console.Write("how many numbers?" );
            count = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[count];

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Input:");
                ArrayInput(array, i);
                
            }

            PrintArray(array);

            PrintMenu();
            number = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (number)
                {
                    case 1:
                        SortArray(array);
                        PrintArray(array);
                        break;
                    case 2:
                        SmallestNumber(array);
                        break;
                    case 3:
                        BiggestNumber(array);
                        break;
                    case 4:
                        float mean = MeanNumber(array);
                        Console.WriteLine("Mean number = {0} ", mean);
                        PressEnter();
                        break;
                    case 5:                      
                        double median = Median(array);
                        Console.WriteLine("Median number = {0} ", median);
                        PressEnter();
                        break;

                    case 6:
                        Console.WriteLine("Good Buy!");
                        PressEnter();
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                PrintMenu();
                number = Convert.ToInt32(Console.ReadLine());

            } while (number != 6);
        }


        public static void PrintMenu()
        {
            Console.WriteLine(
                "Menu \n" +
                "---------------\n" +
                "1  Sort Array \n" +
                "2  Smallest number \n" +
                "3  Biggest number \n" +
                "4  Mean number \n" +
                "5  Median\n" +
                "6  Exit");
        }


        public static int ArrayInput(int[] array, int i)
        {
            int value = 0;
            value = Convert.ToInt32(Console.ReadLine());
            array[i] = value;

            return array[i];
        }


        public static void SortArray(int[] arr)
        {
            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
               
            }
        }

        public static void SmallestNumber(int[] arr)
        {
            int min = arr[0];

            for( int i = 0; i < arr.Length; i++)
            {
                if( arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("Smallest Number = " + min);
            PressEnter();
        }


        public static void BiggestNumber(int[] arr)
        {
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine("Smallest Number = " + max);
            PressEnter();
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(" {0}): {1} ", i + 1, array[i]);

            }
        }

        public static void PressEnter()
        {
            Console.WriteLine("Press Enter!");
        }


        public static int MeanNumber(int[] arr)
        {
            int arrLength = arr.Length;
            int arrSumm = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                arrSumm += arr[i];
            }

            return arrSumm / arrLength;

        }

        public static int Median(int[] arr)
        {
            SortArray(arr);

            int arrLength = arr.Length;

            if(arrLength % 2 == 0)
            {
                 int number = arrLength / 2;

               return (arr[number] + arr[number - 1]) / 2;
            }
            else
            {
                return arr[arrLength  / 2]; 
            }      

        }

    }
}
