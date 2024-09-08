namespace Atividade
{
    public class Clientes
    {
        // Propriedades
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public float Valor { get; protected set; }
        public float ValorImposto { get; protected set; }
        public float Total { get; protected set; }

        // Método
        public virtual void PagarImposto(float v)
        {
            this.Valor = v;
            this.ValorImposto = this.Valor * 0.10f; // 10% de imposto
            this.Total = this.Valor + this.ValorImposto;
        }
    }
}
