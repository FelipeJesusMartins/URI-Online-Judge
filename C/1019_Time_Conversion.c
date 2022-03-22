#include <stdio.h>

int main()
{
    int x;
    int m = 0;
    int h = 0;
    scanf("%d", &x);
    if (x >= 3600)
    {
        h = x / 3600;
        x %= 3600;
    }
    if (x >= 60 && x < 3600)
    {
        m = x / 60;
        x %= 60;
    }

    printf("%d:%d:%d\n", h, m, x);
    return 0;
}