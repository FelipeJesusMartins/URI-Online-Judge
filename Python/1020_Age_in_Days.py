input = int(input())

print(f"{int(input/365)} ano(s)")
input %= 365
print(f"{int(input/30)} mes(es)")
input %= 30
print(f"{int(input)} dia(s)")