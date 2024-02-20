using FantasySportsPro.Domain.Constants;
using FantasySportsPro.Persistance.Abstraction;

namespace FantasySportsPro.Persistance.DataRequests.Players
{
    public class DeletePlayer : IDataExecute
    {
        public int Id { get; set; }
        public DeletePlayer(int id)
        {
            Id = id;
        }

        public object? GetParameters() => this;

        public string GetSql() =>
        $@"
            DELETE FROM {DatabaseConstants.TableNames.Players}
            WHERE Id = @Id;
        ";
    }
}
