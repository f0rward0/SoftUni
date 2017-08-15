#include <stdio.h>
#include <stdlib.h>


int main()
{
    double a,b,c;
    scanf("%lf %lf %lf",&a,&b,&c);

    if(a==0||b==0||c==0)
        printf("0");
    else if(a<0&&b>0&&c>0)
    {
        printf("-");
    }
    else if(a>0&&b<0&&c>0)
      printf("-");
    else if(a>0&&b>0&&c<0)
        printf("-");
    else if(a<0&&b<0&&c<0)
        printf("-");
    else
        printf("+");
        return 0;


}


