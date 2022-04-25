#include <stdio.h>
#include <math.h>

int main()
{
    double x, y, z, d;

    scanf("%lf %lf %lf", &x, &y, &z);

    d = (y * y) - 4 * x * z;

    if (x == 0 || d < 0.0)
        printf("Impossivel calcular\n");
    else
        printf("R1 = %.5lf\nR2 = %.5lf\n", (-y + pow(d, 0.5)) / (2.0 * x), (-y - pow(d, 0.5)) / (2.0 * x));
    return 0;
}