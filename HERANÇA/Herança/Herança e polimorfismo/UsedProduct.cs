namespace C_.Entities
{
    class UsedProduct : Product
    {

        public DateTime manufactureDate { get; set; }


        public UsedProduct()
        {

        }
        public UsedProduct(string name , double price ,DateTime manufacturedate)
            : base(name, price)
        {
            manufactureDate = manufacturedate;
        }

        public override string priceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + manufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
