namespace C_.Entities
{
    class SavingAccount : Account
    {

        public double InteRest { get; set; }


        public SavingAccount()
        {

        }

        public SavingAccount(int number, string holder, double balance, double interest) 
            : base(number, holder, balance)
        {

            InteRest = interest;

        }

        public void UpdateBalance()
        {
            Balance += Balance * InteRest;
        }
    }
}
