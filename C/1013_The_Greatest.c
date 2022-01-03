#include <stdio.h>

int main()
{
    int x, y, z, tmp;
    scanf("%d %d %d", &x, &y, &z);
    if (x > y && x > z)
    {
        tmp = x;
    }
    else if (y > z)
    {
        tmp = y;
    }
    else
    {
        tmp = z;
    }
    printf("%d eh o maior\n",tmp);
    return 0;
}