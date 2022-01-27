namespace Nhl.Api.Models.Common
{

    /// <summary>
    /// An Nhl.Api result interface for a response from the Nhl.Api
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
