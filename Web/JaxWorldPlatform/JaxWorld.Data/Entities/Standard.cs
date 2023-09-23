namespace JaxWorld.Data.Entities
{
    using Base;

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
