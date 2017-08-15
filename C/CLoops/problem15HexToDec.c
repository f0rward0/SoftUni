#include <stdio.h>
#include <stdlib.h>

int main()
{
    char hex[50];
    gets(hex);
    char *pEnd;
    long dec;

    dec=strtol(hex,&pEnd,16);

    printf("%d",dec);



}
