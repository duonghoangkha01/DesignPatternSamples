namespace DesignPatternSamples.Creation.PrototypePattern
{
    public class Person : IPrototype<Person>
    {
        public int Age;
        public DateTime BirthDate;
        public string Name = string.Empty;
        public IdInfo IdInfo = new IdInfo(0);

        public Person ShallowCopy() => (Person)MemberwiseClone();

        public Person DeepCopy()
        {
            Person clone = (Person)MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = Name;
            return clone;
        }
    }

    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            IdNumber = idNumber;
        }
    }
}
