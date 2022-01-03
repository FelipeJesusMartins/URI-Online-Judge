#include <stdio.h>

int main()
{
    int a;
    double b, x, c, y;

    scanf("%d %lf %lf", &a, &b, &c);
    scanf("%d %lf %lf", &a, &x, &y);

    printf("VALOR A PAGAR: R$ %.2lf\n", b * c + x * y);
    return 0;
}