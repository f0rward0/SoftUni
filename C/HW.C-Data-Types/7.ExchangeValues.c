#include <stdio.h>
#include <stdlib.h>

int main()
{
   int a=10;
   int b=5;
   int c=0;

   printf("before\n%d\n%d\n",a,b);

   c=a;
   a=b;
   b=c;

   printf("after\n%d\n%d\n",a,b);


    return 0;
}
