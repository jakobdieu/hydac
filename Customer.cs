using System;
namespace hydac_customer
{
	public class Customer
	{
        public string name;
        public string CVR;
		//public Location location;

        public Customer(string name, string CVR)
		{
			name = name;
			CVR = CVR;

		}
		public string GetName()
		{
			return name;


		}
		public void SetName(string NewName)
		{
			name = NewName;
		}

		public string GetCVR()
		{
			return CVR;

		}
		public void SetCVR(string NewCVR)
		{
			CVR = NewCVR;
		}




    }
}