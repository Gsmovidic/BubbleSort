using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    interface ICollectionSorter
    {
        string[] SortAscending(int[] numbers);

        string[] SortDescending(int[] numbers);

    }
}
