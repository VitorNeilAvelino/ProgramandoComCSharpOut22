using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fintech.Dominio.Entidades;
using System;

namespace Fintech.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class MovimentoRepositorioTests
    {
        private readonly MovimentoRepositorio movimentoRepositorio = new("Dados\\Movimento.txt");

        [TestMethod()]
        public void InserirTest()
        {
            var agencia = new Agencia { Numero = 123 };
            var conta = new ContaCorrente(agencia, 456, "X");

            var movimento = new Movimento(54, TipoOperacao.Deposito, conta);
            //movimento.Conta = conta;

            movimentoRepositorio.Inserir(movimento);
        }

        [TestMethod()]
        public void SelecionarTest()
        {
            var movimentos = movimentoRepositorio.Selecionar(123, 456);

            foreach (var movimento in movimentos)
            {
                Console.WriteLine($"{movimento.Data} - {movimento.TipoOperacao} - {movimento.Valor}");
            }
        }
    }
}