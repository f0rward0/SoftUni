#include <stdio.h>
#include <stdlib.h>


int main()
{
    double a,b,c,d,e;
    scanf("%lf %lf %lf %lf %lf",&a,&b,&c,&d,&e);

    if(a>=b&&a>=c&&a>=d&&a>=e)
        printf("%.1lf",a);
    else if(b>=a&&b>=c&&b>=d&&b>=e)
        printf("%.1lf",b);
    else if(c>=a&&c>=b&&c>=d&&c>=e)
        printf("%.1lf",c);
    else if(d>=a&&d>=b&&d>=c&&d>=e)
    printf("%.1lf",d);
    else printf("%.1lf",e);


    return 0;


}
