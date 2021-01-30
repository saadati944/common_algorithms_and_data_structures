#include <iostream>

using namespace std;

long fibo(long);
long nonRecursiveFibo(long);

int main()
{
    long input = 0;

    cout << "enter number to calculate fibonacci non recursively : ";
    cin >> input;
    cout << nonRecursiveFibo(input) << endl;

    cout << "enter number to calculate fibonacci recursively : ";
    cin >> input;
    cout << fibo(input) << endl;

    return 0;
}

long fibo(long f)
{
    if(f<3)
        return 1;
    return fibo(f-1) + fibo(f-2);
}

long nonRecursiveFibo(long f)
{
    if(f<3)
        return 1;
    
    long i = 2;
    long fibos[f];

    fibos[0] = 1;
    fibos[1] = 1;

    while (i<f)
    {
        fibos[i] = fibos[i-1] + fibos[i-2];
        i++;
    }

    return fibos[f-1];
}