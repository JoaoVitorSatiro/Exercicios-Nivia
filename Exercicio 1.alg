algoritmo "exercicio1"
// Função :
// Autor : JV e Clayton
// Data : 17/03/2023
// Seção de Declarações 
var
 result, result1,l, codA, codG :real
 
 cod:caracter
 
inicio
// Seção de Comandos 
escreva("Digite a quantidade de litros: ")
leia(l)
escreva("Digite A para Alcool ou digite G para gasolina: ")
leia(cod)
 se(cod="A") entao
  se(codA <= 20) entao
   result:= l * (4,30 - (4,30 * 3 / 100))
escreva(" O valor é:, " result)
senao
    se(codA > 20) entao
   result:= l * (4,30 - (4,30 *5 / 100))
escreva("O valor é:, " result)
 fimse
  fimse
   fimse
   se(cod="G")entao
   se(codG <= 20) entao
   result1:= l * 5,50 * 4 / 100
   escreva(" O valor é: " result1)
   senao
   se(codG > 20)entao
   result1:= l * (5,50 - (5,50 * 6 / 100))
 escreva("O valor é: " result1)
 fimse
 fimse
 fimse
fimalgoritmo
