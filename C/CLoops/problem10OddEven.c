#include <stdio.h>
#include <stdlib.h>

int main()
{
    int arr[10];
    int oddProduct=1;
    int evenProduct=1;


    while ((c = getchar()) != '\n')
    {
    if (c != ' ')
        arr[i++] = c - '0';
    }


    int i;
    for(i=0;i<10;i++)
    {
        if((i+1)%2==0)
        {
            evenProduct*=arr[i];
        }
        else
            oddProduct*=arr[i];
    }

    if(evenProducy==oddProduct)
        printf("yes\nproduct %d\n",evenProduct);
    else
        printf("no\nevenProduct %d\noddProduct%d\n",evenProduct,oddProduct);





}
