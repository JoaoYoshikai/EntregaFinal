using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Exercicios
    {
        //Criando o objeto exercicio dentro da memória
        ModelCalculadora exer;

        public Exercicios()
        {
            this.exer = new ModelCalculadora();
        }//fim do construtor

        public double Exercicio1(int num)
        {

            return num * 2;
        }//Fim do exercicio 1 dobro

        public double Exercicio1Triplo(int num)
        {

            return num * 3;

        }//Fim do exercicio 1 triplo

        public double Exercicio2(int salario)
        {

            return salario * 0.3 + salario;
        }//Fim do exercicio 2

        public string Exercicio3(int numero)
        {

            if (numero < 0)
            {
                return Convert.ToString(numero) + "é negativo!";
            }
            else
            {
                return Convert.ToString(numero) + "é positivo!";
            }//Fim do if

        }//Fim do exercicio 3


        public string Exercicio3ImparPar(int numero)
        {
            string msg;
            msg = "";

            if (numero % 2 == 0)
            {
                msg = Convert.ToString(numero) + "É par!";
            }
            else
            {
                msg = Convert.ToString(numero) + "É ímpar!";
            }
            return msg;
        }//Fim Exercicio3ImparPar


        public double Exercicio4()
        {
            double resultado;
            resultado = 0;

            for (int i = 0; i <= 100; i++)
            {
                resultado = resultado + i;
            }
            return resultado;
        }//Fim do exercicio 4

        public string Exercicio5(int nume, int tabuada)
        {
            string resultado = "";
            int i;
            i = 0;

            for (i = 0; i <= nume; i++)
            {
                resultado += "\n" + tabuada + " * " + i + " = " + (tabuada * i);
            }//fim do for
            return resultado;
        }//Fim exercicio 5

        public string Exercicio6(double numInicial, double numFinal)
        {
                double i;
                i = 0;
                string msg = "";
            for (i = numInicial; i <= numFinal; i++)
            {
                msg += "\n" + i;
            }//Fim do if
            return msg;
        }//Fim exercicio 6

        public string Exercicio7()
        {
            double i;
            i = 0;
            string msg = "";
            
                for (i = 100; i <= 200; i++)
                {
                        if (i % 2 != 0)
                        msg += "\n" + i;
                }//Fim do for           
                return msg;
        }//Fim exercicio 7

        public int exercicio8(int numer) 
        {        
            int i = 0;
            int contador = 0;
   
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine("Informe um número: ");
                numer = Convert.ToInt32(Console.ReadLine());
                contador += numer; 
                numer = 0;
            }// fim do for
                return contador;
        }//fim Exercicio 8

        public int exercicio9()
        {
            int contador = 0;
            int numerin = 0;
            do
            {
                Console.WriteLine("Informe um número: ");
                numerin = Convert.ToInt32(Console.ReadLine());
                contador += numerin;
            } while (numerin != 0);
            return contador;
        }//fim Exercicio 9

        public double exercicio10()
        {
            double numerozinho;
            double contador = 0;
            double resultado = 0;
            do
            {
                Console.WriteLine("Informe um número!");
                numerozinho = Convert.ToDouble(Console.ReadLine());
                if (numerozinho % 2 == 0)
                {
                    contador += 1;
                    resultado += numerozinho;
                }//Fim do if
                } while (numerozinho != 0); //Fim do do while
            return (resultado / (contador - 1) );
        }//Exercicio 10

        public string exercicio11()
        {
            int maior = 0;
            int menor = 0;
            Boolean flag = false;
            int numeroso = 0;
            string msg = "";

            do
            {
                Console.WriteLine("Informe um número: ");
                numeroso = Convert.ToInt32(Console.ReadLine());
                if(flag == false)
                {
                    maior = numeroso;
                    menor = numeroso;
                    flag = true;
                }
                
                if (numeroso != 0)
                {
                    if (numeroso > maior)
                    {
                        maior = numeroso;
                    }//Fim do if
                    if (numeroso < menor)
                    {
                        menor = numeroso;
                    }//Fim do if
                
                }//Fim do ifzão
                
              
                msg = ("O maior número é: " + maior +  " e o menor número é: " + menor);  

            } while (numeroso != 0); // Fim do Do - While
            return msg;
        }//Exercicio 11 

        public string exercicio12()
        {
            int numerico = 0;
            int contador = 0;
            int contadorDois = 0;
            string msg = "";
            
            for (int i = 0; i < 20; i++)
            {
             Console.WriteLine("Informe um número: ");
             numerico = Convert.ToInt32(Console.ReadLine());
                

                if (numerico > 0)
                {
                    contador += numerico;
                }
                else
                {
                    contadorDois = contadorDois + 1;
                }//Fim do elza sua quenga
            }//Fim do for       
           return msg = ("A soma dos números pares é " + contador + " e a quantidade de números negativos é: " + contadorDois); 
        }//Fim do exercicio 12

        public int exercicio13(int numerinzin)
        {
            int resultado = 1;
          
            for (int i = 1; i <= numerinzin; i++)
            {
                 resultado = i * resultado;
            }//Fim do for       
            return resultado;
        }//Exercicio 13

        public int exercicio14(int qtdeJogador)
        {
            int alturaJogador = 0;
            int contador = 0;
            int media = 0;
            for (int i = 1; i <= qtdeJogador; i++ )
            {
                Console.WriteLine("Informe a altura do " + i +"º Jogador em cm: ");
                alturaJogador = Convert.ToInt32(Console.ReadLine());
                contador += alturaJogador;
            }//Fim do for
            media = contador / qtdeJogador;
            return media;
        }//Exercicio 14

        public string Exercicio15()
        {
            int maiorNota = 0;
            string maiorMiss = "";
  
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Insira o nome da " + i + "ª miss: ");
                string nomeMiss = Console.ReadLine();

                Console.WriteLine("Insira sua nota: ");
                int notaMiss = Convert.ToInt32(Console.ReadLine());
                
                if (notaMiss < 0 || notaMiss > 10)
                {
                    Console.WriteLine("Insira um valor entre 0 e 10! ");
                    notaMiss = 0;
                    nomeMiss = "";
                    i = i - 1;
                }
                else
                {
                if (notaMiss > maiorNota)
                {
                    maiorNota = notaMiss;
                    maiorMiss = nomeMiss;
                    
                }//Fim do if
                }
            }//Fim do for
            return ("A miss: " + maiorMiss + " com a nota: " + maiorNota + " foi a campeã do torneio!");
        }//Exercicio 15

        public string Exercicio16(double totalEleitores, double votosBrancos, double votosNulos, double votosValidos)
        {
            string msg = "";
            
            double pBranco = votosBrancos / totalEleitores * 100;
            double pNulos = votosNulos / totalEleitores * 100;
            double pValidos = votosValidos / totalEleitores * 100;
               
            msg = ("Votos brancos: " + pBranco + "%" + " Votos nulos: " + pNulos + "%" + " Votos válidos" + pValidos + "%");
            return msg;
        }//Exercicio 16

        public double Exercicio17(double custoFabrica)
        {
            double finalConsumidor = 0;

            finalConsumidor = ((custoFabrica * 0.28) + custoFabrica) + ((custoFabrica * 0.45) + custoFabrica);

            return finalConsumidor;
        }//Exercicio17

        public int Exercicio18(int anos, int meses, int dias)
        {
            int idade = 0;

            idade = ((anos * 365) + (meses * 30) + (dias));
            return idade;
        }//Exercicio 18

        public int Exercicio19()
        {
            int maiorValor = 0;

            int[] valores = new int[5];
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(i + 1 + "º valor: ");
                valores[i] = Convert.ToInt32(Console.ReadLine());
                if (valores[i] > maiorValor)
                {
                    maiorValor = valores[i];
                }//fim do if
            }//fim do for           
            return maiorValor;
        }//Exercicio 19

        public void Exercicio20()
        {
            int[] im = new int[5];

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(i + 1 + "º Valor ímpar: ");
                im[i] = Convert.ToInt32(Console.ReadLine());
                if (im[i] % 2 == 0) 
                {
                    Console.WriteLine("Insira um número ímpar! ");
                    im[i] = 0;
                    i = i - 1;
                }//fim do if
                }//fim do for
            int[] par = new int[5];

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(i + 1 + "º Valor par: ");
                par[i] = Convert.ToInt32(Console.ReadLine());
                if (par[i] % 2 != 0)
                {
                    Console.WriteLine("Insira um número par! ");
                    par[i] = 0;
                    i = i - 1;
                }//fim do if
            }//fim do for

            for (int i = 1; i<=9; i++)
            {
                if (im[i] > par[i])
                {
                    Console.WriteLine(par[i]);
                }
                else
                {
                    Console.WriteLine(im[i]);
                }
            }//Fim do for
        }//Exercicio 20



    }//Fim da classe
}//Fim do projeto
