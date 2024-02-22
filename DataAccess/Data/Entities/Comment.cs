namespace DataAccess.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int? AccountId { get; set; }
        public Account? Account { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
