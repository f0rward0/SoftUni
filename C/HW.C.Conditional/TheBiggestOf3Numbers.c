#include <stdio.h>
#include <stdlib.h>


int main()
{
    double a,b,c;
    scanf("%lf %lf %lf",&a,&b,&c);

    if(a>=b&&a>=c)
        printf("%.1lf",a);
    else if(b>=a&&b>=c)
        printf("%.1lf",b);
    else printf("%.1lf",c);
    return 0;


}
