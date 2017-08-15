#include <stdio.h>
#include <stdlib.h>


int main()
{
    int a;
    scanf("%d",&a);

    if(a<1||a>9)
        printf("invalid score");
    else if(a<=3)
        printf("%d",a*10);
    else if(a>3&&a<7)
        printf("%d",a*100);
    else
        printf("%d",a*1000);

    return 0;
}
