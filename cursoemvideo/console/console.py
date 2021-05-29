Nome = input("Bom dia, bem vindo ao sistema, por favor insira seu nome")
print("Bem vindo {}!".format(Nome))
print ("o que deseja fazer {}? ".format(Nome) )
print("Esta são as funções do programa, por favor digite o numero correspondente a função desejada")

print(    "1.Calculadorar dois numeros\n"        
          "2.Conversão de moeda\n"
          "3.transformação de medidas \n")

escolha= int(input("por favor digite a função desejada"))




if escolha==1:

    n1 = float(input("digite o primeiro numero"))
    n2=float(input("digite o segundo numero"))

    print("por favor escolha a operação\n"
          "1.adição\n"
          "2.subtração\n"
          "3.multiplicação\n"
          "4.divisão\n"
          "5.potenciação\n"
          "6.raiz\n"
          "7.pcrcentagem\n"
          "8.media\n")

    op =int (input("digite o numero da operação desejada"))

    if op==1:
        soma = n1+n2
        print("{} o resultado é {}".format(Nome, soma))
    if op==2:
        soma= n1-n2
        print("{} o resultado é {}".format(Nome, soma))
    if op==3:
        soma=n1*n2
        print("{} o resultado é {}".format(Nome, soma))
    if op==4:
        soma=n1/n2
        print("{} o resultado é {}".format(Nome, soma))
    if op==5:
        soma=n1**n2
        print("{} o resultado é {}".format(Nome, soma))
    if op==6:
        from math import floor
        soma1 = n1 ** (1 / n2)
        soma=floor(soma1)
        print("{} o resultado é {}".format(Nome, soma))
    if op==7:
        soma=(n1/100)*n2
        print("{} o resultado é {}".format(Nome, soma))
    if op==8:
       n3=input("digite o valor da media")
       soma= (n1+n2)/n3
       print("{} o resultado é {}".format(Nome,soma))

if escolha==2:
      n1=float(input("quanto quer converter?"))
      n2=float (input("cotação da moeda estrangeira"))

      from math import floor
      re=floor(n1/n2)

      print("{} você tem {} em valor estrangeiro".format(Nome, re))

if escolha==3:
    print("{} por favor digite o numero correspondente a unidade de medida que vai ser convertida".format(Nome))
    print("1.centimetros\n"
          "2.metros\n"
          "quilometros\n")
    unidade1=input("digite aqui")

    print ("{} agora digite o numero correspondente para qual unidade converter " )

    print("1.centimetros\n"
          "2.metros\n"
          "quilometros\n")

    unidade2=input("digite aqui")
    if(unidade1=="1" ):

else:
    print("{} essa função não existe" .format(Nome))