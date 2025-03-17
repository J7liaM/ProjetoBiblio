using Biblio.DAL;
using Biblio.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio.BLL
{
    public class LivroRequisicaoBLL
    {
        LivroRequisicaoDTO livroRequisicaoDTO = new LivroRequisicaoDTO();
        LivroRequisicaoDAL livroRequisicaoDAL = new LivroRequisicaoDAL();

        // CRUD

        // CREATE
        public void CreateLivroRequisicaoBLL(LivroRequisicaoDTO livro)
        {
            livroRequisicaoDAL.CreateLivroRequisicao(livro);
        }
    }
}
    

