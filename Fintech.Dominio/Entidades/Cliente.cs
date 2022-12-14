using System;
using System.Collections.Generic;

namespace Fintech.Dominio.Entidades
{
    // ToDo: OO - classificação (abstração): classe
    public class Cliente
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Sexo Sexo { get; set; }
        public Endereco EnderecoResidencial { get; set; } //= new Endereco();
        public List<Conta> Contas { get; set; } = new List<Conta>();
    }
}