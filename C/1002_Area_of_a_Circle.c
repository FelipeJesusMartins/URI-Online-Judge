#include <stdio.h>

int main()
{
    double a;

    scanf("%lf", &a);
    printf("A=%.4lf\n", (a * a) * 3.14159);

    return 0;
}
