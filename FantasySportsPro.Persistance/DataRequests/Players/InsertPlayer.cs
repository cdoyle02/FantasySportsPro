using FantasySportsPro.Domain.Constants;
using FantasySportsPro.Persistance.Abstraction;

namespace FantasySportsPro.Persistance.DataRequests.Players
{
    public class InsertPlayer : IDataExecute
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? NickName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? JerseyNumber { get; set; }
        public InsertPlayer(string firstName, string lastName, string? nickName, DateTime? dateOfBirth, int? jerseyNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            NickName = nickName;
            DateOfBirth = dateOfBirth;
            JerseyNumber = jerseyNumber;
        }

        public object? GetParameters() => this;

        public string GetSql() =>
        @$"
            INSERT INTO {DatabaseConstants.TableNames.Players} (FirstName, LastName, NickName, DateOfBirth, JerseyNumber)
            VALUES (@FirstName, @LastName, @NickName, @DateOfBirth, @JerseyNumber)
        ";

    }
}
