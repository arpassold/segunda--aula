# Projeto Entra21

# Projeto Entra21

### Escrevendo e lendo do console
    //Escrever
    Console.WriteLine("Qual dua idade?");

 //Ler e salvar o resultado
    var result= Console.ReaLine();

### Declarando Variáveis e constantes
   var text = "meu texto"
   string text = "meu texto"
   const string text = "meu texto"

### Tipos Básicos
   // Tipo numérico/int
    var number = 1
 

   // Tipo texto/String
    var  text = "meu texto"

   // Tipo booleano/bool
    var  boolean = true

   // Tipo numérico com ponto flutuante/double
    var  price = 4.099

   // Tipo Data/DateTime
    var  currentDate = DateTime.Now

### Parsers/ Transformadores
   // Transforma um texto/ string em um numero/int
    var userAge = Int32.Parse(result);

### Operadores de comparação
#### (toda comparção retorna um booleno/bool)
    // É igual?
    1 == 1;
    // vai retornar true

    // É diferente?
     1 != 1;
    // vai retornar false

    // É diferente?
     !(1 == 1);
    // vai retornar false

    // É maior ou igual a 1?
      1 >= 1;
    // vai retornar true

    // É maior a 1?
      1 > 1;
    // vai retornar false

    // Booleano da esquerda é true e o da direita tambem?
      true && true;
    // vai retornar true

    // Booleano da esquerda é true ou o da direita é true?
      false|| true;
    // vai retornar true


### Operadores de matemática
    // somar
    1 + 1;

    // Subtrair
     1 - 1;

    // Dividir
     2 / 1;

    // Multiplicar
      1 * 2;

    // Resto
      3 % 2;
    // vai retornar 1

### Bloco condicionais
    // Escrevendo olá SOMENTE 1 > 0
    if (1 > 0)
    {
    Console.WriteLine ("olá");
    }

    // Caso 1 NÃO for maior que 0, e 2 > 1, ecreva Boa Tarde!
    else if (2 > 1)
    {
    Console.WriteLine ("Boa Tarde!");
    }
    // Caso 1 NÃO for maior que 0, escreva ("Tchau!");
    else
    {
    Console.WriteLine ("Tchau!");
    }



### Comandos do editor
    Selecionando o texto:
Segurar a tecla shift e utilizar as setas

comando para comentar:
CTRL + K + C

Comando para descomentar
CTRL + K + U

Comando para desfazer
CTRL + Z

Comando para refazer
CTRL + Y

Comando para descomentar
CTRL + Y

### Depurando a aplicação

1. Clicar na baratinha e depois no botão de engrenagem; 

2. Selecionar texto '.NET core'

3. Alterar a opção "console" para "integradedTerminal"

4. Adicionar quantos breakpoints quiser (clicar na esquerda do numero da linha).

5. Clicar na baratinha e no botão Start (verdinho)

6. Selecionar o terminal (sair na tab "Debug Console")

7. F10 para ir para a próxima linha.

8. F5 para o próximo breakpoint.

9. Shift + F5 para "matar" a aplicação.

10. CTRL + Shift + F5 para reiniciar o debug.