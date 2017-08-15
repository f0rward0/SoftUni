#include <stdio.h>
#include <stdlib.h>

int main()
{
    int i;
    char arr[]="JQKA";

    for(i=2;i<=10;i++)
    {
        printf("%dC %dD %dH %dS\n",i,i,i,i);
    }

    for(i=0;i<4;i++)
    {
        printf("%cC %cD %cH %cS\n",arr[i],arr[i],arr[i],arr[i]);

    }

    return 0;


}
