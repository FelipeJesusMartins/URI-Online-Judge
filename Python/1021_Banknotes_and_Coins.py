input = float(input())

print("NOTAS:")

print(f"{int(input/100)} nota(s) de R$ 100.00")
input %= 100

print(f"{int(input/50)} nota(s) de R$ 50.00")
input %= 50

print(f"{int(input/20)} nota(s) de R$ 20.00")
input %= 20

print(f"{int(input/10)} nota(s) de R$ 10.00")
input %= 10

print(f"{int(input/5)} nota(s) de R$ 5.00")
input %= 5

print(f"{int(input/2)} nota(s) de R$ 2.00")
input %= 2

print("MOEDAS:")

print(f"{int(input)} moeda(s) de R$ 1.00")
input %= 1
input *= 100

print(f"{int(input/50)} moeda(s) de R$ 0.50")
input %= 50

print(f"{int(input/25)} moeda(s) de R$ 0.25")
input %= 25

print(f"{int(input/10)} moeda(s) de R$ 0.10")
input %= 10

print(f"{int(input/5)} moeda(s) de R$ 0.05")
input %= 5

print(f"{int(input)} moeda(s) de R$ 0.01")