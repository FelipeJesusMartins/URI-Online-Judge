x, y, z = map(float, input().split())

if(x + y > z and x + z > y and z + y > x):
    print(f"Perimetro = {x+y+z:.1f}")
else:
    print(f"Area = {((x + y) * z) / 2:.1f}")