namespace Fintech.Dominio.Entidades
{
    // ToDo: OO - herança
    public class ContaCorrente : Conta
    {
        public ContaCorrente(Agencia agencia, int numero, string digitoVerificador) : base(agencia, numero, digitoVerificador)
        {
            //Agencia = agencia;
            //Numero = numero;
            //DigitoVerificador = digitoVerificador;
        }

        public bool EmissaoChequeHabilitada { get; set; }
        public bool DebitoAutomaticoHabilitado { get; set; }
    }
}