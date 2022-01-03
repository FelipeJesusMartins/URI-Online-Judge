#include <stdio.h>

int main()
{
    double x;
    scanf("%lf", &x);
    printf("VOLUME = %.3lf\n", ((4.0 / 3.0) * 3.14159) * (x * x * x));
    return 0;
}