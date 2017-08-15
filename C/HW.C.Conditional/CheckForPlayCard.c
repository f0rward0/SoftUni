#include <stdio.h>
#include <stdlib.h>


int main()
{
    char a[10];
    scanf("%s",a);
    int num=atoi(a);

    if(!strcmp(a,"A")||!strcmp(a,"J")||!strcmp(a,"K0")||!strcmp(a,"Q")||(num>=1&&num<=10))
        printf("yes");

    else
        printf("no");

        return 0;


}
