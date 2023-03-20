using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAvaliativa
{
    public class Livro
    {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int QuantidadeExemplares { get; set; }

        public Livro(int idLivro, string tituloLivro, string autorLivro, string editoraLivro,
            int quantidadeExemplares)
        {
            Id = idLivro;
            Titulo = tituloLivro;
            Autor = autorLivro;
            Editora = editoraLivro;
            QuantidadeExemplares = quantidadeExemplares;

        }

        public void EmprestarLivro (int quantidadeEmprestada)
        {
            QuantidadeExemplares -= quantidadeEmprestada;
        }

        public void DevolverLivro (int quantidadeDevolvida)
        {
            QuantidadeExemplares += quantidadeDevolvida;
        }
    }

}




