using System;

namespace hellomono.model
{
	public class Contact
	{		
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EMail { get; set; }
		public string PhoneNumber { get; set; }
		public override string ToString ()
		{
			return $"{FirstName} {LastName}";
		}
	}
}

