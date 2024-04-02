namespace Task5.Models
{
    public class Item
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public Item(int id, double price, string name)
        {
            Id = id;
            Price = price;
            Name = name;
        }
    }
}
