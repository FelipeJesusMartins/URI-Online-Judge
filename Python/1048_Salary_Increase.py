x = float(input())

if x >= 0.00 and x <= 400.00:
    tx = 0.15
elif x > 400.00 and x <= 800.00:
    tx = 0.12
elif x > 800.00 and x <= 1200.00:
    tx = 0.1
elif x > 1200.00 and x <= 2000.00:
    tx = 0.07
else:
    tx = 0.04

print(f"Novo salario: {x + (x * tx):.2f}")
print(f"Reajuste ganho: {x * tx:.2f}")
print(f"Em percentual: {tx * 100:.0f} %")