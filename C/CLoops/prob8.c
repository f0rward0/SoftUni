#include <stdio.h>
#include <stdlib.h>

int catalan(int n);

int main()
{
    int n;
    scanf("%d",&n);
    printf("%d",catalan(n));

    return 0;
}

int catalan(int n) {
  if (n == 1||n==0)
    return 1;
  else
    return 2 * (2*n - 1) * catalan(n-1) / (n+1);

}
