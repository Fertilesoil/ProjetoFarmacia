using Farmacia.Model;
using Farmacia.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia
{
    public class ProdutoController : IProdutoRepository
    {
        private readonly List<Produto> ListaProdutos = new();
        int numero = 0;

        public void AtualizarProduto(Produto produto)
        {
            var buscarProduto = BuscarNaCollection(produto.GetId());
            if (buscarProduto is not null)
            {
                var index = ListaProdutos.IndexOf(buscarProduto);
                ListaProdutos[index] = produto;
                Console.WriteLine($"O Produto {produto.GetNome()} do tipo {produto.GetTipo()} foi atualizado!");
            }
        }

        public void ConsultarPorID(int id)
        {
            var produto = BuscarNaCollection(id);

            if (produto is not null)
                produto.Mostrar();
            else
                Console.WriteLine("Produto não encontrado");
        }

        public void DeletarProduto(int id)
        {
            var produto = BuscarNaCollection(id);

            if (produto is not null)
            {
                ListaProdutos.Remove(produto);
                Console.WriteLine($"Produto {produto.GetNome()} do tipo {produto.GetTipo()} foi removido!");
            }
            else
            {
                Console.WriteLine("Produto não foi encontrado");
            }
        }

        public void ListarTodosProdutos()
        {
            foreach (var conta in ListaProdutos)
            {
                conta.Mostrar();
            }
        }

        // Para guardar números na lista em ordem
        public int ContadorProduto()
        {
            return ++numero;
        }

        public void CriarProduto(Produto produto)
        {
            ListaProdutos.Add(produto);
            Console.WriteLine($"Seu produto {produto.GetNome()} do tipo {produto.GetTipo()} foi cadastrado!");
        }
        
        public Produto? BuscarNaCollection(int id)
        {
            foreach (var produto in ListaProdutos)
            {
                if (produto.GetId() == id)
                    return produto;
            }
            return null;
        }
    }
}

 
    
    
    
    
    
    
  
