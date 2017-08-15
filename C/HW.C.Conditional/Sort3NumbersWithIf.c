#include <stdio.h>
#include <stdlib.h>


int main()
{
    double a,b,c;
    scanf("%lf %lf %lf",&a,&b,&c);

    if(a>=b&&a>=c&&b>=c)
        printf("%.1lf %.1lf %.1lf",a,b,c);
    else if(a>=b&&a>=c&&b<=c)
        printf("%.1lf %.1lf %.1lf",a,c,b);
    else if(b>=a&&b>=c&&a<=c)
        printf("%.1lf %.1lf %.1lf",b,c,a);
    else if(b>=a&&b>=c&&a>=c)
        printf("%.1lf %.1lf %.1lf",b,a,c);
    else if(c>=a&&c>=b&&a>=b)
        printf("%.1lf %.1lf %.1lf",c,a,b);
    else
        printf("%.1lf %.1lf %.1lf",c,b,a);

    return 0;
}
