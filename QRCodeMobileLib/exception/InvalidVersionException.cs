using System;
namespace ThoughtWorks.QRCode.ExceptionHandler
{
	public class InvalidVersionException:VersionInformationException
	{
        internal String message;
		public override String Message
		{
			get
			{
				return message;
			}
			
		}
		
		public InvalidVersionException(String message)
		{
			this.message = message;
		}
	}
}