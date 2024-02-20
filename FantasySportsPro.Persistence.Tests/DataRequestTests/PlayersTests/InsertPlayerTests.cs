using FantasySportsPro.Domain.Models;
using FantasySportsPro.Persistance.DataRequests.Players;

namespace FantasySportsPro.Persistence.Tests.DataRequestTests.PlayersTests
{
    public class InsertPlayerTests : DataRequestTest
    {
        [Fact]
        public async Task InsertPlayer_Given_PlayerInserted_ShouldReturn1RowAffected()
        {
            var testPlayer = new InsertPlayer("TestFirstName", "TestLastName", "The Big Pepperoni", DateTime.Today, 2);

            var response = await _dataAccess.ExecuteAsync(testPlayer);

            Assert.Equal(1, response);

            var player = await _dataAccess.FetchAsync(new FetchPlayer(testPlayer.FirstName, testPlayer.LastName, testPlayer.DateOfBirth));

            await _dataAccess.ExecuteAsync(new DeletePlayer(player!.Id));
        }
    }
}
