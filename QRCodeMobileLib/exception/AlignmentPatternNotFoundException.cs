using System;
namespace ThoughtWorks.QRCode.ExceptionHandler
{
	public class AlignmentPatternNotFoundException:System.ArgumentException
	{
        internal String message = null;

		public override String Message
		{
			get
			{
				return message;
			}
			
		}		
		public AlignmentPatternNotFoundException(String message)
		{
			this.message = message;
		}
	}
}