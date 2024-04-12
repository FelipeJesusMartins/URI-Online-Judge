#include <stdio.h>

int main(){

     double a, b, c, d, media;

     scanf("%lf %lf %lf %lf", &a, &b, &c, &d);

     media = ((a*2) + (b*3) + (c*4) + d) / 10;

     printf("Media: %0.1lf\n", media);

     if(media >= 7.0){
          printf("Aluno aprovado.\n");
     }else if (media >= 5.0 && media <=6.9){
          printf("Aluno em exame.\n");
          double exame;
          scanf("%lf", &exame);
          printf("Nota do exame: %0.1lf\n",exame);
          if((media + exame) / 2 >= 5.0){
               printf("Aluno aprovado.\n");
               printf("Media final: %0.1lf\n", (media + exame) / 2);
          }else{
               printf("Aluno reprovado.\n");
          }
     }else{
          printf("Aluno reprovado.\n");
     }

    return 0;
}