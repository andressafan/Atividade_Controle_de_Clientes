namespace Atividade
{
    public class Pessoa_Juridica : Clientes
    {
        public string Cnpj { get; set; }
        public string Ie { get; set; }

        // Sobrescrevendo o método PagarImposto
        public override void PagarImposto(float v)
        {
            this.Valor = v;
            this.ValorImposto = this.Valor * 0.20f; // 20% de imposto para Pessoa Jurídica
            this.Total = this.Valor + this.ValorImposto;
        }
    }
}
