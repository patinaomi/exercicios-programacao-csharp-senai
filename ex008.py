lista = ['goiaba', 'abacaxi', 'melancia', 'caju']

while True:
    i = 1
    print('*' * 5, 'PROGRAMA', '*' * 5)
    print('[1] Adicionar a lista')
    print('[2] Remover da lista')
    print('[3] Exibir lista')
    print('[0] Sair do Programa')
    print('*' * 20)
    op = input('Digite uma opção: ')
    if op == '1':
        busca = input('Digite o nome da fruta que quer adicionar: ')
        lista.append(busca.lower())
        print(f'\t- {busca.capitalize()} adicionado com sucesso.')
        print(f'Nova lista: {lista}')
    elif op == '2':
        print('*'*5, 'Lista de Frutas', '*'*5)
        for fruta in lista:
            print(f'{i} - {fruta.capitalize()}')
            i += 1

        num = int(input('Digite o número da fruta que deseja retirar: '))
        comprimento = len(lista)

        if num <= comprimento:
            lista.pop(num-1)
            print(f'{fruta.capitalize()} retirado da lista. ')
            print(f'Nova lista: {lista}')
        if num > comprimento:
            print(f'Número inválido.')

    elif op == '3':
        for fruta in lista:
            print(f'{i} - {fruta.capitalize()}')
            i += 1

    elif op == '0':
        print('Saindo do programa...')
        break
    else:
        print('Opção inválida, digite novamente.')