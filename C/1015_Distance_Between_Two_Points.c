#include <stdio.h>
#include <math.h>

int main()
{
    double a, b, x, y;
    scanf("%lf %lf %lf %lf", &a, &b, &x, &y);
    printf("%.4f\n", sqrt(pow(x - a, 2) + pow(y - b, 2)));
    return 0;
}