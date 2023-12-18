lista = [5, 6.7, 'goiaba', True, '8.9']
cont = 0

for i in lista:
    cont += 1
    print(f'{cont} - {i}')

while True:
    op = int(input('Digite a posição que você deseja alterar: '))
    comp = len(lista)

    if op < 0 or op > comp:
        print('Valor inválido')
    elif op == 0:
        print('Saindo do programa...')
        break
    else:
        alt = input('Digite o novo elemento: ')
        lista[op-1] = alt
        print(f'Lista alterada: {lista}')