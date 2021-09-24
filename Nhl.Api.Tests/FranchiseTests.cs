using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Http;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
	[TestClass]
	public class FranchisesTests
	{

		[TestMethod]
		public async Task TestGetFranchisesAsync()
		{
			var nhlApi = new NhlApi();

			var franchises = await nhlApi.GetAllFranchisesAsync();

			Assert.IsNotNull(franchises);
			CollectionAssert.AllItemsAreNotNull(franchises);

			foreach (var franchise in franchises)
			{
				Assert.IsNotNull(franchise.FirstSeasonId);
				Assert.IsNotNull(franchise.Link);
				Assert.IsNotNull(franchise.LocationName);
				Assert.IsNotNull(franchise.TeamName);
				Assert.IsNotNull(franchise.MostRecentTeamId);
			}
		}

		[TestMethod]
		public async Task TestGetAllActiveFranchisesAsync()
		{
			var nhlApi = new NhlApi();

			var franchises = await nhlApi.GetAllActiveFranchisesAsync();

			Assert.IsNotNull(franchises);
			CollectionAssert.AllItemsAreNotNull(franchises);

			foreach (var franchise in franchises)
			{
				Assert.IsNotNull(franchise.FirstSeasonId);
				Assert.IsNotNull(franchise.Link);
				Assert.IsNotNull(franchise.LocationName);
				Assert.IsNotNull(franchise.TeamName);
				Assert.IsNotNull(franchise.MostRecentTeamId);
			}
		}


		[TestMethod]
		public async Task TestGetAllInactiveFranchisesAsync()
		{
			var nhlApi = new NhlApi();

			var franchises = await nhlApi.GetAllInactiveFranchisesAsync();

			Assert.IsNotNull(franchises);
			CollectionAssert.AllItemsAreNotNull(franchises);

			foreach (var franchise in franchises)
			{
				Assert.IsNotNull(franchise.FirstSeasonId);
				Assert.IsNotNull(franchise.Link);
				Assert.IsNotNull(franchise.LocationName);
				Assert.IsNotNull(franchise.TeamName);
				Assert.IsNotNull(franchise.MostRecentTeamId);
			}
		}


		[TestMethod]
		public async Task TestGetFranchiseByIdAsync()
		{
			var nhlApi = new NhlApi();

			var franchise = await nhlApi.GetFranchiseByIdAsync(10);

			Assert.IsNotNull(franchise);
			Assert.IsNotNull(franchise.FirstSeasonId);
			Assert.IsNotNull(franchise.Link);
			Assert.IsNotNull(franchise.LocationName);
			Assert.IsNotNull(franchise.TeamName);
			Assert.IsNotNull(franchise.MostRecentTeamId);
		}

		[TestMethod]
		public async Task TestGetFranchiseWithInvalidIdAsync()
		{
			var nhlApi = new NhlApi();

			var franchise = await nhlApi.GetFranchiseByIdAsync(999);

			Assert.IsNull(franchise);
		}
	}
}
