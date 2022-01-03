#include <stdio.h>

int main()
{
    double x, y, z;
    scanf("%lf %lf %lf", &x, &y, &z);
    printf("TRIANGULO: %.3lf\n", (x * z) / 2);
    printf("CIRCULO: %.3lf\n", (z * z) * 3.14159);
    printf("TRAPEZIO: %.3lf\n", ((x + y) / 2) * z);
    printf("QUADRADO: %.3lf\n", y * y);
    printf("RETANGULO: %.3lf\n", x * y);
    return 0;
}