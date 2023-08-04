namespace JaxWorld.Data.Entities.Blockchain
{
    using Profiles;

    public class Standard : Entity
    {
        public Standard()
        {
            Profiles = new HashSet<Profile>();
        }

        public string Name { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}
