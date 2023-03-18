import math

a = input().split()
b = input().split()

x1 = float(a[0])
y1 = float(a[1])
x2 = float(b[0])
y2 = float(b[1])

distance = math.sqrt((pow(x2 - x1, 2) + (pow(y2 - y1, 2))))

print(f"{distance:.4f}")