#include <stdio.h>
#include <stdlib.h>

int main()
{
   int isFemale=0;
   printf("are you a woman?[1-yes 0-no]\n");
   scanf("%d",&isFemale);

   if(isFemale!=0)
   {
       printf("true");
   }
   else
   {
       printf("false");
   }


    return 0;
}
