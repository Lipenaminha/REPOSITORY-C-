namespace C_.Entities
{
    class SavingAccount : Account
    {

        public double InteRest { get; set; }


        public SavingAccount()
        {

        }

        // utilizando a palavra base para fazer a herança de metodos.
        public SavingAccount(int number, string holder, double balance, double interest) 
            : base(number, holder, balance)
        {

            InteRest = interest;

        }

        public void UpdateBalance()
        {
            Balance += Balance * InteRest;
        }

        // aqui estamos fazendo a sobreposição de métodos da superclasse para a subclasse.
        public override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            // e podemos acrescentar também como remover 2 reais da conta ;
            Balance -= 2.0;
        }
    }
}
