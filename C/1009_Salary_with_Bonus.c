#include <stdio.h>

int main()
{
    char n[20];
    double b,c;

    scanf("%s %lf %lf",&n,&b,&c);

    printf("TOTAL = R$ %.2lf\n",b+(c*0.15));

    return 0;
}