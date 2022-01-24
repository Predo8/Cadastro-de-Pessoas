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
        private int idade;
        private double altura;

        public Pessoa()
        {
            this.Id = 0;
            this.Nome = "";
            this.Idade = 0;
            this.Altura = 0;
        }

        public Pessoa(int id, string nome, int idade, double altura)
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

        public int Idade
        {
            get { return this.idade; }
            set { this.idade = value; }
        }

        public double Altura
        {
            get { return this.altura; }
            set { this.altura = value; }
        }
    }
}
