namespace FantasySportsPro.Persistance.Abstraction
{
    public interface IDataAccess
    {
        public Task<int> ExecuteAsync(IDataExecute request);
        public Task<T?> FetchAsync<T>(IDataFetch<T> request);
        public Task<IEnumerable<T>> FetchListAsync<T>(IDataFetch<T> request);
    }
}
