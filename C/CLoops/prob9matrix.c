#include <stdio.h>
#include <stdlib.h>


int main()
{
    int n;
    scanf("%d",&n);

    int matrix[n][n];
    int i,j;
    int k;

    for(i=0;i<n;i++)
    {
        k=i+1;
        for(j=0;j<n;j++)
        {
            matrix[i][j]=k++;
        }
    }


    for(i=0;i<n;i++)
    {
        for(j=0;j<n;j++)
        {
            printf("%d ",matrix[i][j]);
        }
        printf("\n");
    }





    return 0;
}
