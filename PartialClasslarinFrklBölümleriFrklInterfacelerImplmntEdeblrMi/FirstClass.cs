using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasslarinFrklBölümleriFrklInterfacelerImplmntEdeblrMi
{
	public partial class FirstClass : FirstInterface
	{
		public int FirstProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public void FirstMethod()
		{
			throw new NotImplementedException();
		}

		public string SecondMethod()
		{
			return "Ozan";
		}

		public int ThirdMethod()
		{
			return 33;
		}
	}
}
