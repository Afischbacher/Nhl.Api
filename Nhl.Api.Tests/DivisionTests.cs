using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{

	[TestClass]
	public class DivisionTests
	{

		[TestMethod]
		public async Task TestGetAllDivisionsAsync()
		{
			INhlApi nhlApi = new NhlApi();

			var divisions = await nhlApi.GetDivisionsAsync();

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
			INhlApi nhlApi = new NhlApi();

			var division = await nhlApi.GetDivisionByIdAsync(17);

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
			INhlApi nhlApi = new NhlApi();

			var division = await nhlApi.GetDivisionByIdAsync(999);

			Assert.IsNull(division);
		}
	}
}

