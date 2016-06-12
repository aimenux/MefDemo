namespace MefDemo.Contracts
{
    public interface IService
    {
        string Description { get; }
        int Opertation(int a, int b);
    }
}
