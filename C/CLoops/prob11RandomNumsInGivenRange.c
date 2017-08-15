#include <stdio.h>
#include <stdlib.h>
#include <time.h>


int random_number(int min_num, int max_num);

int main()
{
    int min,max,count;
    int i;

    scanf("%d %d %d",&count,&min,&max);

    for(i=0;i<count;i++)
    {
        printf("%d ",random_number(min,max));
    }
    printf("\n");
    return 0;
}

int random_number(int min_num, int max_num)
{
    int result=0,low_num=0,hi_num=0;
    if(min_num<max_num)
    {
        low_num=min_num;
        hi_num=max_num+1; // this is done to include max_num in output.
    }else{
        low_num=max_num+1;// this is done to include max_num in output.
        hi_num=min_num;
    }
    srand(time(NULL));
    result = (rand()%(hi_num-low_num))+low_num;
    return result;
}
