input = input().split(' ')

a = int(input[0])
b = int(input[1])
c = int(input[2])
d = int(input[3])

if(b > c and
    d > a and 
    (c + d) > (a + b) and
    c > 0 and 
    d > 0 and
    a % 2 == 0):
    print("Valores aceitos")
else :
    print("Valores nao aceitos")