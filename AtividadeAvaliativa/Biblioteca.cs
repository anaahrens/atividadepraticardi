using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa
{
    public class Biblioteca
    {
        public List<Pessoa> Pessoas { get; set; }
        public List<Livro> Livros { get; set; }

        public Biblioteca()
        {
            Pessoas = new List<Pessoa>();
            Livros = new List<Livro>();
        }

        /// <summary>
        /// Method to add a person to the Biblioteca person list
        /// </summary>
        /// <param name="pessoa">The person to be added to the list</param>
        public void CadastrarPessoa(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);
        }

        public void CadastrarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public bool VerifyPersonId(int PessoaID)
        {

            if (Pessoas.Exists(p => p.Id == PessoaID))
            {
                return true;
            }

            return false;   
        }

        public bool VerifyBookId(int BookID)
        {

            if (Livros.Exists(l => l.Id == BookID))
            {
                return true;
            }

            return false;
        }


        public void EmprestarLivroBiblioteca(int idLivro, int idPessoa)
        {
            Livro livro = Livros.Find(l => l.Id == idLivro);
            Pessoa pessoa = Pessoas.Find(p => p.Id == idPessoa);

            if (livro != null && pessoa != null)
            {
                livro.EmprestarLivro(1);
                pessoa.AdicionarLivroLista(livro);
            }
        }

        public void DevolverLivroBiblioteca(int idLivro, int idPessoa)
        {
            Livro livro = Livros.Find(l => l.Id == idLivro);
            Pessoa pessoa = Pessoas.Find(p => p.Id == idPessoa);

            if (livro != null && pessoa != null)
            {
                livro.DevolverLivro(1);
                pessoa.RemoverLivroLista(idLivro);
            }
        }

        internal object CadastrarPessoa (int idPessoa)
        {
            throw new NotImplementedException();
        }
    }
}