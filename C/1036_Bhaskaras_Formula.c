#include <stdio.h>
#include <math.h>

int main()
{
    double x, y, z;

    scanf("%lf %lf %lf", &x, &y, &z);

    if (x == 0 || ((y * y) - 4 * x * z) < 0.0)
        printf("Impossivel calcular\n");
    else
        printf("R1 = %.5lf\nR2 = %.5lf\n", (-y + pow(((y * y) - 4 * x * z), 0.5)) / (2.0 * x), (-y - pow(((y * y) - 4 * x * z), 0.5)) / (2.0 * x));
    return 0;
}