namespace Searchalgorithm;

public class Searchalgorithm
{
    // Linear Search for integer type 
    public int LinearSearch(int[] arr, int num)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            // Number is found then return index
                return i;
        }
        // Number is not in array then return -1
        return -1;  
    }

    // linear search for string type
    public  int LinearSearch(String[] arr, String num)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            // Number is found then return index
            if (arr[i].Equals(num))
            // Number is not in array then return -1
                return i;
        }
        return -1; 
    }

    // Binary search 
    public int BinarySearch(int[] arr, int num)
    {
        int left = 0, right = arr.Length - 1;

        // Middle position
        int mid = (left + right) / 2;

        while (left < right)
        { 
        //  num found return index
            if (arr[mid] == num)
                return mid;
            else if (num < arr[mid])
                right = mid;
            else
                left = mid + 1;
        }
        return -1; // Not found then return -1
    }

    //Binary search of String type 
    public int BinarySearch(String[] arr, String str)
    {
        int left = 0, right = arr.Length - 1;
        int mid = (left + right) / 2;

        while (left < right)
        {
            if (arr[mid].Equals(str))
                return mid;
            else if (str.CompareTo(arr[mid]) < 0)
                right = mid;
            else
                left = mid + 1;
        }
        return -1;
    }

}
