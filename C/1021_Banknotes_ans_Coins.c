#include <stdio.h>
#include <math.h>

void convertNumbers(double money, int* notes, int* coins)
{
    double mNotes, mCoins;
    mCoins = modf(money,&mNotes);
    mCoins *= 100.0;

    *notes = (int)mNotes;
    *coins = (int)mCoins;
}

int main()
{
    double input;
    int notes, coins;

    scanf("%lf", &input);

    convertNumbers(input,&notes,&coins);

    printf("NOTAS:\n");
    printf("%d nota(s) de R$ 100.00\n", notes / 100);
    printf("%d nota(s) de R$ 50.00\n", (notes %= 100) / 50);
    printf("%d nota(s) de R$ 20.00\n", (notes %= 50) / 20);
    printf("%d nota(s) de R$ 10.00\n", (notes %= 20) / 10);
    printf("%d nota(s) de R$ 5.00\n", (notes %= 10) / 5);
    printf("%d nota(s) de R$ 2.00\n", (notes %= 5) / 2);
    printf("MOEDAS:\n");
    printf("%d moeda(s) de R$ 1.00\n", notes %= 2);
    printf("%d moeda(s) de R$ 0.50\n", (coins %= 100) / 50);
    printf("%d moeda(s) de R$ 0.25\n", (coins %= 50) / 25);
    printf("%d moeda(s) de R$ 0.10\n", (coins %= 25) / 10);
    printf("%d moeda(s) de R$ 0.05\n", (coins %= 10) / 5);
    printf("%d moeda(s) de R$ 0.01\n", coins %= 5);

    return 0;
}