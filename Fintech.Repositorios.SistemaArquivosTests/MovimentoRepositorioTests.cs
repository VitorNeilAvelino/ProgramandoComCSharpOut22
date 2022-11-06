using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fintech.Dominio.Entidades;
using System;
using System.Linq;

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
                Console.WriteLine($"{movimento.Data} - {movimento.Operacao} - {movimento.Valor}");
            }
        }

        [TestMethod]
        public void DelegateActionTeste()
        {
            var movimentos = movimentoRepositorio.Selecionar(123, 456);

            //foreach (var movimento in movimentos)
            //{
            //    Console.WriteLine($"{movimento.Data} - {movimento.Operacao} - {movimento.Valor:c}");
            //}

            Action<Movimento> writeLine = m => Console.WriteLine($"{m.Data} - {m.Operacao} - {m.Valor:c}");

            //movimentos.ForEach(EscreverMovimento);
            //movimentos.ForEach(writeLine);
            movimentos.ForEach(m => Console.WriteLine($"{m.Data} - {m.Operacao} - {m.Valor:c}"));
        }

        [TestMethod]
        public void DelegatePredicateTeste()
        {
            var movimentos = movimentoRepositorio.Selecionar(123, 456);

            Predicate<Movimento> obterDepositos = m => m.Operacao == TipoOperacao.Deposito;

            var depositos = movimentos.FindAll(EncontrarMovimentoDeposito);
            depositos = movimentos.FindAll(obterDepositos);
            depositos = movimentos.FindAll(m => m.Operacao == TipoOperacao.Deposito);

            depositos.ForEach(d => Console.WriteLine($"{d.Operacao} - {d.Valor}"));
        }

        [TestMethod]
        public void DelegateFuncTeste()
        {
            var movimentos = movimentoRepositorio.Selecionar(123, 456);

            Func<Movimento, decimal> obterCampoSoma = m => m.Valor;

            var totalDeposito = movimentos
                .Where(m => m.Operacao == TipoOperacao.Deposito)
                .Sum(RetornarCampoSoma);

            totalDeposito = movimentos
                .Where(m => m.Operacao == TipoOperacao.Deposito)
                .Sum(obterCampoSoma);

            totalDeposito = movimentos
                .Where(m => m.Operacao == TipoOperacao.Deposito)
                .Sum(m => m.Valor);

            Console.WriteLine(totalDeposito);
        }

        private decimal RetornarCampoSoma(Movimento m)
        {
            return m.Valor;
        }

        private bool EncontrarMovimentoDeposito(Movimento m)
        {
            return m.Operacao == TipoOperacao.Deposito;
        }

        private void EscreverMovimento(Movimento movimento)
        {
            Console.WriteLine($"{movimento.Data} - {movimento.Operacao} - {movimento.Valor:c}");
        }
    }
}