def factorial(n):
    if(n==0):
        return 1
    else:
        return n*factorial(n-1)

def faclista(lista):
    
    n=0
    for i in lista:
        if(i==0):
            lista[n]=1
        else:
            lista[n]= i*factorial(i-1)
        n+=1
    
   

def imprimeMatriz(matriz):
    for renglon in matriz:
        print(renglon)

def mayor(matriz):
    ren=0
    for renglon in matriz:
        col =0
        for elemento in renglon:
            if(elemento<5):
                matriz[ren][col]=elemento**2
            elif(elemento>=5):
                matriz[ren][col]=elemento**3
            col+=1
        ren+=1