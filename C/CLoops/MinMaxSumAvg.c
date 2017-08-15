#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n;
    scanf("%d",&n);

    int arr[n];
    int i;
    for(i=0;i<n;i++)
    {
        scanf("%d",&arr[i]);
    }
    double min,max;
    double sum=0;

    min=arr[0];
    max=arr[0];
    for(i=0;i<n;i++)
    {
        if(arr[i]<min)
            min=arr[i];

        if(arr[i]>max)
            max=arr[i];

        sum+=arr[i];
    }

    printf("min=%.2lf\nmax=%.2lf\nsum=%.2lf\navg=%.2lf\n",min,max,sum,sum/n);

}
