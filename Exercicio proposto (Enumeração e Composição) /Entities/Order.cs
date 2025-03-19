namespace C_.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public List<OrderItem> Items = new List<OrderItem>();

        public Client Client { get; set; }

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client= client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        
        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder oo = new StringBuilder();
            oo.AppendLine("Order Moment : " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            oo.AppendLine("Order Status " + Status);
            oo.AppendLine("Client " + Client);
            oo.AppendLine("Order Items : ");
            foreach (OrderItem item in Items)
            {
                oo.AppendLine(item.ToString());
            }
            oo.AppendLine("Total price : $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return oo.ToString();

        }
    }

}
