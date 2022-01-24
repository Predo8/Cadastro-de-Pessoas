using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoas
{
    class CadPessoas
    {

        public static Menu()
        {
            var menuHora = new Menu();
            var menuOp = new MenuOp();
            bool validador = false;
            menuOp.MostrarMenu();
            menuHora.ApresentarHora();
            int opcao;
            string op;

            do
            {
                Console.Write("Opção: ");
                op = Console.ReadLine();
                if (op == "1")
                {
                    validador = true;
                }
                else if (op == "2")
                {
                    validador = true;
                }
                else if (op == "3")
                {
                    validador = true;
                }
                else if (op == "4")
                {
                    Console.WriteLine("Obrigado por usar o programa.");
                    validador = true;
                }
                else
                {
                    Console.WriteLine("Opção invalida!! Tente novamente!!");
                    validador = false;
                }
            
            } while (op != "1" && op != "2" && op != "3" && op != "4");

        }
        public static void Main()
        {
            FuncoesPessoa funcP = new FuncoesPessoa();
            List<Pessoa> lista = new List<Pessoa>();
            string nomePessoa = "";
            int id = 0, idade = 0;
            bool valida;
            var menu = new MenuOp();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            menu.MostrarMenu();

            int opcao = 0;
            while (opcao != 4)
            {
                opcao = Menu();
                Pessoa pessoa = new Pessoa();
                switch (opcao)
                {
                    case 1: //Cadastro
                        do
                        {
                            Console.WriteLine("||||||||||||| Cadastro de Pessoas |||||||||||||");

                            Console.Write("Nome: ");
                            pessoa.Nome = Console.ReadLine();
                            Console.Write("Altura: ");
                            pessoa.Altura = (int)Convert.ToDouble(Console.ReadLine());
                            bool validador = false;
                            do
                            {
                                Console.Write("Idade: ");
                                pessoa.Idade = Convert.ToInt32(Console.ReadLine());
                                if (pessoa.Idade == 0 || pessoa.Idade >= 100)
                                {
                                    Console.WriteLine("Idade não pode ser 0 ou maior que 100");
                                    validador = false;
                                }
                                else if (pessoa.Idade == 0 || pessoa.Idade >= 120)
                                {
                                    Console.WriteLine("Digite um numero valido!");
                                    validador = true;
                                }
                                validador = false;

                            } while (validador == true);

                            funcP.Inserir(pessoa);
                            lista = funcP.Listar(nomePessoa);

                            for (int i = 0; i < lista.Count; i++)
                            {
                                pessoa.Id++;
                            }
                            Console.WriteLine($"ID: {pessoa.Id}");
                            Console.WriteLine("Pessoa cadastrada com sucesso!");
                            valida = true;

                        } while (!valida);

                        Console.WriteLine("Não há nenhum dado cadastrado.");
                        Console.ReadKey();
                        break;

                    case 2: //Para excluir
                        Console.WriteLine("Listando as opções");
                        foreach (var p in funcP.Pessoas)
                        {
                            Console.WriteLine($"ID: {p.Id}");
                            Console.WriteLine($"Nome: {p.Nome}");
                            Console.WriteLine($"Altura: {p.Altura}");
                            Console.WriteLine($"Idade: {p.Idade}");
                        }

                        Console.WriteLine("Informe o id da pessoa: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        if (funcP.Excluir(id))
                        {
                            Console.WriteLine("Pessoa excluida com suceso!");
                            funcP.Excluir(id);
                        }
                        else
                        {
                            Console.WriteLine("Não foi possivel excluir. Tente novamente");
                        }
                        Console.WriteLine("Voltando para o incio. Precione em qualquer tecla");
                        Console.ReadKey();
                        break;

                    case 3: //Listar
                        foreach (var p in funcP.Pessoas)
                        {
                            Console.WriteLine($"ID: {p.Id}");
                            Console.WriteLine($"Nome: {p.Nome}");
                            Console.WriteLine($"Altura: {p.Altura}cm");
                            Console.WriteLine($"Idade: {p.Idade}");
                        }

                        Console.WriteLine("Não há nenhum cadastro.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
