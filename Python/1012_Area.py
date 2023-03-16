values = input().split()

a = float(values[0])
b = float(values[1])
c = float(values[2])
pi = 3.14159

triangle = (a * c)/2
circle = pi * (pow(c , 2))
trapeze = ((a + b)/2) * c
square = pow(b , 2)
rectangle = a * b

print(f"TRIANGULO: {triangle:.3f}")
print(f"CIRCULO: {circle:.3f}")
print(f"TRAPEZIO: {trapeze:.3f}")
print(f"QUADRADO: {square:.3f}")
print(f"RETANGULO: {rectangle:.3f}")