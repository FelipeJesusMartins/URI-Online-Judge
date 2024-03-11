valores = list(map(float, input().split()))

media = (valores[0] * 2 + valores[1] * 3 + valores[2] * 4 + valores[3]) / 10

print(f"Media: {media:.1f}")

if media >= 7.0:
    print("Aluno aprovado.") 
elif media < 5.0:
    print("Aluno reprovado.")
elif (media >= 5.0 and media <= 6.9):
    print("Aluno em exame.")
    e = float(input())
    print(f"Nota do exame: {e:.1f}")
    final = (media + e) / 2
    if final >= 5.0 :
        print("Aluno aprovado.")
    else :
        print("Aluno reprovado.")
    print(f"Media final: {final:.1f}")