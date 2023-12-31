﻿using Farmacia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Repository
{
    public interface IProdutoRepository
    {
        public void CriarProduto(Produto produto);
        public void ListarTodosProdutos();
        public void ConsultarPorID(int id);
        public void AtualizarProduto(Produto produto);
        public void DeletarProduto(int id);
    }
}
