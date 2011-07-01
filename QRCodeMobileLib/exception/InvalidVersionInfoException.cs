using System;
namespace ThoughtWorks.QRCode.ExceptionHandler
{
	public class InvalidVersionInfoException:VersionInformationException
	{
        internal String message = null;
		public override String Message
		{
			get
			{
				return message;
			}
			
		}
		
		public InvalidVersionInfoException(String message)
		{
			this.message = message;
		}
	}
}