namespace Domashna_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { -3, 5, 1, 9, -12, 4, 6, -2, 0 };

            Console.WriteLine("old list:");
            PrintList(numbers);
            Console.WriteLine();

            SortList(numbers);
            Console.WriteLine("sorted list:");
            PrintList(numbers);
            Console.WriteLine();

            FilterList(numbers);
            Console.WriteLine("list without negative odd values: ");
            PrintList(numbers);
        }

        //InsertionSort
        static void SortList(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                int key = list[i];
                int j = i - 1;
                while (j >= 0 && list[j] > key)
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }
                list[j + 1] = key;
            }
        }

        //static void FilterList(List<int> list)
        //{
        //    for (int i = 1; list.Count > i; i++)
        //    {
        //        if (list[i] < 0 && list[i] % 2 != 0)
        //        {
        //            list.RemoveAt(i);
        //        }
        //    }
        //}
        static void FilterList(List<int> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)  
            {
                if (list[i] < 0 && list[i] % 2 != 0)
                {
                    list.RemoveAt(i);  
                }
            }
        }

        static void PrintList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
}