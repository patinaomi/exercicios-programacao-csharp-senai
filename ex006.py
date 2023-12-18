lista = ['goiaba', 'abacaxi', 'melancia', 'caju', 'kiwi']

busca = input('Digite sua busca: ')

if busca in lista:
    print(f'O elemento {busca} se encontra na lista.')
else:
    print(f'O elemento {busca} não se encontra na lista.')