namespace SortMethod;

public class Sort
{

    // Selection Sort
    public void SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                //if(arr[i] < arr[j])
                {
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    
                }
            }
        }

        foreach (int x in arr)
        {
            Console.Write(x + " ");
        }
    }

    // If the first string is lexicographically greater than the second string, it returns a positive number (difference of character value). If the first string is less than the second string lexicographically, it returns a negative number, and if the first string is lexicographically equal to the second string, it returns 0.
    public void SelectionSort(String[] arr)
    {
        int length = arr.Length;
        for (int i = 0; i < length - 1; i++)
        {
            int index = i;
            String smallStr = arr[i];
            for (int j = i + 1; j < length; j++)
            {
                if (arr[j].CompareTo(smallStr) < 0)
                {
                    smallStr = arr[j];
                    index = j;
                }
            }
            //  Swap 
            String t = arr[index];
            arr[index] = arr[i];
            arr[i] = t;
        }

        foreach (string x in arr)
        {
            Console.Write(x + " ");
        }
    }


    public void InsertionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (arr[j] < arr[j - 1])
                {
                    int tmp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = tmp;
                }
                else
                    break;
            }
        }
        foreach (int x in arr)
        {
            Console.Write(x + " ");
        }
    }

    public void InsertionSort(String[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                // string temp = arr[j-1];
                if (arr[j].CompareTo(arr[j - 1]) < 0)
                {
                    String temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;

                }
                else
                    break;
            }
        }
        foreach (string x in arr)
        {
            Console.Write(x + " ");
        }
    }


    // Bubble SortInteger array
    public void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j + 1] < arr[j])
                {
                    int tmp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = tmp;
                }
            }
        }
        foreach (int x in arr)
        {
            Console.Write(x + " "+x);
            
        }
    }

    // Bubble Sort for string array
    public void BubbleSort(String[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {

                if (arr[j + 1].CompareTo(arr[j]) < 0)
                {
                    String tmp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = tmp;
                }
            }
        }
        foreach (string x in arr)
        {
            Console.Write(x + " ");
        }
    }

    // Merge Sort for Integer Array
    public void MergeSort(int[] array, int left, int right)
    {
        if (right == left)
            return;

        int mid = (left + right) / 2;

        MergeSort(array, left, mid);
        MergeSort(array, mid + 1, right);

        int[] temp = new int[right - left + 1];
        int i = left, j = mid + 1, k = 0;
        while (i <= mid && j <= right)
        {
            if (array[i] < array[j])
            {
                temp[k++] = array[i++];
            }
            else
            {
                temp[k++] = array[j++];
            }
        }
        while (i <= mid)
        {
            temp[k++] = array[i++];
        }
        while (j <= right)
        {
            temp[k++] = array[j++];
        }

        for (k = 0; k < temp.Length; k++)
        {
            array[left + k] = temp[k];
        }

    }

    // Merge Sort for String Array 
    public void MergeSort(String[] array, int left, int right)
    {
        if (right == left)
            return;

        int mid = (left + right) / 2;

        MergeSort(array, left, mid);
        MergeSort(array, mid + 1, right);

        String[] temp = new String[right - left + 1];
        int i = left, j = mid + 1, k = 0;
        while (i <= mid && j <= right)
        {
            if (array[i].CompareTo(array[j]) < 0)
            {
                temp[k++] = array[i++];
            }
            else
            {
                temp[k++] = array[j++];
            }
        }

        while (i <= mid)
        {
            temp[k++] = array[i++];
        }
        while (j <= right)
        {
            temp[k++] = array[j++];
        }

        for (k = 0; k < temp.Length; k++)
        {
            array[left + k] = temp[k];
        }
    }

    // Quick Sort for Integer type
    public void QuickSort(int[] array, int left, int right)
    {

        if (left >= right)
            return;

        int temp;
        int i = left;
        int j = right;
        while (i < j)
        {
            while (i <= right && array[i] <= array[left])
            {
                i++;
            }
            while (array[j] > array[left])
            { j--; }
            if (i < j)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        temp = array[left];
        array[left] = array[j];
        array[j] = temp;

        QuickSort(array, left, j - 1);
        QuickSort(array, j + 1, right);
    }

    //Quick sort for string Type 
    public static void QuickSort(String[] array, int left, int right)
    {
        if (left >= right)
            return;

        String temp;
        int i = left;
        int j = right;
        while (i < j)
        {
            while (i <= right && array[i].CompareTo(array[left]) <= 0)
            {
                i++;
            }
            while ((array[j].CompareTo(array[left])) > 0)
            { j--; }

            if (i < j)
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        temp = array[left];
        array[left] = array[j];
        array[j] = temp;
        
        QuickSort(array, left, j - 1);
        QuickSort(array, j + 1, right);
    }

}