a, b, c = sorted(map(float, input().split()), reverse=True)

if a >= b + c :
    print("NAO FORMA TRIANGULO")
else:
    if a * a == (b * b) + (c * c):
        print("TRIANGULO RETANGULO")
    if a * a > (b * b) + (c * c):
        print("TRIANGULO OBTUSANGULO")
    if a * a < (b * b) + (c * c): 
        print("TRIANGULO ACUTANGULO")
    if a == b and a == c and b == c:
        print("TRIANGULO EQUILATERO")
    if (a == b and a != c) or (a == c and a != b) or (b == c and b != a):
        print("TRIANGULO ISOSCELES")