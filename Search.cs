
namespace Searchalgorithm;

internal class Search
{
    static void Main(string[] args)
    {

        int result = -1;
        Console.WriteLine("What Do you want ");
        Console.WriteLine("press 1 for Seaching operation on integer array");
        Console.WriteLine("press 2 for Sorting operation on String array ");
        int choice = Console.Read();
        Searchalgorithm Search = new Searchalgorithm();
        switch (choice)
        {
            case 1:
         
                Console.WriteLine("Enter size of integer Array //change made by prem sawant");
                int size = System.Int32.Parse(Console.ReadLine());
                int[] arr = new int[size];

                Console.WriteLine(" Enter An Element of array ");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(" Enter the " + i + " Element of array");
                    arr[i] = System.Int32.Parse(Console.ReadLine());
                }
    
                Console.WriteLine("Enter your choice of search :");
                Console.WriteLine("1 for Linear Search");
                Console.WriteLine("2 for Binary Search");
                int searchoption = System.Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter the num that you want to seach ");
                int num = System.Int32.Parse(Console.ReadLine());

                switch (searchoption)
                {
                    case 1:
                        result = Search.LinearSearch(arr, num);
                        break;
                    case 2:
                        result = Search.BinarySearch(arr, num);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
                break;

            case 2:
            Console.WriteLine("Enter size of string Array");
                int strsize = System.Int32.Parse(Console.ReadLine());
                string[] strarr = new string [strsize];

                Console.WriteLine(" Enter An Element of array ");
                for (int i = 0; i < strsize; i++)
                {
                    Console.WriteLine(" Enter the " + i + " Element of array");
                    strarr[i] = Console.ReadLine();
                }
    
                Console.WriteLine("Enter your choice of search :");
                Console.WriteLine("1 for Linear Search");
                Console.WriteLine("2 for Binary Search");
                int strsearchoption = System.Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter the  that you want to search ");
                string str = Console.ReadLine();

                // Searchalgorithm Search = new Searchalgorithm();
                switch (strsearchoption)
                {
                    case 1:
                        result = Search.LinearSearch(strarr, str);
                        break;
                    case 2:
                        result = Search.BinarySearch(strarr, str);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
                break;    
           default:
           Console.WriteLine("Invalid choice!!!");
           break;
        }
    }
}
