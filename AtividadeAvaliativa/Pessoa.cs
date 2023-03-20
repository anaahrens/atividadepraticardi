using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AtividadeAvaliativa
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public List<Livro> LivrosEmprestados { get; set; }

        public Pessoa (int idPessoa, string nome, string cpf, string telefone)
        {
            Id = idPessoa;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            LivrosEmprestados = new List<Livro>();
        }

        public void AdicionarLivroLista (Livro livro)
        {
            LivrosEmprestados.Add(livro);
        }

        public void RemoverLivroLista (int idLivro)
        {
            LivrosEmprestados.RemoveAll(l => l.Id == idLivro);
        }
    }
}
