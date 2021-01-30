#include <stdlib.h>
#include <stdio.h>

int palindrome(char[]);

int main()
{
    char input[200];
    fgets(input, 200, stdin);
    
    printf("%d %s\n", palindrome(input), input);
    return 0;
}

int palindrome(char input[])
{
    int len = 0;
    for(len;input[len];len++);
    len--;


    for(int i=0; i<len/2;i++)
        if(input[i] != input[len-i-1])
            return 0;
    
    return 1;
}