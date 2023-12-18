lista = ['goiaba', 'abacaxi', 'melancia', 'caju', 'goiaba', 'abacaxi', 'melancia', 'caju', 'caju']

busca = input('Digite sua busca: ')
contador = 0

for i in lista:
    if busca.lower() == i:
        contador += 1

if contador == 0:
    print(f'O elemento {busca.capitalize()} não se encontra na lista.')
else:
    print(f'O elemento {busca.capitalize()} se repete {contador} vezes na lista.')