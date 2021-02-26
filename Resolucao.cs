using System;

   class Program {
      static void Main(string[] args) {
         
         /*

         Exercicio 1

         Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem,
         utilizando um automóvel que faz 12 Km por litro. Para obter o cálculo, o usuário deve
         fornecer o tempo gasto (TEMPO) e a velocidade média (VELOCIDADE) durante a viagem.
         Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA ←
         TEMPO * VELOCIDADE. Possuindo o valor da distância, basta calcular a quantidade de
         litros de combustível utilizada na viagem com a fórmula LITROS_USADOS ← DISTANCIA
         / 12. Ao final, o programa deve apresentar os valores da velocidade média
         (VELOCIDADE), tempo gasto na viagem (TEMPO), a distância percorrida (DISTANCIA) e a
         quantidade de litros (LITROS_USADOS) utilizada na viagem.

         

         int qtd_km_lt = 12;
         float tmp_gasto = 0;
         float vel_media = 0;
         float distancia = 0;
         float qtd_lt_gasto = 0;
         //Isso pode parecer um gasto de memoria inutil, e é, mas eu quero deixar o codigo mais legivel possivel
         //Usando float pra conservar memoria

         Console.WriteLine("Insira o tempo gasto (Em horas) na viagem: ");
         tmp_gasto = float.Parse(Console.ReadLine());
         Console.WriteLine("Insira a velocidade media (Em km/h) na viagem: ");
         vel_media = float.Parse(Console.ReadLine());
         // Pegando valores
         
         distancia = tmp_gasto * vel_media;
         qtd_lt_gasto = distancia / qtd_km_lt;
         Console.WriteLine("A quantidade de litros gastos é {0} \nPois a viagem durou {1}h a {2}Km/h, percorrendo assim {3}Km"
            , qtd_lt_gasto.ToString("F"), tmp_gasto, vel_media, distancia); //ToString("F") para formatar o double

         */

         /*

         Exercicio 2

         Ler quatro números inteiros e apresentar o resultado da adição e multiplicação,
         baseando-se na utilização do conceito da propriedade distributiva. Ou seja, se forem
         lidas as variáveis A B, C, e D, devem ser somadas e multiplicadas A com B, A com C e A
         com D. Depois B com C, B com D e por fim C com D. Perceba que será necessário efetuar
         seis operações de adição e seis operações de multiplicação e apresentar doze resultados
         de saída.
         

         int[] numeros = new int[4];
         int soma = 0;
         int multiplicacao = 1;

         for(int index = 0; index < 4; index++){
            Console.WriteLine("Digite o numero para a {0}º inteiro", (index+1));
            numeros[index] = int.Parse(Console.ReadLine());
         } //Vou usar esse jeito com array para não ficar escrevendo 20 linhas de Console.WriteLine() e Console.ReadLine()

         for(int contador = 0; contador < 4; contador++){
            for(int contador2 = contador; contador2 <4; contador2++){
               if(contador != contador2){
                     multiplicacao *= numeros[contador] * numeros[contador2];
                     soma += numeros[contador] + numeros[contador2];
                  }
            }
         }
		   Console.WriteLine("A soma é {0} e a multiplicação é {1}", soma, multiplicacao);

         */

         /*

         Exercicio 3

         Elaborar um programa de computador que efetue a leitura de quatro valores inteiros
         (variáveis A B, C e D). Ao final o programa deve apresentar o resultado do produto
         variável P) do primeiro com o terceiro valor, e o resultado do produto (variável P) do
         primeiro com o terceiro valor, e o resultado da soma (variável S) do segundo com o
         quarto valor.
         
         int[] numeros = new int[4];
         for(int index = 0; index < 4; index++){
            Console.WriteLine("Digite o numero para a {0}º inteiro", (index+1));
            numeros[index] = int.Parse(Console.ReadLine());
         } //Lendo variaveis no array

         Console.WriteLine("O primeiro valor (" + numeros[0] + ") multiplicado pelo terceiro (" + numeros[2]+ ") é "
          + (numeros[0] * numeros[2]));
          Console.WriteLine("E a soma do segundo valor (" + numeros[1] + ") com o terceiro (" + numeros[3]+ ") é "
          + (numeros[0] + numeros[3]));

          */
         
         /*
         
         Exercicio 4

         Efetuar a leitura de três valores (variáveis A B e C) e apresentá-los dispostos em ordem
         crescente.
         

         int valor1;
         int valor2;
         int valor3;

         Console.WriteLine("Entre com o primeiro valor: ");
         valor1 = int.Parse(Console.ReadLine());
         Console.WriteLine("Entre com o segundo valor: ");
         valor2 = int.Parse(Console.ReadLine());
         Console.WriteLine("Entre com o terceiro valor: ");
         valor3 = int.Parse(Console.ReadLine());
         //Resolvi fazer desse jeito pra ficar mais visual, com array ficaria array[0] array[1] e imaginei que a leitura disso ficaria terrivel

         if (valor3 >= valor2)
            {
               if (valor2 >= valor1)
               {
                  Console.WriteLine("A ordem é: " + valor1 + " , " + valor2 + " , " + valor3);
               }
               else if (valor1 >= valor3)
               {
                  Console.WriteLine("A ordem é: " + valor2 + " , " + valor3 + " , " + valor1);
               }
               else
               {
                  Console.WriteLine("A ordem é: " + valor2 + " , " + valor1 + " , " + valor3);
               }

            }
            else if (valor3 >= valor1)
            {
               Console.WriteLine("A ordem é: " + valor1 + " , " + valor3 + " , " + valor2);
            }
            else if (valor2 >= valor1)
            {
               Console.WriteLine("A ordem é: " + valor3 + " , " + valor1 + " , " + valor2);
            }
            else { 
               Console.WriteLine("A ordem é: " + valor3 + " , " + valor2 + " , " + valor1);
            }
         */
                
         /*
         
         Exercicio 5

         Efetuar a leitura de quatro números inteiros e apresentar os números que são
         divisíveis por 2 e 3
         
         int[] numeros = new int[4];
         for(int index = 0; index < 4; index++){
            Console.WriteLine("Digite o numero para a {0}º inteiro", (index+1));
            numeros[index] = int.Parse(Console.ReadLine());
         } 

         for(int contador = 0; contador < 4; contador++){
            Console.Write("A primeira variavel é {0} e ", numeros[contador]);
            if(numeros[contador] % 2 == 0 && numeros[contador] % 3 == 0){
               Console.Write("é divisivel por 2 e por 3 \n");
            }else if (numeros[contador] % 2 == 0){
               Console.Write("é divisivel por dois \n");
            }else if(numeros[contador] % 3 == 0){
               Console.Write("é divisivel por três \n");
            }else{
               Console.Write("não é divisivel por nenhum dos dois \n");
            }
         }

         */

         /*
         
         Exercicio 6
         
         Efetuar a leitura de cinco números inteiros e identificar o maior e o menor valores.
		
	      int[] numeros = new int[5];
         int menor;
         int maior;
		 
         for(int index = 0; index < 5; index++){
            Console.WriteLine("Digite o numero para a {0}º inteiro", (index+1));
            numeros[index] = int.Parse(Console.ReadLine());
         }

         menor = numeros[0];
         maior = numeros[0];

         for (int contador = 1; contador < 5; contador++){
            if(numeros[contador] <= menor){  
               menor = numeros[contador];
            }
            if(numeros[contador] >= maior){
               maior = numeros[contador];
            }
         }
		   Console.WriteLine("O menor numero é {0} e o maior {1}", menor, maior);
         Console.WriteLine("Os numeros são: " + numeros[0] + " " +  numeros[1] + " " + numeros[2] + " " + numeros[3] + " " + numeros[4]);

         */
         

         /*
         
         Exercicio 7
         
         Receber três valores numéricos (A, B e C) referente aos lados de um triangulo, comparar
         os valores e informar que tipo de triangulo os lados formam. Equilátero – Todos os lados
         iguais. Isósceles – Dois lados iguais. Escaleno – Todos os lados diferentes.

         int lado_a;
         int lado_b;
         int lado_c;

         Console.WriteLine("Entre com o primeiro valor: ");
         lado_a = int.Parse(Console.ReadLine());
         Console.WriteLine("Entre com o segundo valor: ");
         lado_b = int.Parse(Console.ReadLine());
         Console.WriteLine("Entre com o terceiro valor: ");
         lado_c = int.Parse(Console.ReadLine());

         if(lado_a == lado_b && lado_b == lado_c){
            Console.WriteLine("Todos os lados são iguais, é um triangulo equilateros");
         }else if(lado_a == lado_b || lado_b == lado_c || lado_a == lado_c){
            Console.WriteLine("Somente dois lados são iguais, é um triangulo isoceles");
         }else{
            Console.WriteLine("Nenhum lado é igual, é um triangulo escaleno");
         }

         */

         /*
        
         Exercicio 8
         
         Elaborar um programa que efetue o cálculo da fatorial do número 5 e apresente o
         resultado final dessa operação. Onde para realizar tal calculo devemos realizar a
         multiplicação (1 * 2 * 3 * 4 * 5) use o loop de repetição enquanto.
         
         
         int numero;
         int fatorado = 1;

         Console.WriteLine("Digite um numero: ");
         numero = int.Parse(Console.ReadLine());

         Console.WriteLine("A fatoração é");
         for (int x = numero; x >= 1; x--){
            fatorado = x * fatorado;
            if(x != 1){
               Console.Write(x + " * ");
            } else{
               Console.Write(x + " = " + fatorado);
            }
         }

         */

         /*

         Exercicio 9
         
         Elaborar um programa que capaz de executar as quatro operações matemáticas (soma,
         subtração, multiplicação e divisão) seguindo as seguintes regras:
          O usuário deverá informar dois valores numéricos;
          O usuário deverá informar a operação que deseja executar;
          O programa deverá exibir o resultado;
          O programa deverá perguntar ao usuário se esse deseja realizar uma nova
         operação ou encerrar o programa;

         int encerrar = 1;
         int num_um = 0;
         int num_dois = 0;
         int opcao = 0;

         while(encerrar == 1){
            Console.WriteLine("Digite o primeiro numero: ");
            num_um = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            num_dois = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("O que quer fazer com os numeros {0} e {1}?", num_um, num_dois);
            Console.WriteLine("1. Somar");
            Console.WriteLine("2. Subtrair");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Divisão");
            opcao = int.Parse(Console.ReadLine());

            Console.Clear();

            if(opcao == 1){
              Console.WriteLine("O resultado da soma entre {0} e {1} é {2}", num_um, num_dois, (num_um + num_dois)) ;
            }else if(opcao == 2){
               Console.WriteLine("O resultado da subtração entre {0} e {1} é {2}", num_um, num_dois, (num_um - num_dois));  
            }else if(opcao == 3){
               Console.WriteLine("O resultado da multiplicação entre {0} e {1} é {2}", num_um, num_dois, (num_um * num_dois));
            }else if(opcao == 4){
               Console.WriteLine("O resultado da divisão entre {0} e {1} é {2}", num_um, num_dois, (num_um / num_dois));
            }

            Console.WriteLine("Quer fazer outra conta ou encerrar o programa?");
            Console.WriteLine("1. Fazer outra conta");
            Console.WriteLine("2. Encerrar");
            encerrar = int.Parse(Console.ReadLine());
         }
         */

         /*

      Exercicio 10

      Desenvolver um programa que leia dez nomes e os armazene em uma matriz logo em
      seguida o programa deverá apresentar esses dez nomes na tela.

      string[] nomes = new string[10];

      for(int index = 0; index <10; index++){
         Console.WriteLine("Digite o {0}º nome: ", (index+1));
         nomes[index] = Console.ReadLine();
      }

      foreach (var nome in nomes) //para cada nome, exbir nome
      {
         Console.WriteLine(nome);
      }
      */

      /*
      
      Exercicio 11
      
      Elaborar um programa que crie uma matriz chamada de “A” que deverá armazenar 10
      valores numéricos inteiro em seguida o programa devera multiplicar cada valor da
      matriz “A” por três armazenar o resultado em uma matriz chamada de “B” e exibir os
      valores de ambas as matrizes na tela.
      
      int[] A = new int[10];
      int[] B = new int[10]; //Instanciação de matriz

      for(int index = 0; index <10; index++){
			Console.WriteLine("Digite o {0}º inteiro: ", (index+1)); 
			A[index] = int.Parse(Console.ReadLine()); //Atribuição de valor
         B[index] = A[index] * 3; // Passando pra matriz B
		}
		for(int x = 0; x <10; x++){
			Console.WriteLine("O {0}º inteiro é: {1} e seu resultado em uma multiplicação por três é {2}", (x+1), A[x], B[x]); //Imprimindo
      }

      */

      /*
      
      Exercicio 12
      
      Desenvolver um programa que leia dez valores numéricos inteiros e os adicione a uma
      matriz chamada de “A” em seguida o programa deverá exibir a soma dos números
      impares dessa mesma matriz.
      
      int[] numeros = new int[10];
      int soma = 0;
      bool tem_impar = false; 

      //Vou usar esse boolean pra ver se teve pelo menos um impar
      //Dessa forma, consigo customizar a ultima mensagem 
      

      for(int index = 0; index <10; index++){
			 Console.Write("Digite o {0}º inteiro: ", (index+1)); 
			 numeros[index] = int.Parse(Console.ReadLine()); //Atribuição de valor
		}

      Console.Write("Os numeros impares são: ");

      foreach (var numero in numeros)
      {
          if(numero % 2 == 1){
             Console.Write(numero + " ");
             tem_impar = true;
             soma += numero;
          }
      }

      if(tem_impar == false){
         Console.Write("Não tem, logo a soma é zero"); //Aqui
      }else{
         Console.WriteLine("Logo a soma é " + soma);
      }
      

      */

		/*
      
      Exercio 13
      
      Desenvolver um programa que leia 10 valores numéricos inteiros e os armazene em uma
      matriz chamada de “A” em seguida o programa deverá ler a matriz “A” e verificar se o
      valor lido é par ou ímpar, se for par deverá multiplicar o valor por cinco se não deverá
      somar cinco, após essa operação o valor em questão deverá ser armazenado em uma
      outra matriz chamada de “B” e finalmente os valores de ambas as matrizes devem ser
      exibidos na tela.

      int[] A = new int[10];
      int[] B = new int[10];
      
      for(int index = 0; index <10; index++){
			 Console.Write("Digite o {0}º inteiro: ", (index+1)); 
			 A[index] = int.Parse(Console.ReadLine()); //Atribuição de valores
          if(A[index] % 2 == 0){ //Se for par
             B[index] = A[index] * 5;
          }else{
            B[index] = A[index] + 5;
          }
		}

      for(int x = 0; x <10; x++){
         Console.WriteLine("O {0}º inteiro é: {1} e o resultado é {2}", (x+1), A[x], B[x]);
      }

      */
      
   }
}