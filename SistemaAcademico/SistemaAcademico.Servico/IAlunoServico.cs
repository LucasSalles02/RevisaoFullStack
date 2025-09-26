using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAcademico.Dominio;

namespace SistemaAcademico.Servico
{
    public interface IAlunoServico
    {
        void Adicionar(Aluno aluno);
        List<Aluno> Listar();
    }
}
