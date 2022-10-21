namespace Fintech.Dominio.Entidades
{
    public class Poupanca : Conta
    {
        //public Poupanca()
        //{
        //    TaxaRendimento = 0.5m;
        //}

        public decimal TaxaRendimento { get; set; } = 0.5m;
        public decimal TaxaCdi { get; set; }
    }
}