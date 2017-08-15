#include <stdio.h>
#include <stdlib.h>

#define PI 3.14

//Problem 3. Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the
//decimal point

int main()
{
    double r;
    scanf("%lf",&r);

    printf("Perimeter = %.2Lf\n",2*PI*r);
    printf("Area = %.2lf",PI*r*r);

    return 0;
}
