#include <stdio.h>
#include <stdlib.h>


int main()
{
    int a;
    double b;
    char* c;
    printf("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
    scanf("%d",&a);

    switch (a)
    {
        case 1:
            printf("Please enter an integer: \n");
            scanf("%d",&a);
            printf("%d",++a);
            break;
        case 2:
            printf("Please enter a double: \n");
            scanf("%lf",&b);
            printf("%.1lf",++b);
            break;
        case 3:
            printf("Please enter a string \n");
            scanf("%s",c);
            printf("%s*",c);
            break;
    }
    return 0;
}
