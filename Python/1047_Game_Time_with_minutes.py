initial_hour, initial_minute, final_hour, final_minute = map(int, input().split())

initial_moment = initial_hour * 60 + initial_minute
final_moment = final_hour * 60 + final_minute

duration_minutes = (final_moment - initial_moment) % 1440

if duration_minutes == 0:
    duration_minutes = 1440

print(f"O JOGO DUROU {duration_minutes // 60} HORA(S) E {duration_minutes % 60} MINUTO(S)")