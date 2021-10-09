
namespace Nhl.Api.Domain.Models.Common
{
	public interface INhlApiResult<T> where T : class, new()
	{
		T Data { get; set; }

		bool Success { get; set; }
	}
}
