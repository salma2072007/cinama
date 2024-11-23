namespace cinama.model
{
    public class Director
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? contect { get; set; }

        public string ?Email { get; set; }

        public List <Movies>? Movies { get; set; }

        public National ?Nationalty { get; set; }
    }
}
