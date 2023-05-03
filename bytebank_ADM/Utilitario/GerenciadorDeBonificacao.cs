using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificao { get; private set; }
        public void Registar(Funcionario funcionario)
        {
            this.TotalDeBonificao += funcionario.GetBonificacao();
        }
    }
}
