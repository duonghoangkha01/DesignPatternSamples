namespace DesignPatternSamples.Behaviour.NullObjectPattern
{
    public class User
    {
        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }

        public virtual bool HasAccess()
        {
            //just assume condition to has a access
            return Name == "Bob";
        }
    }
}