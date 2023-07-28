using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
     class ControlExercicios
    {
        Exercicios ControlExer;
        

        public ControlExercicios()
        {
            
            this.ControlExer = new Exercicios();
        }//Fim do método construtor

        public int Menu()
        {
            Console.WriteLine("------ Menu -------" +
                              "\n1. Exercício 1" +
                              "\n2. Exercício 2 " +
                              "\n3. Exercício 3 " +
                              "\n4. Exercício 4" +
                              "\n5. Exercício 5" +
                              "\n6. Exercício 6" +
                              "\n7. Exercício 7" +
                              "\n8. Exercício 8" +
                              "\n9. Exercício 9 " +
                              "\n10. Exercício 10" +
                              "\n11.Exercício 11" +
                              "\n12.Exercício 12" +
                              "\n13.Exercício 13" +
                              "\n14.Exercício 14" +
                              "\n15.Sair: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }//fim do método Menu


        public void Operacao()
        {
            int opcao = 0;
            do
            {
                opcao = Menu();
                Console.Clear();//Limpa a tela
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.ControlExer.Exercicio1(num));
                        Console.WriteLine(this.ControlExer.Exercicio1Triplo(num));
                        break;
                    case 2:
                        Console.WriteLine("Informe o salário: ");
                        int salario = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("O salário final é: " + this.ControlExer.Exercicio2(salario));                       
                        break;
                    case 3:
                        Console.WriteLine("Informe um número: ");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("O número é:" + this.ControlExer.Exercicio3(numero));
                        Console.WriteLine("O número é:" + this.ControlExer.Exercicio3ImparPar(numero));
                        break;
                    case 4:
                        Console.WriteLine("O resultado é:" + this.ControlExer.Exercicio4());
                        break;
                    case 5:
                        Console.WriteLine("Informe um número: ");
                        int nume = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe um a tabuada: ");
                        int tabuada = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("O número é:" + this.ControlExer.Exercicio5(nume, tabuada));
                        break;
                    case 6:
                        Console.WriteLine("Informe um número inicial");
                        double numInicial = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe um número final");
                        double numFinal = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Os números são:" + this.ControlExer.Exercicio6(numInicial, numFinal));
                        break;
                    case 7:
                        Console.WriteLine("Os número ímpares de 100 até 200 são: " + this.ControlExer.Exercicio7());
                        break;
                    case 8:
                        int numer =  Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("O resultado da soma dos números é: " + this.ControlExer.exercicio8(numer));
                        break;
                    case 9:
                        Console.WriteLine("O resultado da soma dos números é: " + this.ControlExer.exercicio9());
                        break;
                    case 10:
                        Console.WriteLine("O resultado da média dos números pares é: " + this.ControlExer.exercicio10());
                        break;
                    case 11:
                        Console.WriteLine(this.ControlExer.exercicio11());
                        break;
                    case 12:
                        Console.WriteLine(this.ControlExer.exercicio12());
                        break;
                    case 13:
                        Console.WriteLine("Informe um número para calcular o fatorial: ");
                        int numerinzin = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.ControlExer.exercicio13(numerinzin));
                        break;
                    case 14:
                        Console.WriteLine("Informe a quantidade de jogadores do time: ");
                        int qtdeJogador = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("A altura média do time de volei é: " + this.ControlExer.exercicio14(qtdeJogador) + "Cm.");
                        break;
                    case 15:
                        Console.WriteLine(this.ControlExer.Exercicio15());
                        break;
                    case 16:
                        Console.WriteLine("Informe a quantidade de eleitores:");
                        double totalEleitores = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a quantidade de votos brancos: ");
                        double votosBrancos = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a quantidade de votos nulos: ");
                        double votosNulos = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a quantidade de votos válidos: ");
                        double votosValidos = Convert.ToDouble(Console.ReadLine());
                        
                        
                        Console.WriteLine("O percentual de votos válidos, brancos e nulos são respectivamente: " + this.ControlExer.Exercicio16(totalEleitores, votosBrancos, votosValidos, votosNulos));
                        break;

                    case 17:
                        Console.WriteLine("Informe o custo de fábrica do automóvel: ");
                        double custoFabrica = Convert.ToInt32(Console.ReadLine());                     
                        Console.WriteLine("O custo final para o consumidor é" + this.ControlExer.Exercicio17(custoFabrica));
                        break;
                    case 18:
                        Console.WriteLine("Informe sua idade em anos, meses e dias.: ");
                        Console.WriteLine("Anos: ");
                        int anos= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Meses: ");
                        int meses = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dias: ");
                        int dias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Sua idade em dias é: " + this.ControlExer.Exercicio18(anos, meses, dias));
                        break;
                    case 19:
                        Console.WriteLine(this.ControlExer.Exercicio19());
                        break;
                    case 20:
                        this.ControlExer.Exercicio20();
                        break;
                }//fim do switch 
            } while (opcao != 15);//fim do Do...while
        
        
        
        }
    }//Fim da classe
}//Fim do projeto
