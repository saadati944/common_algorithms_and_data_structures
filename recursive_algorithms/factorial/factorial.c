#include <stdio.h>
#include <stdlib.h>

long fact(long);

int main()
{
    /*
    * get a number from user and
    * calculate the factorial
    */
    long input = 0;
    printf("enter number : ");
    scanf("%ld", &input);
    printf("factorial of %ld is : %ld\n", input, fact(input));
    return 0;
}

long fact(long v)
{
    /*
    * recursively calculate the factorial
    */
    if (v < 2)
        return v;
    return v * fact(v - 1);
}