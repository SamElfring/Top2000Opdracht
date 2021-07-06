namespace Top2000.Models
{
    public class BigViewModel
    {
        [Key]
        public int ID { get; set; }
        public Lijst Lijst { get; set; }
        public Song Song { get; set; }
    }
}
