namespace C_.Entities
{
    class BusinessAccount : Account
    {

        public double Loanlimit { get; set; }


        public BusinessAccount()
        {

        }

        //palavra base serve para fazer a herança de um método para outra classe.
        public BusinessAccount(int number, string holder, double balance, double loanlimit) : base(number, holder, balance)
        {
            Loanlimit = loanlimit;
        }

        public void Loan(double amount)
        {
            if(amount <= Loanlimit)
            {
                Balance += amount;
            }

        }

       

    }
}
