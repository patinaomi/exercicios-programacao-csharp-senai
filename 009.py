matriz = [[1, 2, 3],
         [4, 5, 6],
         [7, 8, 9]]

for linha in matriz:
    for i in linha:
        print(f'[{i}] ', end='')
    print()

print(f'Primeira fileira: {matriz[0][:3]}')
print(f'Número 4: {matriz[1][0]}')