namespace C_.Entities
{

    // A classe abstrata pode conter atributos, construtores e métodos (inclusive métodos abstratos).
    // Ela **não pode ser instanciada**, mas pode ser herdada por outras classes.
    // Apenas as subclasses concretas (não abstratas) podem ser instanciadas.
    // A classe abstrata pode implementar métodos comuns e deixar outros como abstratos para serem sobrescritos nas subclasses.
    abstract class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
