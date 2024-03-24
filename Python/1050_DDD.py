animal_map = {
    "61": "Brasilia",
    "71": "Salvador",
    "11": "Sao Paulo",
    "21": "Rio de Janeiro",
    "32": "Juiz de Fora",
    "19": "Campinas",
    "27": "Vitoria",
    "31": "Belo Horizonte"

}

in1 = input()

try:
    print(animal_map[in1])
except KeyError:
    print("DDD nao cadastrado")