values = input().split()

a = int(values[0])
b = int(values[1])
c = int(values[2])

greatestAB = (a+b+abs(a-b))/2
greatestAC = (a+c+abs(a-c))/2
greatest = int((greatestAB+greatestAC+abs(greatestAB-greatestAC))/2)

print(f"{greatest} eh o maior")