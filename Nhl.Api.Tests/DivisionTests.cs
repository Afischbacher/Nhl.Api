using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Enumerations.Division;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{

	[TestClass]
	public class DivisionTests
	{

		[TestMethod]
		public async Task TestGetAllDivisionsAsync()
		{
			// Arrange
			using INhlApi nhlApi = new NhlApi();

			// Act 
			var divisions = await nhlApi.GetDivisionsAsync();

			// Assert
			Assert.IsNotNull(divisions);
			CollectionAssert.AllItemsAreNotNull(divisions);

			foreach (var division in divisions)
			{
				Assert.IsNotNull(division.Abbreviation);
				Assert.IsNotNull(division.Id);
				Assert.IsNotNull(division.Link);
				Assert.IsNotNull(division.Name);
				Assert.IsNotNull(division.NameShort);
			}
		}

		[TestMethod]
		public async Task TestGetDivisionByIdAsync()
		{
			// Arrange
			using INhlApi nhlApi = new NhlApi();

			// Act 
			var division = await nhlApi.GetDivisionByIdAsync(17);

			// Assert
			Assert.IsNotNull(division);
			Assert.IsNotNull(division.Abbreviation);
			Assert.IsNotNull(division.Id);
			Assert.IsNotNull(division.Link);
			Assert.IsNotNull(division.Name);
			Assert.IsNotNull(division.NameShort);
		}

		[TestMethod]
		public async Task TestGetDivisionByIdEnumAsync()
		{
			// Arrange
			using INhlApi nhlApi = new NhlApi();

			// Act 
			var division = await nhlApi.GetDivisionByIdAsync(DivisionEnum.Metropolitan);

			// Assert
			Assert.IsNotNull(division);
			Assert.IsNotNull(division.Abbreviation);
			Assert.IsNotNull(division.Id);
			Assert.IsNotNull(division.Link);
			Assert.IsNotNull(division.Name);
			Assert.IsNotNull(division.NameShort);
		}

		[TestMethod]
		public async Task TestGetDivisionWithInvalidIdAsync()
		{
			// Arrange
			using INhlApi nhlApi = new NhlApi();

			// Act 
			var division = await nhlApi.GetDivisionByIdAsync(999);

			// Assert
			Assert.IsNull(division);
		}
	}
}

