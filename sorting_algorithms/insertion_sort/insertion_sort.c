#include <stdio.h>

// unsorted array
int array[10] = {2, 0, 4, 9, 5, 3, 8, 1, 6, 7};
int len = 10;

int main()
{
    // print unsorted array
    puts("unsorted :");
    for(int i =0;i<len;i++)
        printf("%d, ", array[i]);

    int t=0, temp;
    for(int i=0;i<len;i++)
    {
        t = i;

        // Move the element to the left until
        // it is smaller than the left element
        while(t>0 && array[t]<array[t-1])
        {
            temp = array[t];
            array[t]=array[t-1];
            array[t-1] = temp;
            t--;
        }
    }

    // print sorted array
    puts("\nsorted :");
    for(int i =0;i<len;i++)
        printf("%d, ", array[i]);
    puts("");
    return 0;
}