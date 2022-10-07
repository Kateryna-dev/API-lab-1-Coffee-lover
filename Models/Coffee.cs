namespace API_Interactive_Lab_1.Models
{
    public class Coffee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Coffee(int id, string name) 
        {
            Id = id;
            Name = name;
        }
    }
}
