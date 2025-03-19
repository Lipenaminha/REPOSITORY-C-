namespace C_.Entities
{
    class Client
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateBirth { get; set; }

        public Client()
        {

        }

        public Client(string name, string email, DateTime dateBirth)
        {
            Name = name;
            Email = email;
            DateBirth = dateBirth;
        }
    }
}
