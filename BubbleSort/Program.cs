// See https://aka.ms/new-console-template for more information
using BubbleSort;

Console.WriteLine("Hello, World!");

BubbleSortCollectionSorter b = new BubbleSortCollectionSorter();

int[] n = { 4, 6, 3, 2 };
int[] n2 = {5,4,2,4,1,0 };
string[] c= b.SortAscending(n);
string[] c2 =b.SortDescending(n2);
Console.WriteLine("[{0}]", string.Join(", ", c));
Console.WriteLine("[{0}]", string.Join(", ", c2));



