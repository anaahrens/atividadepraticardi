using System.Runtime.CompilerServices;

namespace AtividadeAvaliativa
{
    public class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            int opcao = 0;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Cadastrar Pessoa");
                Console.WriteLine("2 - Cadastrar Livro");
                Console.WriteLine("3 - Emprestar Livro");
                Console.WriteLine("4 - Devolver Livro");
                Console.WriteLine("5 - Listar todos os livros");
                Console.WriteLine("6 - Listar todas as pessoas cadastradas");
                Console.WriteLine("7 - Listar todos os livros emprestados");
                Console.WriteLine("0 - Sair");

                Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        #region Add a new person to the list while checking if the id alreadz exists
                        Console.WriteLine("Cadastro de Pessoa:");
                        Console.Write("Id: ");
                        int idPessoa = int.Parse(Console.ReadLine());

                         
                        if (biblioteca.VerifyPersonId(idPessoa))
                        {
                            Console.WriteLine("Pessoa já cadastrada.");

                            break;
                        }

                        Console.Write("Nome: ");
                        string nomePessoa = Console.ReadLine();
                        Console.Write("CPF: ");
                        string cpfPessoa = Console.ReadLine();
                        Console.Write("Telefone: ");
                        string telefonePessoa = Console.ReadLine();
                        Pessoa novaPessoa = new Pessoa(idPessoa, nomePessoa, cpfPessoa, telefonePessoa);
                        biblioteca.CadastrarPessoa(novaPessoa);
                        Console.WriteLine("Pessoa cadastrada com sucesso!");
                        break;
                        #endregion

                    case 2:
                        Console.WriteLine("Cadastro de Livro:");
                        Console.Write("Id: ");
                        int idLivro = int.Parse(Console.ReadLine());
                        if (biblioteca.VerifyBookId(idLivro))
                        {
                            Console.WriteLine("Livro já cadastrado.");
                            break;
                        }
                        Console.Write("Título: ");
                        string tituloLivro = Console.ReadLine();
                        Console.Write("Autor: ");
                        string autorLivro = Console.ReadLine();
                        Console.Write("Editora: ");
                        string editoraLivro = Console.ReadLine();
                        Console.Write("Quantidade de exemplares: ");
                        int quantidadeExemplares = int.Parse(Console.ReadLine());
                        Livro novoLivro = new Livro(idLivro, tituloLivro, autorLivro, editoraLivro,
                            quantidadeExemplares);
                        biblioteca.CadastrarLivro(novoLivro);
                        Console.WriteLine("Livro cadastrado com sucesso!");
                        break;

                    case 3:
                        Console.WriteLine("Emprestar Livro:");
                        Console.Write("Id do Livro: ");
                        int idLivroEmprestimo = int.Parse(Console.ReadLine());
                        if (biblioteca.VerifyBookId(idLivroEmprestimo))
                        {
                            Console.WriteLine("Livro já cadastrado.");
                        }
                        else
                        {
                            Console.WriteLine("Livro não cadastrado.");
                            break;
                        }
                        Console.Write("Id da Pessoa: ");
                        int idPessoaEmprestimo = int.Parse(Console.ReadLine());
                        if (biblioteca.VerifyPersonId(idPessoaEmprestimo))
                        {
                            Console.WriteLine("Pessoa já cadastrada.");
                        }
                        else
                        {
                            Console.WriteLine("Pessoa não cadastrada.");
                            break;
                        }
                        biblioteca.EmprestarLivroBiblioteca(idLivroEmprestimo, idPessoaEmprestimo);
                        Console.WriteLine("Livro Emprestado com Sucesso!");
                        Console.WriteLine($"O livro {biblioteca.tituloLivro} foi emprestado para {bibliotenomePessoa}");
                        break;
                    case 4:

                }
                
               // Console.Clear();

            } while (opcao != 0);
        }
    }
}
