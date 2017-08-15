#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    int n;
    scanf("%d",&n);
    int decimal=0, i=0, rem;
    while (n!=0)
    {
        rem = n%10;
        n/=10;
        decimal += rem*pow(2,i);
        ++i;
    }

    printf("%d",decimal);
    return 0;
}
