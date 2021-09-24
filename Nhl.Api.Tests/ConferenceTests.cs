using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
	[TestClass]
	public class ConferenceTests
	{

		[TestMethod]
		public async Task TestGetConferencesAsync()
		{
			INhlApi nhlApi = new NhlApi();

			var conferences = await nhlApi.GetAllConferencesAsync();

			Assert.IsNotNull(conferences);
			CollectionAssert.AllItemsAreNotNull(conferences);

			foreach (var conference in conferences)
			{
				Assert.IsNotNull(conference.Id);
				Assert.IsNotNull(conference.Link);
				Assert.IsNotNull(conference.Name);
				Assert.IsNotNull(conference.Abbreviation);
				Assert.IsNotNull(conference.Active);
				Assert.IsNotNull(conference.ShortName);
			}
		}

		[TestMethod]
		public async Task TestGetConferenceByIdAsync()
		{
			INhlApi nhlApi = new NhlApi();

			var conference = await nhlApi.GetConferenceByIdAsync(6);

			Assert.IsNotNull(conference.Id);
			Assert.IsNotNull(conference.Link);
			Assert.IsNotNull(conference.Name);
			Assert.IsNotNull(conference.Abbreviation);
			Assert.IsNotNull(conference.Active);
			Assert.IsNotNull(conference.ShortName);
		}

		[TestMethod]
		public async Task TestGetConferenceWithInvalidIdAsync()
		{
			INhlApi nhlApi = new NhlApi();

			var conference = await nhlApi.GetConferenceByIdAsync(999);

			Assert.IsNull(conference);
		}
	}
}
