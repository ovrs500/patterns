namespace Builder
{
    public interface IItem
    {
        string name();
        IPacking packing();
        float price();
    }
}