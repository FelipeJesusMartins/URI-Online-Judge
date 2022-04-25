#include <stdio.h>

const char *result(int a, int b, int c, int d)
{
    if (b > c && d > a && (c + d) > (a + b) && c > 0 && d > 0 && a % 2 == 0)
        return "Valores aceitos";
    return "Valores nao aceitos";
}

int main()
{
    int a, b, c, d;
    scanf("%d %d %d %d", &a, &b, &c, &d);
    printf("%s\n",result(a,b,c,d));
    return 0;
}