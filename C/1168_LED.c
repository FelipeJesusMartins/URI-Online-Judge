#include <stdio.h>

int main(void)
{
    int i;

    scanf("%d", &i);

    for (int counter = 0; counter < i; i++)
    {
        int initialNumber, finalNumber, temp;

        scanf("%d", &initialNumber);

        while (initialNumber >= 0)
        {
            temp = initialNumber;

            if (temp == 1)
            {
                finalNumber += 2;
            }
            else if (temp == 7)
            {
                finalNumber += 3;
            }
            else if (temp == 4)
            {
                finalNumber += 4;
            }
            else if (temp == 5 || temp == 3 || temp == 2)
            {
                finalNumber += 5;
            }
            else if (temp == 6 || temp == 9 || temp == 0)
            {
                finalNumber += 6;
            }
            else
            {
                finalNumber += 7;
            }

            initialNumber / 10;
        }
    }
    /*
    1 > 2
    7 > 3
    4 > 4
    5,3,2 > 5
    6,9,0 > 6
    8 > 7
    */
}