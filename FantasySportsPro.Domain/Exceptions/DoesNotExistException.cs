namespace FantasySportsPro.Domain.Exceptions
{
    public class DoesNotExistException : Exception
    {
        public readonly string NameOfObjectNotExisting;

        public readonly IEnumerable<string> ValuesSearchedBy = Enumerable.Empty<string>();

        public DoesNotExistException(string nameOfObjectNotExisting, params (object? Value, string NameOfValue)[] valuesSearchedBy)
        {
            NameOfObjectNotExisting = nameOfObjectNotExisting;

            ValuesSearchedBy = valuesSearchedBy.Select(_ => $"{_.NameOfValue} : {_.Value}");
        }
    }
}
