namespace PrototypePattern;

public class Person(int age, DateTime birthDate, string name, IdInfo idInfo)
{
    public int      Age       = age;
    public DateTime BirthDate = birthDate;
    public string   Name      = name;
    public IdInfo   IdInfo    = idInfo;

    public Person ShallowCopy()
    {
        return (Person) MemberwiseClone();
    }

    public Person DeepCopy()
    {
        var clone = (Person) MemberwiseClone();

        clone.IdInfo = new IdInfo(IdInfo.IdNumber);

        return clone;
    }
}