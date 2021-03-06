using System;
using System.Runtime.Serialization;

namespace Blazor.Application.Articles.Managing.Exceptions
{
	[Serializable]
	public class NoContentChangedException : Exception
	{
		public NoContentChangedException()
		{
		}

		public NoContentChangedException(string message) : base(message)
		{
		}

		public NoContentChangedException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected NoContentChangedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}


}
