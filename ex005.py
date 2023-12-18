lista = [20, 8, 2, 12.8, -4]
lista_revertida = []

print(f'Lista Original: {lista}')

while lista:
    x = lista.pop()
    lista_revertida.append(x)

for i in lista:
    print(i)

print(f'Lista Revertida: {lista_revertida}')