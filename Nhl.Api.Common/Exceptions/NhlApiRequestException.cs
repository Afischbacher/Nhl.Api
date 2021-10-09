using System;
using System.Collections.Generic;
using System.Text;

namespace Nhl.Api.Common.Exceptions
{
	/// <summary>
	/// An exception for a failed NHL API HTTP request
	/// </summary>
	public class NhlApiRequestException : Exception
	{
		public NhlApiRequestException(string message) : base()
		{

		}
	}
}
