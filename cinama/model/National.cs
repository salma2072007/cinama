namespace cinama.model
{
    public class National
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        public int ? directorId { get; set; }
        public Director? Director { get; set; }

    }
}
