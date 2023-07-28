using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlExercicios control = new ControlExercicios();
            control.Operacao();
            Console.ReadLine(); //Manter o prompt Aberto
        }//fim do método main
    }//fim da classe program
}//fim do projeto calculadora
