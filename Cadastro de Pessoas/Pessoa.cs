using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoas
{
    public class Pessoa
    {
        private int id;
        private string nome;
        private decimal idade;
        private decimal altura;

        public Pessoa()
        {
            this.Id = 0;
            this.Nome = "";
            this.Idade = 0;
            this.Altura = 0;
        }

        public Pessoa(int id, string nome, decimal idade, decimal altura)
        {
            this.Id = id;
            this.Nome = nome;
            this.Idade = idade;
            this.Altura = altura;
        }

        public int Id
        {
            get { return this.id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

        public decimal Idade
        {
            get { return this.idade; }
            set { this.idade = value; }
        }

        public decimal Altura
        {
            get { return this.altura; }
            set { this.altura = value; }
        }
    }
}
