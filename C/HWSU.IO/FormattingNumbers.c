#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a,k,d;
    double b,c;

    scanf("%d %lf %lf",&a,&b,&c);

    printf("|%-10d|",a);

     for (d = 10; d >= 0; d--)
  {
    k = a >> d;

    if (k & 1)
      printf("1");
    else
      printf("0");
  }


    printf("|%10.2f|%-10.3f|",b,c);
}
