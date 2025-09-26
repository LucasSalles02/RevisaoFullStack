using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAcademico.Dominio;

namespace SistemaAcademico.Repositorio
{
    public interface IAlunoRepositorio
    {
        void Adicionar(Aluno aluno);
        List<Aluno> Listar();
    }
}
