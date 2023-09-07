using Farmacia.Model;
using Farmacia.Repository;
using System.ComponentModel.Design;

namespace Farmacia
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            string sn;

            int id, tipo;
            string nome,
                generico,
                fragrancia;
            decimal preco;

            ProdutoController produto = new();


            while (opcao != 6)
            {
            inicio:
                Console.Clear();
                Console.WriteLine("                                                ");
                Console.WriteLine("                                                ");
                Console.WriteLine("                                                ");
                Console.WriteLine("         Bem vindos à Farmácia Dentritos Felizes");
                Console.WriteLine("        ========================================");
                Console.WriteLine("         [1]                       Criar Produto");
                Console.WriteLine("         [2]                     Listar Produtos");
                Console.WriteLine("         [3]            Consultar Produto por ID");
                Console.WriteLine("         [4]                   Atualizar Produto");
                Console.WriteLine("         [5]                     Deletar Produto");
                Console.WriteLine("         [6]                                Sair");
                Console.WriteLine("        ========================================");
                Console.WriteLine("                                                ");
                Console.WriteLine("                                                ");
                Console.WriteLine("                                                ");

                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                catch (FormatException)
                {
                    opcao = 0;
                }

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o ID do produto: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o nome do produto: ");
                        nome = Console.ReadLine()!;

                        do
                        {
                            Console.WriteLine("Digite o tipo do produto: ");
                            tipo = Convert.ToInt32(Console.ReadLine());
                        } while (tipo != 1 && tipo != 2);

                        Console.WriteLine("Digite o preço do produto: ");
                        preco = Convert.ToDecimal(Console.ReadLine());

                        switch (tipo)
                        {
                            case 1:
                                Console.WriteLine("Insira o nome do seu medicamento genérico: ");
                                generico = Console.ReadLine()!;

                                produto!.CriarProduto(new Medicamento(produto.ContadorProduto(), nome, tipo, preco, generico));
                                break;

                            case 2:
                                Console.WriteLine("Insira a fragrancia do seu perfume: ");
                                fragrancia = Console.ReadLine()!;

                                produto!.CriarProduto(new Cosmetico(produto.ContadorProduto(), nome, tipo, preco, fragrancia));
                                break;
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("Listar todos os produtos: ");
                        produto!.ListarTodosProdutos();
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Digite o ID do produto para consultá-lo: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        produto!.ConsultarPorID(id);

                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Digite o número do ID: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        produto!.BuscarNaCollection(id);

                        if (produto is not null)
                        {
                            Console.WriteLine("Digite o nome do produto: ");
                            nome = Console.ReadLine()!;

                            Console.WriteLine("Digite o preço do produto: ");
                            preco = Convert.ToDecimal(Console.ReadLine());

                            do
                            {
                                Console.WriteLine("Digite o tipo do produto: ");
                                tipo = Convert.ToInt32(Console.ReadLine());
                            } while (tipo != 1 && tipo != 2);


                            switch (tipo)
                            {
                                case 1:
                                    Console.WriteLine("Insira o nome do seu medicamento genérico: ");
                                    generico = Console.ReadLine()!;

                                    produto.AtualizarProduto(new Medicamento(id, nome, tipo, preco, generico));
                                    break;

                                case 2:
                                    Console.WriteLine("Insira a fragrancia do seu perfume: ");
                                    fragrancia = Console.ReadLine()!;

                                    produto.AtualizarProduto(new Cosmetico(id, nome, tipo, preco, fragrancia));
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado");
                        }
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("Digite o ID do produto que deseja deletar: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        produto!.DeletarProduto(id);
                        break;

                    case 6:
                        Console.WriteLine("Tem Certeza que de deseja sair ??");
                        Console.WriteLine("   [S]                      [N]  ");
                        sn = Console.ReadLine()!.ToUpper();

                        if (sn == "N")
                        {
                            goto inicio;
                        }
                        else
                        {
                            Console.WriteLine("Obrigado por usar o programa =)");
                        }
                        break;
                }


            }
        }

    }
}
