using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Enumerations.Franchise;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
	[TestClass]
	public class FranchisesTests
	{

		[TestMethod]
		public async Task TestGetFranchisesAsync()
		{
			// Arrange
			var nhlApi = new NhlApi();

			// Act 
			var franchises = await nhlApi.GetFranchisesAsync();

			// Assert
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
			// Arrange
			var nhlApi = new NhlApi();

			// Act 
			var franchises = await nhlApi.GetActiveFranchisesAsync();

			// Assert
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
			// Arrange
			var nhlApi = new NhlApi();

			// Act 
			var franchises = await nhlApi.GetInactiveFranchisesAsync();

			// Assert
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
		public async Task TestGetFranchiseByIdEnumAsync()
		{
			// Arrange
			var nhlApi = new NhlApi();

			// Act 
			var franchise = await nhlApi.GetFranchiseByIdAsync(FranchiseEnum.MontrealWanderers);

			// Assert
			Assert.IsNotNull(franchise);
			Assert.IsNotNull(franchise.FirstSeasonId);
			Assert.IsNotNull(franchise.Link);
			Assert.IsNotNull(franchise.LocationName);
			Assert.IsNotNull(franchise.TeamName);
			Assert.IsNotNull(franchise.MostRecentTeamId);
		}

		[TestMethod]
		public async Task TestGetFranchiseByIdAsync()
		{
			// Arrange
			var nhlApi = new NhlApi();

			// Act 
			var franchise = await nhlApi.GetFranchiseByIdAsync(10);

			// Assert
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
			// Arrange
			var nhlApi = new NhlApi();

			// Act 
			var franchise = await nhlApi.GetFranchiseByIdAsync(999);

			// Assert
			Assert.IsNull(franchise);
		}
	}
}
