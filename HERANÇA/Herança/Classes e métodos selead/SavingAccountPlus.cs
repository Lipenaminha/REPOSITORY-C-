namespace C_.Entities
{

    //aqui o método está selado então não conseguimos fazer a sobreposição para essa subclasse
    class SavingAccountPlus : SavingAccount
    {
        public override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            // e podemos acrescentar também como remover 2 reais da conta ;
            Balance -= 2.0;
        }
    }
}
