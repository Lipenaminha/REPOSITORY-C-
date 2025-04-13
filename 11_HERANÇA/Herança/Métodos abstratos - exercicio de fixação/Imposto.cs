namespace C_.Entities
{
    abstract public class Imposto
    {
      
        public string Name { get; set; }
        public double AnualIncome { get; set; }


        public Imposto()
        {

        }

        //Protected permite que somente a superclasse ou as classes herdeiras possam utilizar. 
        // Significa que não queremos instanciar para classe base. Mas sim que seja usada como base e herança.
        protected Imposto(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Paytax();


    }
}
