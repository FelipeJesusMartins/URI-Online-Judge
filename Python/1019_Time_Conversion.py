seconds_total = int(input())

hour = int(seconds_total / 3600)
seconds_total %= 3600
minutes = int(seconds_total / 60)
seconds = int(seconds_total % 60)

print(f"{hour}:{minutes}:{seconds}")