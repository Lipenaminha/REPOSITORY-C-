namespace Course.Entities.Exception
{ 

    // aqui é o dominio da exception, lembrando que a applicationexception é uma subclasse da generalização 'EXCEPTION'

    class DomainException : ApplicationException
    {

        public DomainException(string message) : base(message) { }


    }
}
