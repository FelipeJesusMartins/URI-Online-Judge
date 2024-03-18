x,y = map(int, input().split())

if x < y:
    print(f"O JOGO DUROU {y - x} HORA(S)")
else:
    print(f"O JOGO DUROU {(24 - x) + y} HORA(S)")