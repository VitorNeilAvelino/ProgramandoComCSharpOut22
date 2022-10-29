using Fintech.Dominio.Entidades;
using Fintech.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fintech.Repositorios.SqlServer
{
    public class MovimentoRepositorio : IMovimentoRepositorio
    {
        public void Inserir(Movimento movimento)
        {
            throw new NotImplementedException();
        }

        public Task<List<Movimento>> SelecionarAsync(int numeroAgencia, int numeroConta)
        {
            throw new NotImplementedException();
        }
    }
}
