#include <stdio.h>

void bubble_sort_ascending(int arr[]) {
     int i, j, temp;
     for (i = 0; i < 3-1; i++){
          for (j = 0; j < 3-i-1; j++){
               if(arr[j] > arr[j+1]){
                    temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
               }
          }
     }
}

int main()
{
     int number[3], number_clone[3];

     scanf("%d %d %d", &number[0], &number[1], &number[2]);
     
     for (int i = 0; i < 3; i++)
     {
          number_clone[i] = number[i];
     }
     
     bubble_sort_ascending(number_clone);

     for (int i = 0; i < 3; i++)
     {
          printf("%d\n", number_clone[i]);
     }

     printf("\n");

     for (int i = 0; i < 3; i++)
     {
          printf("%d\n", number[i]);
     }

    return 0;
}