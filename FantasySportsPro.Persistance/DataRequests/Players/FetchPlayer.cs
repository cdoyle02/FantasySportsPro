using FantasySportsPro.Domain.Constants;
using FantasySportsPro.Domain.Models;
using FantasySportsPro.Persistance.Abstraction;

namespace FantasySportsPro.Persistance.DataRequests.Players
{
    public class FetchPlayer : IDataFetch<Player>
    {
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public FetchPlayer(int id) => Id = id;
        public FetchPlayer(string firstName, string lastName, DateTime? dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public object? GetParameters()
        {
            if (Id != null)
                return new { Id };

            return new { FirstName, LastName, DateOfBirth };
        }

        public string GetSql() =>
            Id != null
                ? $@"SELECT * FROM {DatabaseConstants.TableNames.Players} WHERE Id = @Id"
                : $@"SELECT * FROM {DatabaseConstants.TableNames.Players} WHERE FirstName = @FirstName AND LastName = @LastName AND (@DateOfBirth IS NULL OR DateOfBirth = @DateOfBirth)";
    }
}
