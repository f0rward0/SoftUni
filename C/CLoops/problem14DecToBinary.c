#include <stdio.h>
#include <stdlib.h>
#include <math.h>


int main()
{
    int n;
    scanf("%d",&n);
    int rem, i=1, binary=0;
    while (n!=0)
    {
        rem=n%2;
        n/=2;
        binary+=rem*i;
        i*=10;
    }

    printf("%d",binary);
    return 0;
}
