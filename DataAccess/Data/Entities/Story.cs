namespace DataAccess.Data.Entities
{
    public class Story
    {
        public int Id { get; set; }
        public string MediaLink { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
