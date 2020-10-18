namespace Creational.Prototype
{
    public class Person
    {
        public int Age;
        public IdInfo IdInfo;
        public string Name;

        public Person ShallowCopy()
        {
            return (Person) MemberwiseClone();
        }

        public Person DeepCopy()
        {
            var other = (Person) MemberwiseClone();
            other.IdInfo = new IdInfo(IdInfo.IdNumber);
            other.Name = string.Copy(Name);
            return other;
        }
    }
}