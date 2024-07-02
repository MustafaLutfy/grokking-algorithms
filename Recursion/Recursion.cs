using System.Diagnostics;

namespace Recursion;
class Recurtion
{
    public static void naturalNumbers(int n){
        if(n > 50){
           return;
        }
        Console.Write($"{n} ,");
        n++;
        naturalNumbers(n);
    }

    public static int sum(int n){
        if(n == 1){
           return 1;
        }
        return n + sum(n - 1);
    }

    public static int fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return fibonacci(n - 1) + fibonacci(n - 2);
    }
            public static void PrintArray(int[] array,int i)
        {
            if (array.Length==i)
            {
              return ;
            }
            Console.WriteLine(array[i]);
            PrintArray(array,i+1);
        }
        //count the digits of a given number using recursion. 
        public static int DigitNumber(int n,string str) 
        {
            if (str.Length == n)
            {
                return n;
            }
             return  DigitNumber(n+1,str);
        }
        public static int SumDigit(int n, string str)
        {
            if (n>str.Length-1)
            {
                return 0;
            }
            int current= int.Parse(str[n].ToString());
            return current + SumDigit(n+1,str);

        }
        public static int PrintLargElement(int[] array, int i)
        {
            if ( i==0)
            {
                return array[0];
            }
            int Max = PrintLargElement(array, i - 1);
            return array[i] > Max ? array[i]:Max;

            
        }
        public static void ReversString(string str, int i)
        {
            if (i<0)
            {
                return ;
            }

            Console.Write(str[i]);
             ReversString(str, i-1);
        }


    }
