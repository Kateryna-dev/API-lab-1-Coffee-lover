namespace API_Interactive_Lab_1.Models
{
    public class Cocktail
    { 
        public string Name { get; set; }
        public int Price { get; set; }

        public Cocktail(string name, int price)
        {
            Name = name;
            Price = price;
        }   
    }
}
