
namespace Nhl.Api.Domain.Models.Common
{

	/// <summary>
	/// An NHL API result interface for a response from the NHL API
	/// </summary>
	public interface INhlApiResult<T> where T : class, new()
	{
		/// <summary>
		/// The data provided from the request
		/// </summary>
		T Data { get; set; }

		/// <summary>
		/// Determines whether the request is successful
		/// </summary>
		bool Success { get; set; }
	}
}
