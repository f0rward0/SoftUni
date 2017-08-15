#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int fact(int a);
int toPower(int x,int power);

int main()
{
    int n,x;
    scanf("%d %d",&n,&x);
    int i;
    double output=1;
    for(i=1;i<=n;i++)
    {
        output+=(double)fact(i)/(double)toPower(x,i);
    }
    printf("%.5lf",output);
    return 0;

}
int fact(int a)
{
    int i;int toPower(int x,int power)
    int fact=1;
    for(i=1;i<=a;i++)
    {
        fact*=i;
    }
    return fact;
}
int toPower(int x,int power)
{
    int i;
    int output=1;
    for(i=0;i<power;i++)
    {
        output*=x;
    }

    return output;



}
