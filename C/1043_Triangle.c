#include <stdio.h>
#include <math.h>

int main() {
  float a, b, c;

  scanf("%f %f %f", &a, &b, &c);

  if (a + b > fabs(c) && a + c > fabs(b) && b + c > fabs(a)) {
    printf("Perimetro = %.1f\n", a + b + c);
  } else {
    printf("Area = %.1f\n", 0.5 * (a + b) * fmin(c, fabs(a - b)));
  }

  return 0;
}