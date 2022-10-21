namespace Fintech.Dominio.Entidades
{
    public class ContaCorrente : Conta
    {
        public bool EmissaoChequeHabilitada { get; set; }
        public bool DebitoAutomaticoHabilitado { get; set; }
    }
}