import java.util.Scanner;

public class QuickSort
{
    public static void main(String[] args)
    {
        Scanner input = new Scanner(System.in);

        System.out.print("enter array : ");
        char[] array = input.nextLine().toCharArray();

        quickSort(array);

        System.out.print("sorted array : ");
        for(char x:array)
            System.out.print(x);
    }

    static void quickSort(char[] array)
    {
        if(array.length == 1)
            return;
        quickSort(array, 0, array.length-1);
    }
    static void quickSort(char[] array, int low, int high)
    {
        if(low < high)
        {
            int pi = partition(array, low, high);

            quickSort(array, low, pi-1);
            quickSort(array, pi+1, high);
        }
    }

    static int partition(char[] array, int low, int high)
    {
        int i = low - 1;
        int pivot = array[high];

        for(int j=low;j<high;j++)
        {
            if(array[j] <= pivot)
            {
                i++;
                swap(array, i, j);
            }
        }

        swap(array, i+1, high);
        return i+1;
    }

    static void swap(char[] array, int a, int b)
    {
        char t = array[a];
        array[a] = array[b];
        array[b] = t;
    }
}
