using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Cadastro
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public double Altura;

        public Pessoa(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }
    }

    public class CadastroList
    {
        public void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("=============================Data e Hora================================= ");
            String date = DateTime.Now.ToString("dd-MM-yyyy");
            String hora = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine(date);
            Console.WriteLine(hora);

            Console.Title = "Cadastro de Pessoas";
            Console.WriteLine("==================Programa de Cadastro de Pessoas ======================= ");

            string repetirOp = "s", entrada, operacao;
            List<string> lista;
            lista = new List<string>();

            var combo = new List<string>()
            {
                new Nome()
                new 
            }
            do
            {
                Console.WriteLine("Qual operação voce quer fazer");
                Console.WriteLine("1-Cadastro.");
                Console.WriteLine("2-Excluir.");
                Console.WriteLine("3-Listar todos os cadastros.");
                entrada = Console.ReadLine();
            }
            while (entrada != "1" && entrada != "2" && entrada != "3");

            do
            {
                Console.WriteLine("Deseja continuar(S/N):");
                repetirOp = Console.ReadLine().ToLower();
            }
            while (repetirOp != "s" && repetirOp != "n");
            
            switch (operacao)
            {
                case "1":
                  
            }
        }
    }
}