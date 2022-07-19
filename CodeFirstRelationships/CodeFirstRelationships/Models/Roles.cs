namespace CodeFirstRelationships.Models
{
    public class Roles
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
