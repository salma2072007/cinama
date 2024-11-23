namespace cinama.model
{
    public class Movies
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public DateTime? Date { get; set; }

        public List<Director>? Directors { get; set; }
        public Category? Category { get; set; }
    }
}
