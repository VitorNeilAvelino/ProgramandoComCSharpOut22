using System;

namespace Fintech.Dominio.Entidades
{
    public class Movimento
    {
        /// <summary>
        /// Construtor vazio - imposição do Dapper.
        /// </summary>
        public Movimento()
        {

        }

        // ToDo: OO - polimorfismo por sobrecarga
        public Movimento(decimal valor, TipoOperacao tipoOperacao)
        {
            Valor = valor;
            Operacao = tipoOperacao;
        }

        public Movimento(decimal valor, TipoOperacao tipoOperacao, Conta conta)
        {
            Valor = valor;
            Operacao = tipoOperacao;
            Conta = conta;
        }

        public int Id { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public DateTime Data { get; set; } = DateTime.Now;
        public TipoOperacao Operacao { get; set; }
        public decimal Valor { get; set; }
        public Conta Conta { get; set; } //= new Conta();
    }
}