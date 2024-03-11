x = float(input());

if x < 0.00 or x > 100.00 :
    print("Fora de intervalo")
elif x >= 0.00 and x <= 25.00 :
    print("Intervalo [0,25]")
elif x >= 25.00 and x <= 50.00 :
    print("Intervalo (25,50]")
elif x >= 50.00 and x <= 75.00 :
    print("Intervalo (50,75]")
else :
    print("Intervalo (75,100]")