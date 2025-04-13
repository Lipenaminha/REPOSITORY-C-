namespace C_.Entities
{
    class PessoaFisica : Imposto
    {
      

        
        public double GastosSaude { get; set; }


        public PessoaFisica(string Name, double anualincome, double gastossaude)
            : base(Name, anualincome)
        {
            GastosSaude = gastossaude;
        }


        public override double Paytax()
        {
            if (AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15 - GastosSaude * 0.50;
            }
            else

            {
                return AnualIncome * 0.25 - GastosSaude * 0.50;
            }
        }
            

        

        public override string ToString()
        {
            return Name
                + " R$ "
                + Paytax().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
