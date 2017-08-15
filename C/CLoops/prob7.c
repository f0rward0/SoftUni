#include <stdio.h>
#include <stdlib.h>

int fact(int fac);

int main()
{
    int n,k;

    scanf("%d %d",&n,&k);

    double output;

    output=(double)fact(n)/((double)fact(k)*fact(n-k));
    printf("%.2lf",output);
    return 0;
}
int fact(int n)
{
  if (n == 0)
    return 1;
  else
    return(n * fact(n-1));

}
