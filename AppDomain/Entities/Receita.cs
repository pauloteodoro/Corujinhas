using System;

namespace AppDomain.Entities
{
    public class Receita : EntidadeDominio
    {
        public Receita(string nome, string modoPreparo, DateTime tempoPreparo, int rendimento)
        {
            Nome = nome;
            ModoPreparo = modoPreparo;
            TempoPreparo = tempoPreparo;
            Rendimento = rendimento;
        }

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