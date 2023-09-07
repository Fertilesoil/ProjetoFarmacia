using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia
{
    public abstract class Produto
    {
        int id;
        string nome;
        int tipo;
        decimal preco;

        public Produto(int id, string nome, int tipo, decimal preco)
        {
            this.id = id;
            this.nome = nome;
            this.tipo = tipo;
            this.preco = preco;
        }

        public int GetId()
        { return this.id; }

        public void SetId(int id)
        { this.id = id; }

        public string GetNome()
        { return this.nome; }

        public void SetNome(string nome)
        { this.nome = nome; }

        public int GetTipo()
        { return this.tipo; }

        public void SetTipo(int tipo)
        { this.tipo = tipo; }

        public decimal GetPreco()
        { return this.preco; }

        public void SetPreco(decimal preco)
        { this.preco = preco; }

        public virtual void Mostrar()
        {
            string tipo = string.Empty;
            switch (this.tipo)
            {
                case 1:
                    tipo = "Medicamento";
                    break;

                case 2:
                    tipo = "Cosmético";
                    break;
            }
            Console.WriteLine($"O ID do produto é: {this.id}");
            Console.WriteLine($"O tipo do produto é: {tipo}");
            Console.WriteLine($"O Nome do seu produto é: {this.nome}");
            Console.WriteLine($"O Preço do seu produto é: {this.preco:c}");
        }
    }
}
