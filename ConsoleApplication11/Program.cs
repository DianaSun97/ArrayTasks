using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Messaging;

namespace ConsoleApplication11
{
    internal class Program
    {
        public static void Main(string[] args)
        {   //Task1
            Task1(3, 1, 10);

            //Task2
            Console.WriteLine("task 2, test 1 (True ): " + Task2(new int[] {10, 9, 7, 5}, new int[] {10, 9, 7, 5}));
            Console.WriteLine("task 2, test 2 (False): " + Task2(new int[] {11, 9, 7, 5}, new int[] {10, 9, 7, 5}));
            Console.WriteLine("task 2, test 3 (False): " + Task2(new int[] {10, 10, 7, 5}, new int[] {10, 9, 7, 5}));
            //Console.WriteLine("task 2, test 4 (False): " + Task2(new int[] {10, 9, 7}, new int[] {10, 9, 7, 5}));
            //Console.WriteLine("task 2, test 5 (False): " + Task2(new int[] {10, 9, 7, 5}, new int[] {10, 9, 7}));
            
            Console.WriteLine(Task3());
            
            //Task4
            Task4(new int []{1,3,4,6});
            
            //Task5
            Console.WriteLine(Task5(new int[]{1,2,3,4}));
            
            //Task6
            Console.WriteLine(Task6(5,18));
            
            //Task7
            Console.WriteLine(Task7(4,5));
            
            //Task8
            Console.WriteLine(Task8(2,3));
            Console.WriteLine(Task8(2.1,8.2));
          
            Task9();
            Task10();
            
            //Домашнее задание
            Task11();
            
            


        }

        public static char[] Task1(int myLength, int min, int max)
        {
            //1. Написать метод для создания char массива и заполнения его случайными значениями, с возможностью передачи в метод желаемой длины,
            //а также минимума и максимума для заполнения
            Random rnd = new Random();
            char[] arr = new char[myLength];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (char)rnd.Next(min, max);
            }

            return arr;
        }
        
        public static bool Task2(int[] a,int[] b)
        {
            //2. Написать метод для сравнения двух одномерных целочисленных массива, в случае одинаковых массивов вернуть true
            bool c=true;
            for (int i = 0; i < a.Length;  i++)
            {
                
                        if (a[i] != b[i])
                            {
                               c = false;
                                break;
                             }
                             else //(a[i] == b[j])
                             {
                                 c = true; 
                             }
                
            
            }

            return c;

        }
        
        public static bool Task3()
        {
            //3. Написать метод для генерации случайного boolean значения
            Random rnd = new Random();
            bool a = false;
            a=rnd.Next(2) == 0 ? false : true;
            return a;
        }
        
        public static int Task4(int[]a)
        {
            //4. Написать метод для поиска максимального значения в целочисленном массиве
            
            int max=a[0];
            for (int i = 0; i < a.Length; i++)
            {
                max = Math.Max(max, a[i]);
            }

            return max;
        }
        
        public static int[] Task5(int[] a)
        {
            //5. Написать метод, задачей которого является реверс значений в массиве
            // int[]  = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[b.Length - i - 1] = a[i];
           }

            return b;
        }
        

        public static int Task6(int ar1, int ar2)
        {
            //6. Написать метод для генерации случайного четного целого цисла в заданных пределах
            Random random = new Random();
            int number = 0;
            do
            {
                number = random.Next(ar1,ar2);
            }
            while(number % 2 != 0);
            return number;
            
        }
        
        public static double Task7(int ar1, int ar2)
        {
            //7. Написать метод, задачей которого является вычисление площади прямоугольника по двум сторонам
            int a = ar1;
            int b = ar2;
            int S;
            
            return S = a * b;
        }
        
        public static int Task8(int arg0,int arg1)
        {
            //8. Перегрузить первый метод для расчета площади квадрата. 

            int a=arg0;
            int b=arg1;
            int S;
            
           return S = a * b;
        }
        
        public static double Task8(double arg0,double arg1)
        {
            //8. Перегрузить первый метод для расчета площади квадрата. 

            double a=arg0;
            double b=arg1;
            double S;
            
            return S = a * b;
        }
        
        public static void Task9()
        {
            //9. Реализовать метод, задачей которого является обрезка массива до указанной длины
            //int[] arr = new int[myLength];
        }

        public static void Task10()
        {
            //10. Метод для проверка чарового массива на наличие только буквенных символов
            
        }

        public static void Task11()
        {
            int[] arrInt = getArr(50, 1, 100);
            printArr(arrInt);
            Console.WriteLine("----"+arrInt.GetHashCode()+"----");

            //min-max
            int min=arrInt[0];
            int max=arrInt[0];
            for (int i = 0; i < arrInt.Length; i++)
            {
                min = Math.Min(min, arrInt[i]);
                max=Math.Max(max,arrInt[i]);
            }
            
            int[] asdf = getArr(arrInt, 2);
            printArr(asdf);
            
            Console.WriteLine("----"+arrInt.GetHashCode()+"----");
            Console.WriteLine(min);
            Console.WriteLine(max);
            
        }
        
        public static int[] getArr(int myLength, int min, int max)
        {
            Random rnd = new Random();
            int[] arr = new int[myLength];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(min, max + 1);
            }
            Console.WriteLine("----"+arr.GetHashCode()+"----");
            return arr;
        }

        public static void printArr(int[] qwerty)
        {
            foreach (int value in qwerty)
            {
                Console.Write(value+" ");
            }
            Console.WriteLine();
        }

        public static int[] getArr(int[] arr, int x)
        {
            int counter = 0;
            foreach (int value in arr)
            {
                if (value % x != 0)
                {
                    counter++;
                }
            }

            int[] newArr = new int[counter];
            counter = 0;
            foreach (int value in arr)
            {
                if (value % x != 0)
                {
                    newArr[counter++] = value;
                }
            }

            return newArr;
        }
       
    
}

    }
