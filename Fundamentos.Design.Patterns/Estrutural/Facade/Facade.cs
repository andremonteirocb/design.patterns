using Design.Patterns.Facade.Domain;

namespace Design.Patterns.Facade
{
    public class Facade
    {
        protected Transacao _transacao;
        protected Impressao _impressao;
        public Facade(Transacao transacao, Impressao impressao)
        {
            _transacao = transacao;
            _impressao = impressao;
        }

        public bool Pagar()
        {
            _transacao.EfetuarPagamento();
            _impressao.Imprimir();

            return true;
        }
    }
}
