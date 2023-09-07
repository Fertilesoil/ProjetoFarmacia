using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    public class Medicamento : Produto
    {
        private string generico = string.Empty;
        public Medicamento(int id, string nome, int tipo, decimal preco, string generico)
        :base(id, nome, tipo, preco)
        {
            this.generico = generico;
        }

        public string GetGenerico()
        { return generico; }

        public void SetGenerico(string generico)
        { this.generico = generico; }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"O nome genérico do produto é: {this.generico}.");
        }
    }
}
