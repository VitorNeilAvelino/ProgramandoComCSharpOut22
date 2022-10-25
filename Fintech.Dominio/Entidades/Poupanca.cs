namespace Fintech.Dominio.Entidades
{
    public class Poupanca : Conta
    {
        public Poupanca(Agencia agencia, int numero, string digitoVerificador) : base(agencia, numero, digitoVerificador)
        {
            //Agencia = agencia;
            //Numero = numero;
            //DigitoVerificador = digitoVerificador;
        }

        //public Poupanca()
        //{
        //    TaxaRendimento = 0.5m;
        //}

        public decimal TaxaRendimento { get; set; } = 0.5m;
        public decimal TaxaCdi { get; set; }
    }
}