using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Fintech.Dominio.Entidades;

namespace Fintech.Repositorios.SqlServer.Tests
{
    [TestClass()]
    public class MovimentoRepositorioTests
    {
        private readonly MovimentoRepositorio movimentoRepositorio = new(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Fintech;Integrated Security=True");

        [TestMethod]
        public void InserirTest()
        {
            var agencia = new Agencia { Numero = 123 };
            var conta = new ContaCorrente(agencia, 456, "X");

            var movimento = new Movimento(58, TipoOperacao.Deposito, conta);
            //movimento.Conta = conta;

            movimentoRepositorio.Inserir(movimento);
        }

        [TestMethod()]
        public void SelecionarAsyncTest()
        {
            var movimentos = movimentoRepositorio.SelecionarAsync(0, 456).Result;

            foreach (var movimento in movimentos)
            {
                Console.WriteLine($"{movimento.Data} - {movimento.Operacao} - {movimento.Valor:c}");
            }
        }
    }
}