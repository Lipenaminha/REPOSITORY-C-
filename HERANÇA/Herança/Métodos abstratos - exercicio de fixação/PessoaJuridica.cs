namespace C_.Entities
{
    class PessoaJuridica : Imposto
    {
       
        public int Numerofuncionarios { get; set; }


        public PessoaJuridica(string name, double anualincome, int numerofuncionarios) 
            :base (name,anualincome) 
        {

            Numerofuncionarios = numerofuncionarios;
        
        }

        public override double Paytax()
        {

            if(Numerofuncionarios > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
