input = int(input())

print(f"{input}")
print(f"{int(input/100)} nota(s) de R$ 100,00")
input %= 100
print(f"{int(input/50)} nota(s) de R$ 50,00")
input %= 50
print(f"{int(input/20)} nota(s) de R$ 20,00")
input %= 20
print(f"{int(input/10)} nota(s) de R$ 10,00")
input %= 10
print(f"{int(input/5)} nota(s) de R$ 5,00")
input %= 5
print(f"{int(input/2)} nota(s) de R$ 2,00")
input %= 2
print(f"{int(input)} nota(s) de R$ 1,00")