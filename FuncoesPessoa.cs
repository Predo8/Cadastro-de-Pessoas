using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoas
{
    public class FuncoesPessoa
    {
        private List<Pessoa> pessoas;

        public List<Pessoa> Pessoas
        {
            get { return pessoas; }
        }

        public FuncoesPessoa()
        {
            pessoas = new List<Pessoa>();
        }

        public bool Inserir(Pessoa pessoa)
        {
            bool resultado, validador = false;
            string idade;
            Pessoa p = Pessoas.Find(x => x.Id == pessoa.Id);

            if (p == null)
            {
                pessoas.Add(pessoa);
                resultado = true;
            }
            else
            {
                Console.WriteLine("Digite um ID valido");
                resultado = false;
            }
            return resultado;
        }

        public bool Excluir(int id)
        {
            Pessoa p = Pessoas.Find(x =>x.Id == id);
            bool resultado = false;

            if (p != null)
            {
              resultado = pessoas.Remove(p);
            }
            return resultado;
        }

        public List<Pessoa> Listar(string nome)
        {
            List<Pessoa> listaP = pessoas.FindAll(x => x.Nome.Contains(nome.ToUpper()));
            return listaP;
        }

        public List<Pessoa> ListarP()
        {
            List<Pessoa> listarP = pessoas.ToList();
            return listarP;
        }
    }
}
