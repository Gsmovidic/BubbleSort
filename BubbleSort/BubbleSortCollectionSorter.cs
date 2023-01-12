using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BubbleSort
{
    internal class BubbleSortCollectionSorter : ICollectionSorter
    {
        private string[] numbersString = {"Zero","One", "Two","Three" , "Four", "Five", "Six" ,"Seven," , "Eight" ,"Nine" };

        public string[] SortAscending(int[] numbers)
        {
            int aux;
            bool swapped;
            int swaps = 0;
            int max = numbers.Length;
            while (true)
            {
                swapped = false;
                for (int i = 0; i < numbers.Length; i += 1)
                {

                    if (i>0) {
                        if (numbers[i - 1] > numbers[i])
                        {
                            aux = numbers[i];
                            numbers[i] = numbers[i - 1];
                            numbers[i - 1] = aux;
                            swapped = true;
                            swaps += 1;
                        }
                    }

                }
                max -= 1;
                if (!swapped)
                    break;
                if (max == 0)
                    throw  new InvalidOperationException("This can't be perfomed more times ");
            }
            Console.WriteLine($"Number of swaps " + swaps.ToString());
            return ChangeToWords(numbers.Select(x => x.ToString()).ToArray()); 
        }

        public string[] SortDescending(int[] numbers)
        {
            int aux;
            bool swapped;
            int swaps = 0;
            int max = numbers.Length;
            while (true)
            {
                swapped = false;
                for (int i = 0; i < numbers.Length; i += 1)
                {
                    if (i>0) {
                        if (numbers[i] > numbers[i - 1])
                        {
                            aux = numbers[i];
                            numbers[i] = numbers[i - 1];
                            numbers[i - 1] = aux;
                            swapped = true;
                            swaps += 1;
                        }
                    }

                }
                max -= 1;
                if (!swapped)
                    break;
                if (max == 0)
                    throw new InvalidOperationException("This can't be perfomed more times ");
            }
            Console.WriteLine($"Number of swaps " + swaps.ToString());
            return ChangeToWords(numbers.Select(x => x.ToString()).ToArray());
        }

        private string[] ChangeToWords(string[] numbers ) 
        {
            for (int i=0; i<numbers.Length;i+=1)
            {
                int var = int.Parse(numbers[i]);
                switch (var)
                {
                    case 0:
                        numbers[i] = "ZeRo";
                    break;

                    case int n when (n >= 1 && n <= 9):
                        if (var % 2 == 0)
                        {
                            numbers[i] = ConvertNumber(Convert.ToDouble(var)).ToLower();
                        }
                        else
                        {
                            numbers[i] = ConvertNumber(Convert.ToDouble(var)).ToUpper();
                        }
                    break;
                }
            }
            return numbers;
        }
        //These two following methods are from internet, source: https://www.c-sharpcorner.com/blogs/convert-number-to-words-in-c-sharp
        //They are to convert the numbers of the array to words
        private string ConvertNumber(double number) {
            Int64 amount_int = (Int64)number;
            Int64 amount_dec = (Int64)Math.Round((number - (double)(amount_int)) * 100);
          
                return ConvertN(amount_int);
        }

        private string ConvertN(Int64 i)
        {
            return numbersString[i];
        }

        
    }
}
