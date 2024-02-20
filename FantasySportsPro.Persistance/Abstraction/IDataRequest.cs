namespace FantasySportsPro.Persistance.Abstraction
{
    public interface IDataRequest
    {
        public string GetSql();

        public object? GetParameters();
    }
}
