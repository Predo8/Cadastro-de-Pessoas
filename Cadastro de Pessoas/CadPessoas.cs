using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoas
{
    class CadastroPessoas
    {
        public static int Menu()
        {
            string operacao;
            var menuOp = new MenuOp();
            bool validador = false;
            menuOp.MostrarMenu();
            decimal opcao;

            do
            {
                Console.Write("Opção: ");
                operacao = Console.ReadLine();
                if (operacao == "1")
                {
                    validador = true;
                }
                else if (operacao == "2")
                {
                    validador = true;
                }
                else if (operacao == "3")
                {
                    validador = true;
                }
                else if (operacao == "4")
                {
                    validador = true;
                }
                else
                {
                    Console.WriteLine("Opção invalida! Tente novamente!");
                    validador = false;
                }
                //decimal opi = Convert.ToDecimal(operacao);
                //opcao = opi;
            } while (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4");
            return Convert.ToInt32(operacao);
        }
        public static void Main()
        {
            FuncoesPessoa funcP = new FuncoesPessoa();
            List<Pessoa> lista = new List<Pessoa>();
            string nomePessoa = "", entrada, entradadois;
            int id = 0, idade = 0;
            bool valida, valido, validador;
            decimal isNumero;
            var versao = new Menu();
            versao.ApresentarHora();

            int opcao = 0;
            while (opcao != 4)
            {
                opcao = Convert.ToInt32(Menu());
                Pessoa pessoa = new Pessoa();
                switch (opcao)
                {
                    case 1: // inserir
                        do
                        {
                            Console.WriteLine("--------------------- Cadastrar Pessoas -----------------------");

                            Console.Write("Nome: ");
                            pessoa.Nome = Console.ReadLine();
                            do
                            {
                                Console.Write("Altura: ");
                                entrada = Console.ReadLine();
                                pessoa.Altura = Convert.ToDecimal(decimal.TryParse(entrada, out isNumero));
                                validador = false;
                                valido = decimal.TryParse(entrada, out isNumero);
                                if (!valido)
                                {
                                    Console.WriteLine("Digite um número válido.");
                                }
                            }
                            while (!valido);
                            //return Convert.ToInt32(isNumero);

                            do
                            {

                                Console.Write("Idade: ");
                                entradadois = Console.ReadLine();
                                pessoa.Idade = Convert.ToDecimal(decimal.TryParse(entrada, out isNumero));
                                valido = decimal.TryParse(entradadois, out isNumero);

                                if (pessoa.Idade == 0 || pessoa.Idade >= 100)
                                {
                                    Console.WriteLine("Idade não pode ser 0 ou maior que 100");
                                    validador = false;
                                }
                                
                                else if (!valido)
                                {
                                    Console.WriteLine("Digite um número válido.");
                                }
                                validador = false;

                            } while (!valido);

                            funcP.Inserir(pessoa);
                            lista = funcP.Listar(nomePessoa);

                            for (int i = 0; i < lista.Count; i++)
                            {
                                pessoa.Id++;
                            }
                            Console.WriteLine($"ID: {pessoa.Id}");
                            Console.WriteLine("Pessoa Cadastrada com sucesso.");
                            valida = true;

                        } while (!valida);

                        Console.WriteLine("Voltando para o menu. Clique em qualquer tecla");
                        Console.ReadKey();
                        break;

                    case 2: //Excluir
                        Console.WriteLine("---------------------- Excluir Pessoas -----------------------");
                        Console.WriteLine("Listando as opções");
                        foreach (var p in funcP.Pessoas)
                        {
                            Console.WriteLine($"ID: {p.Id}");
                            Console.WriteLine($"Nome: {p.Nome}");
                            Console.WriteLine($"Altura: {p.Altura}cm");
                            Console.WriteLine($"Idade: {p.Idade}");
                            Console.WriteLine("--------------------------------------------------------------");
                        }

                        Console.Write("Informe o id da pessoa: ");
                        id = Convert.ToInt32(Console.ReadLine());


                        if (funcP.Excluir(id))
                        {
                            Console.WriteLine("Pessoa excluida com sucesso!");
                            funcP.Excluir(id);
                        }
                        else
                        {
                            Console.WriteLine("Não foi possivel excluir a pessoa!");

                        }
                        Console.WriteLine("Voltando para o menu. Clique em qualquer tecla");
                        Console.ReadKey();
                        break;

                        case 3: //lista tudo
                        if (funcP.Pessoas.Count > 0)
                        {
                            Console.WriteLine("-------------------- Listar todas Pessoas --------------------");
                            foreach (var p in funcP.Pessoas)
                            {
                                Console.WriteLine($"ID: {p.Id}");
                                Console.WriteLine($"Nome: {p.Nome}");
                                Console.WriteLine($"Altura: {p.Altura}cm");
                                Console.WriteLine($"Idade: {p.Idade}");
                                Console.WriteLine("--------------------------------------------------------------\n");

                            }
                        }
                        else
                        {
                            Console.WriteLine("Não há pessoas cadastradas");
                        }
                        Console.WriteLine("Voltando para o menu. Clique em qualquer tecla");
                        Console.ReadKey();
                        break;

                    case 4: //fechamento do programa
                        Console.WriteLine("Obrigado por usar o programa.");
                        break;
                }

            }

        }
    }
}