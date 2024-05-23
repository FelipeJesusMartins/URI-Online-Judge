#include <stdio.h>

int TriangleOrNot(float a, float b, float c)
{
  if (a + b <= c || a + c <= b || b + c <= a)
  {
    return 0; // Retorna 0 (falso) se não podem formar um triângulo
  }
  else
  {
    return 1; // Retorna 1 (verdadeiro) se podem formar um triângulo
  }
}

int main()
{
  float a, b, c;

  scanf("%f %f %f", &a, &b, &c);

  if (!TriangleOrNot(a, b, c))
  {
    printf("NAO FORMA TRIANGULO\n");
  }
  else
  {
    if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
      printf("TRIANGULO RETANGULO\n");
    if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > a * a + b * b)
      printf("TRIANGULO OBTUSANGULO\n");
    if (a * a < b * b + c * c && b * b < a * a + c * c && c * c < a * a + b * b)
      printf("TRIANGULO ACUTANGULO\n");
    if (a == b && b == c)
      printf("TRIANGULO EQUILATERO\n");
    if ((a == b && a != c) || (b == c && b != a) || (c == a && c != b))
      printf("TRIANGULO ISOSCELES\n");
  }
  return 0;
}
