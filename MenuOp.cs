using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoas
{
    class MenuOp
    {
        public string Menu()
        {
            return string.Format("================= PROGRAMA DE CADASTRO DE PESSOAS =============" +
            "\nO que você deseja fazer?" +
            "\n1 - Cadastrar uma nova Pessoa" +
            "\n2 - Excluir algum registro" +
            "\n3 - Listar todas as pessoas" +
            "\n4 - Sair");
        }

        public void MostrarMenu()
        {
            Console.WriteLine(Menu());
        }
    }
}
