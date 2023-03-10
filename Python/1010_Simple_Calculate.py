product = input().split()
product_two = input().split()

test = int(product[1]) * float(product[2]) + int(product_two[1]) * float(product_two[2])

print(f"VALOR A PAGAR: R$ {test:.2f}")