x, y, z = map(int, input().split())

maior = max(x, y, z)
menor = min(x, y, z)
meio = (x + y + z) - maior - menor

print(f"{menor}\n{meio}\n{maior}\n")
print(f"{x}\n{y}\n{z}")