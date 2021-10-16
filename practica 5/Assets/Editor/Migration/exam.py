import funfac

matricula=[1,2,5,7,5,7,9]

tabla_1 =[
         [5, 4, 7, 3, 0, 9, 1],
         [6, 1, 0, 6, 7, 6, 2], 
         [0, 8, 8, 1, 5, 2, 8], 
         [1, 6, 9, 2, 3, 0, 1], 
         [3, 6, 5, 0, 2, 7, 1], 
         [9, 5, 1, 7, 4, 8, 6],
         [1, 2, 7, 5, 2, 1, 0],
        ] 


tabla_2= [ 
         [5, 4, 7, 3, 0, 9, 1, 9, 5, 1, 7, 4, 8, 0, 6, 5, 0, 2, 7, 4],
         [6, 1, 0, 6, 7, 6, 5, 0, 8, 8, 1, 5, 2, 4, 5, 2, 4, 3, 6, 7], 
         [0, 8, 8, 1, 5, 2, 4, 3, 6, 5, 0, 2, 7, 4, 8, 1, 5, 2, 4, 3], 
         [1, 6, 9, 2, 3, 0, 7, 5, 4, 7, 3, 0, 9, 1, 5, 2, 4, 3, 6, 7], 
         [3, 6, 5, 0, 2, 7, 4, 6, 1, 0, 6, 7, 6, 5, 1, 0, 6, 7, 6, 5], 
         [9, 5, 1, 7, 4, 8, 0, 1, 6, 9, 2, 3, 0, 7, 5, 4, 7, 3, 0, 9],
         [1, 5, 2, 4, 3, 6, 7, 5, 4, 7, 3, 0, 2, 8, 7, 6, 5, 0, 8, 8],
         [4, 7, 3, 0, 9, 1, 9, 5, 2, 4, 3, 6, 7, 0, 0, 2, 7, 4, 8, 1],
         [1, 6, 9, 2, 3, 0, 7, 5, 4, 7, 3, 0, 9, 1, 5, 1, 7, 4, 8, 0],
         [6, 1, 0, 6, 7, 6, 5, 0, 8, 8, 1, 5, 2, 4, 4, 5, 2, 4, 3, 6]         
        ]


print("matricula:")
print(matricula)
print()
facm=funfac.faclista
print(facm)
print()
print("tabla 1")
funfac.imprimeMatriz(tabla_1)
print()
print()
funfac.mayor(tabla_1)
funfac.imprimeMatriz(tabla_1)
print()
print("tabla 2")
funfac.imprimeMatriz(tabla_2)
print()
print()
funfac.mayor(tabla_2)
funfac.imprimeMatriz(tabla_2)