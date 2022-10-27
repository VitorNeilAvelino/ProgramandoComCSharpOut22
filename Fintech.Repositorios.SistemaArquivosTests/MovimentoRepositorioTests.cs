﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fintech.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fintech.Dominio.Entidades;

namespace Fintech.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class MovimentoRepositorioTests
    {
        private readonly MovimentoRepositorio movimentoRepositorio = new ("Dados\\Movimento.txt");

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
        }
    }
}