namespace AppDomain.Entities
{
    public class Receita
    {
        public int ReceitaId { get; private set; }
        public string Nome { get; private set; }
        public string ModoPreparo { get; private set; }
        public DateTime TempoPreparo { get; private set; }
        public int Rendimento { get; private set; }

        public void CadastrarReceita()
        {

        }

        public void AlterarReceita()
        {

        }

        public void AlterarStatus()
        {
            
        }
    }
}